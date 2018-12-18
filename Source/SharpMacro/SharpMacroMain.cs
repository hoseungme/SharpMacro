using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;



namespace SharpMacro
{
    public partial class SharpMacroMain : Form
    {
        [DllImport("user32.dll")]
        private static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern int UnregisterHotKey(int hwnd, int id);
        [DllImport("user32.dll")]
        private static extern int GetCursorPos(out POINT Point);
        [DllImport("user32.dll")]
        private static extern int SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        private static extern uint GetAsyncKeyState(int Key);
        [DllImport("user32.dll")]
        private static extern void mouse_event(int flag, int dx, int dy, int buttons, int extra);
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte vk, byte scan, uint flags, uint extrainfo);

        private struct POINT
        {
            public int x;
            public int y;
        }
        private Thread TabIndexControlThread;
        private int CurrentTabIndex;

        private Thread MouseRecordThread;
        private Thread MouseMacroThread;
        private bool MouseRecordFlag = false;
        private bool MouseMacroFlag = false;
        private bool MouseLeftFlag = false;
        private bool MouseRightFlag = false;
        private List<int> MouseCursorPose = new List<int>();
        
        private Thread KeyboardMacroThread;
        private bool KeyboardRecordFlag = false;
        private bool KeyboardMacroFlag = false;
        private List<int> KeyEvent = new List<int>();
        private Stopwatch KeyWatch = new Stopwatch();

        private void TabIndexControl()
        {
            CurrentTabIndex = SharpMacroTab.SelectedIndex;
            while(true)
            {
                if(CurrentTabIndex != SharpMacroTab.SelectedIndex)
                {
                    SharpMacroTab.SelectedIndex = CurrentTabIndex;
                    MessageBox.Show("녹화중 또는 매크로 실행중일 때는 탭 전환이 불가능합니다.", "오류");
                }
            }
        }

        private void MouseRecord()
        {
            Thread.Sleep(200);
            POINT CurrentCursorPos = new POINT();
            int MouseLeft = 0x01, MouseRight = 0x02;
            
            while (true)
            {
                GetCursorPos(out CurrentCursorPos);
                MouseCursorPose.Add(CurrentCursorPos.x);
                MouseCursorPose.Add(CurrentCursorPos.y);

                MouseRecordPrintBox.AppendText("x : " + CurrentCursorPos.x.ToString() + " y : " + CurrentCursorPos.y.ToString() + "\r\n");
                
                if ((GetAsyncKeyState(MouseLeft) & 0x8000) == 0x8000)
                {
                    MouseCursorPose. Add(1);
                    MouseLeftFlag = true;
                    MouseRecordPrintBox.AppendText("LeftButton Down\r\n");
                }
                else if ((GetAsyncKeyState(MouseRight) & 0x8000) == 0x8000)
                {
                    MouseCursorPose.Add(3);
                    MouseRightFlag = true;
                    MouseRecordPrintBox.AppendText("RightButton Down\r\n");
                }
                else
                {
                    if(MouseLeftFlag)
                    {
                        MouseCursorPose.Add(2);
                        MouseRecordPrintBox.AppendText("LeftButton Up\r\n");
                        MouseLeftFlag = false;
                    }
                    else if(MouseRightFlag)
                    {
                        MouseCursorPose.Add(4);
                        MouseRecordPrintBox.AppendText("RightButton Up\r\n");
                        MouseRightFlag = false;
                    }
                    else
                    {
                        MouseCursorPose.Add(0);
                    }
                }
                if (MouseRecordFlag == false)
                {
                    break;
                }
                Thread.Sleep(20);
            }
        }

        private void MouseMacro()
        {
            while(true)
            {
                for (int i = 0; i < MouseCursorPose.Count; i++)
                {
                    SetCursorPos(MouseCursorPose[i], MouseCursorPose[++i]);
                    switch(MouseCursorPose[++i])
                    {
                        case 1:
                            mouse_event(2, MouseCursorPose[i - 2], MouseCursorPose[i - 1], 0, 0);
                            break;
                        case 2:
                            mouse_event(4, MouseCursorPose[i - 2], MouseCursorPose[i - 1], 0, 0);
                            break;
                        case 3:
                            mouse_event(8, MouseCursorPose[i - 2], MouseCursorPose[i - 1], 0, 0);
                            break;
                        case 4:
                            mouse_event(16, MouseCursorPose[i - 2], MouseCursorPose[i - 1], 0, 0);
                            break;
                    }
                    Thread.Sleep(20);
                }
            }
        }

        private void KeyboardMacro()
        {
            while (true)
            {
                for (int i = 0; i < KeyEvent.Count; i++)
                {
                    if(KeyEvent[i] == 0)
                    {
                        Thread.Sleep(KeyEvent[++i]);
                        keybd_event((byte)KeyEvent[++i], 0, (uint)KeyEvent[i - 2], 0);
                    }
                    else
                    {
                        keybd_event((byte)KeyEvent[++i], 0, (uint)KeyEvent[i - 1], 0);
                    }
                }
            }
        }

        public SharpMacroMain()
        {
            InitializeComponent();
        }

        private void SharpMacroMain_Load(object sender, EventArgs e)
        {
            RegisterHotKey((int)this.Handle, 0, 0x0, (int)Keys.F8);
            RegisterHotKey((int)this.Handle, 1, 0x0, (int)Keys.F9);
            RegisterHotKey((int)this.Handle, 2, 0x0, (int)Keys.F10);
            RegisterHotKey((int)this.Handle, 3, 0x0, (int)Keys.F11);
        }

        private void SharpMacroMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnregisterHotKey((int)this.Handle, 0);
            UnregisterHotKey((int)this.Handle, 1);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x312)
            {
                if(m.WParam == (IntPtr)0x0)
                {
                    if(SharpMacroTab.SelectedIndex == 0)
                    {
                        if (MouseMacroFlag)
                        {
                            MessageBox.Show("매크로 실행 중에는 녹화 관련 기능을 사용할 수 없습니다.", "오류");
                        }
                        else
                        {
                            if (MouseRecordFlag)
                            {
                                MessageBox.Show("녹화가 이미 시작되었습니다.", "오류");
                            }
                            else
                            {
                                MouseCursorPose.Clear();
                                MouseRecordPrintBox.Clear();
                                TabIndexControlThread = new Thread(TabIndexControl)
                                {
                                    IsBackground = true
                                };
                                MouseRecordThread = new Thread(MouseRecord)
                                {
                                    IsBackground = true
                                };
                                TabIndexControlThread.Start();
                                MouseRecordThread.Start();
                                MouseRecordFlag = true;
                            }
                        }
                    }
                }

                if(m.WParam == (IntPtr)0x1)
                {
                    if(SharpMacroTab.SelectedIndex == 0)
                    {
                        if (MouseMacroFlag)
                        {
                            MessageBox.Show("매크로 실행 중에는 녹화 관련 기능을 사용할 수 없습니다.", "오류");
                        }
                        else
                        {
                            if (MouseRecordFlag)
                            {
                                TabIndexControlThread.Abort();
                                MouseRecordFlag = false;
                                MouseRecordThread.Join();
                            }
                            else
                            {
                                MessageBox.Show("녹화가 시작되지 않아 정지할 수 없습니다.", "오류");
                            }
                        }
                    }
                }

                if (m.WParam == (IntPtr)0x2)
                {
                    if(SharpMacroTab.SelectedIndex == 0)
                    {
                        if(MouseRecordFlag)
                        {
                            MessageBox.Show("녹화 중에는 매크로 관련 기능을 사용할 수 없습니다.", "오류");
                        }
                        else
                        {
                            if(MouseMacroFlag)
                            {
                                MessageBox.Show("매크로가 이미 시작되었습니다.", "오류");
                            }
                            else
                            {
                                TabIndexControlThread = new Thread(TabIndexControl)
                                {
                                    IsBackground = true
                                };
                                MouseMacroThread = new Thread(MouseMacro)
                                {
                                    IsBackground = true
                                };
                                TabIndexControlThread.Start();
                                MouseMacroThread.Start();
                                MouseMacroFlag = true;
                            }
                        }
                    }
                    else if (SharpMacroTab.SelectedIndex == 1)
                    {
                        if(KeyboardRecordFlag)
                        {
                            MessageBox.Show("녹화 중에는 매크로 관련 기능을 사용할 수 없습니다.", "오류");
                        }
                        else
                        {
                            if (KeyboardMacroFlag)
                            {
                                MessageBox.Show("매크로가 이미 시작되었습니다.", "오류");
                            }
                            else
                            {
                                TabIndexControlThread = new Thread(TabIndexControl)
                                {
                                    IsBackground = true
                                };
                                KeyboardMacroThread = new Thread(KeyboardMacro)
                                {
                                    IsBackground = true
                                };
                                TabIndexControlThread.Start();
                                KeyboardMacroThread.Start();
                                KeyboardMacroFlag = true;
                            }
                        }
                    }
                }

                if (m.WParam == (IntPtr)0x3)
                {
                    if (SharpMacroTab.SelectedIndex == 0)
                    {
                        if (MouseRecordFlag)
                        {
                            MessageBox.Show("녹화 중에는 매크로 관련 기능을 사용할 수 없습니다.", "오류");
                        }
                        else
                        {
                            if (MouseMacroFlag)
                            {
                                TabIndexControlThread.Abort();
                                MouseMacroThread.Abort();
                                MouseMacroFlag = false;
                            }
                            else
                            {
                                MessageBox.Show("매크로가 시작되지 않아 정지할 수 없습니다.", "오류");
                            }
                        }
                    }
                    else if (SharpMacroTab.SelectedIndex == 1)
                    {
                        if(KeyboardRecordFlag)
                        {
                            MessageBox.Show("녹화 중에는 매크로 관련 기능을 사용할 수 없습니다.", "오류");
                        }
                        else
                        {
                            if (KeyboardMacroFlag)
                            {
                                TabIndexControlThread.Abort();
                                KeyboardMacroThread.Abort();
                                KeyboardMacroFlag = false;
                            }
                            else
                            {
                                MessageBox.Show("매크로가 시작되지 않아 정지할 수 없습니다.", "오류");
                            }
                        }
                    }
                }
            }
        }

        private void KeyboardRecordStartButton_Click(object sender, EventArgs e)
        {
            if(KeyboardMacroFlag)
            {
                MessageBox.Show("매크로 실행 중에는 녹화 관련 기능을 사용할 수 없습니다.", "오류");
            }
            else
            {
                if (KeyboardRecordFlag)
                {
                    MessageBox.Show("녹화가 이미 시작되었습니다.", "오류");
                }
                else
                {
                    TabIndexControlThread = new Thread(TabIndexControl)
                    {
                        IsBackground = true
                    };
                    KeyEvent.Clear();
                    PressedKeyPrintBox.Clear();
                    TabIndexControlThread.Start();
                    KeyWatch.Reset();
                    KeyWatch.Start();
                    KeyboardRecordFlag = true;
                }
            }
        }

        private void KeyboardRecordStopButton_Click(object sender, EventArgs e)
        {
            if (KeyboardMacroFlag)
            {
                MessageBox.Show("매크로 실행 중에는 녹화 관련 기능을 사용할 수 없습니다.", "오류");
            }
            else
            {
                if (KeyboardRecordFlag)
                {
                    KeyWatch.Stop();
                    TabIndexControlThread.Abort();
                    KeyboardRecordFlag = false;
                }
                else
                {
                    MessageBox.Show("녹화가 시작되지 않아 정지할 수 없습니다.", "오류");
                }
            }
        }

        private void KeyBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(KeyboardRecordFlag)
            {
                KeyWatch.Stop();
                KeyEvent.Add(0);
                KeyEvent.Add((int)KeyWatch.ElapsedMilliseconds);
                KeyEvent.Add(e.KeyValue);
                KeyWatch.Restart();
                PressedKeyPrintBox.AppendText(e.KeyCode.ToString() + "\r\n");
            }
            else
            {
                MessageBox.Show("먼저 녹화 시작을 눌러야 합니다.", "오류");
            }
        }

        private void KeyBox_KeyUp(object sender, KeyEventArgs e)
        {
            KeyEvent.Add(2);
            KeyEvent.Add(e.KeyValue);
        }
    }
}