namespace SharpMacro
{
    partial class SharpMacroMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharpMacroMain));
            this.SharpMacroTab = new System.Windows.Forms.TabControl();
            this.MouseTab = new System.Windows.Forms.TabPage();
            this.MouseMacroStopButton = new System.Windows.Forms.Button();
            this.MouseMacroStartButton = new System.Windows.Forms.Button();
            this.MouseRecordStopButton = new System.Windows.Forms.Button();
            this.MouseRecordStartButton = new System.Windows.Forms.Button();
            this.MouseRecordPrintBox = new System.Windows.Forms.TextBox();
            this.KeyboardTab = new System.Windows.Forms.TabPage();
            this.KeyboardMacroStopButton = new System.Windows.Forms.Button();
            this.KeyboardMacroStartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PressedKeyPrintBox = new System.Windows.Forms.TextBox();
            this.KeyboardRecordStopButton = new System.Windows.Forms.Button();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.KeyboardRecordStartButton = new System.Windows.Forms.Button();
            this.HelpTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyboardHelp = new System.Windows.Forms.TextBox();
            this.MouseHelp = new System.Windows.Forms.TextBox();
            this.SharpMacroTab.SuspendLayout();
            this.MouseTab.SuspendLayout();
            this.KeyboardTab.SuspendLayout();
            this.HelpTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SharpMacroTab
            // 
            this.SharpMacroTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SharpMacroTab.Controls.Add(this.MouseTab);
            this.SharpMacroTab.Controls.Add(this.KeyboardTab);
            this.SharpMacroTab.Controls.Add(this.HelpTab);
            this.SharpMacroTab.Location = new System.Drawing.Point(13, 13);
            this.SharpMacroTab.Name = "SharpMacroTab";
            this.SharpMacroTab.SelectedIndex = 0;
            this.SharpMacroTab.Size = new System.Drawing.Size(457, 428);
            this.SharpMacroTab.TabIndex = 1;
            // 
            // MouseTab
            // 
            this.MouseTab.BackColor = System.Drawing.Color.Silver;
            this.MouseTab.Controls.Add(this.MouseMacroStopButton);
            this.MouseTab.Controls.Add(this.MouseMacroStartButton);
            this.MouseTab.Controls.Add(this.MouseRecordStopButton);
            this.MouseTab.Controls.Add(this.MouseRecordStartButton);
            this.MouseTab.Controls.Add(this.MouseRecordPrintBox);
            this.MouseTab.Location = new System.Drawing.Point(4, 25);
            this.MouseTab.Name = "MouseTab";
            this.MouseTab.Padding = new System.Windows.Forms.Padding(3);
            this.MouseTab.Size = new System.Drawing.Size(449, 399);
            this.MouseTab.TabIndex = 0;
            this.MouseTab.Text = "마우스";
            // 
            // MouseMacroStopButton
            // 
            this.MouseMacroStopButton.Location = new System.Drawing.Point(210, 301);
            this.MouseMacroStopButton.Name = "MouseMacroStopButton";
            this.MouseMacroStopButton.Size = new System.Drawing.Size(233, 92);
            this.MouseMacroStopButton.TabIndex = 4;
            this.MouseMacroStopButton.Text = "매크로 정지 (F11)";
            this.MouseMacroStopButton.UseVisualStyleBackColor = true;
            // 
            // MouseMacroStartButton
            // 
            this.MouseMacroStartButton.Location = new System.Drawing.Point(211, 203);
            this.MouseMacroStartButton.Name = "MouseMacroStartButton";
            this.MouseMacroStartButton.Size = new System.Drawing.Size(233, 92);
            this.MouseMacroStartButton.TabIndex = 3;
            this.MouseMacroStartButton.Text = "매크로 시작 (F10)";
            this.MouseMacroStartButton.UseVisualStyleBackColor = true;
            // 
            // MouseRecordStopButton
            // 
            this.MouseRecordStopButton.Location = new System.Drawing.Point(210, 104);
            this.MouseRecordStopButton.Name = "MouseRecordStopButton";
            this.MouseRecordStopButton.Size = new System.Drawing.Size(233, 92);
            this.MouseRecordStopButton.TabIndex = 2;
            this.MouseRecordStopButton.Text = "녹화 정지 (F9)";
            this.MouseRecordStopButton.UseVisualStyleBackColor = true;
            // 
            // MouseRecordStartButton
            // 
            this.MouseRecordStartButton.Location = new System.Drawing.Point(210, 6);
            this.MouseRecordStartButton.Name = "MouseRecordStartButton";
            this.MouseRecordStartButton.Size = new System.Drawing.Size(233, 92);
            this.MouseRecordStartButton.TabIndex = 1;
            this.MouseRecordStartButton.Text = "녹화 시작 (F8)";
            this.MouseRecordStartButton.UseVisualStyleBackColor = true;
            // 
            // MouseRecordPrintBox
            // 
            this.MouseRecordPrintBox.Location = new System.Drawing.Point(6, 6);
            this.MouseRecordPrintBox.Multiline = true;
            this.MouseRecordPrintBox.Name = "MouseRecordPrintBox";
            this.MouseRecordPrintBox.ReadOnly = true;
            this.MouseRecordPrintBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MouseRecordPrintBox.Size = new System.Drawing.Size(198, 387);
            this.MouseRecordPrintBox.TabIndex = 0;
            // 
            // KeyboardTab
            // 
            this.KeyboardTab.BackColor = System.Drawing.Color.Silver;
            this.KeyboardTab.Controls.Add(this.KeyboardMacroStopButton);
            this.KeyboardTab.Controls.Add(this.KeyboardMacroStartButton);
            this.KeyboardTab.Controls.Add(this.label1);
            this.KeyboardTab.Controls.Add(this.PressedKeyPrintBox);
            this.KeyboardTab.Controls.Add(this.KeyboardRecordStopButton);
            this.KeyboardTab.Controls.Add(this.KeyBox);
            this.KeyboardTab.Controls.Add(this.KeyboardRecordStartButton);
            this.KeyboardTab.Location = new System.Drawing.Point(4, 25);
            this.KeyboardTab.Name = "KeyboardTab";
            this.KeyboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.KeyboardTab.Size = new System.Drawing.Size(449, 399);
            this.KeyboardTab.TabIndex = 1;
            this.KeyboardTab.Text = "키보드";
            // 
            // KeyboardMacroStopButton
            // 
            this.KeyboardMacroStopButton.Location = new System.Drawing.Point(210, 300);
            this.KeyboardMacroStopButton.Name = "KeyboardMacroStopButton";
            this.KeyboardMacroStopButton.Size = new System.Drawing.Size(233, 92);
            this.KeyboardMacroStopButton.TabIndex = 6;
            this.KeyboardMacroStopButton.Text = "매크로 정지 (F11)";
            this.KeyboardMacroStopButton.UseVisualStyleBackColor = true;
            // 
            // KeyboardMacroStartButton
            // 
            this.KeyboardMacroStartButton.Location = new System.Drawing.Point(210, 202);
            this.KeyboardMacroStartButton.Name = "KeyboardMacroStartButton";
            this.KeyboardMacroStartButton.Size = new System.Drawing.Size(233, 92);
            this.KeyboardMacroStartButton.TabIndex = 5;
            this.KeyboardMacroStartButton.Text = "매크로 시작 (F10)";
            this.KeyboardMacroStartButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 4;
            // 
            // PressedKeyPrintBox
            // 
            this.PressedKeyPrintBox.Location = new System.Drawing.Point(7, 76);
            this.PressedKeyPrintBox.Multiline = true;
            this.PressedKeyPrintBox.Name = "PressedKeyPrintBox";
            this.PressedKeyPrintBox.ReadOnly = true;
            this.PressedKeyPrintBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PressedKeyPrintBox.Size = new System.Drawing.Size(194, 316);
            this.PressedKeyPrintBox.TabIndex = 3;
            // 
            // KeyboardRecordStopButton
            // 
            this.KeyboardRecordStopButton.Location = new System.Drawing.Point(210, 104);
            this.KeyboardRecordStopButton.Name = "KeyboardRecordStopButton";
            this.KeyboardRecordStopButton.Size = new System.Drawing.Size(233, 92);
            this.KeyboardRecordStopButton.TabIndex = 2;
            this.KeyboardRecordStopButton.Text = "녹화 정지";
            this.KeyboardRecordStopButton.UseVisualStyleBackColor = true;
            this.KeyboardRecordStopButton.Click += new System.EventHandler(this.KeyboardRecordStopButton_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(7, 7);
            this.KeyBox.Multiline = true;
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.ReadOnly = true;
            this.KeyBox.Size = new System.Drawing.Size(194, 63);
            this.KeyBox.TabIndex = 1;
            this.KeyBox.Text = "녹화 시작을 누른 후 이곳을 클릭하고 키를 누르세요";
            this.KeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyBox_KeyDown);
            this.KeyBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyBox_KeyUp);
            // 
            // KeyboardRecordStartButton
            // 
            this.KeyboardRecordStartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KeyboardRecordStartButton.Location = new System.Drawing.Point(210, 6);
            this.KeyboardRecordStartButton.Name = "KeyboardRecordStartButton";
            this.KeyboardRecordStartButton.Size = new System.Drawing.Size(233, 92);
            this.KeyboardRecordStartButton.TabIndex = 0;
            this.KeyboardRecordStartButton.Text = "녹화 시작";
            this.KeyboardRecordStartButton.UseVisualStyleBackColor = true;
            this.KeyboardRecordStartButton.Click += new System.EventHandler(this.KeyboardRecordStartButton_Click);
            // 
            // HelpTab
            // 
            this.HelpTab.BackColor = System.Drawing.Color.Silver;
            this.HelpTab.Controls.Add(this.label3);
            this.HelpTab.Controls.Add(this.label2);
            this.HelpTab.Controls.Add(this.KeyboardHelp);
            this.HelpTab.Controls.Add(this.MouseHelp);
            this.HelpTab.Location = new System.Drawing.Point(4, 25);
            this.HelpTab.Name = "HelpTab";
            this.HelpTab.Padding = new System.Windows.Forms.Padding(3);
            this.HelpTab.Size = new System.Drawing.Size(449, 399);
            this.HelpTab.TabIndex = 2;
            this.HelpTab.Text = "도움말";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "키보드 매크로 도움말";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "마우스 매크로 도움말";
            // 
            // KeyboardHelp
            // 
            this.KeyboardHelp.Font = new System.Drawing.Font("굴림", 10F);
            this.KeyboardHelp.Location = new System.Drawing.Point(228, 29);
            this.KeyboardHelp.Multiline = true;
            this.KeyboardHelp.Name = "KeyboardHelp";
            this.KeyboardHelp.ReadOnly = true;
            this.KeyboardHelp.Size = new System.Drawing.Size(215, 364);
            this.KeyboardHelp.TabIndex = 1;
            this.KeyboardHelp.Text = resources.GetString("KeyboardHelp.Text");
            // 
            // MouseHelp
            // 
            this.MouseHelp.Font = new System.Drawing.Font("굴림", 10F);
            this.MouseHelp.Location = new System.Drawing.Point(6, 29);
            this.MouseHelp.Multiline = true;
            this.MouseHelp.Name = "MouseHelp";
            this.MouseHelp.ReadOnly = true;
            this.MouseHelp.Size = new System.Drawing.Size(215, 364);
            this.MouseHelp.TabIndex = 0;
            this.MouseHelp.Text = "1. 녹화하는 법\r\n 녹화 시작 버튼을 누른 후, 그냥 하고싶은 행동을 하시면 됩니다. 녹화 관련 기능은 버튼을 지원하지 않습니다.\r\n\r\n2. 매" +
    "크로 실행하는 법\r\n 매크로 시작을 누르면 녹화했던 동작을 반복하게 됩니다. 매크로 시작 단축키는 F10, 매크로 정지 단축키는 F11입니다. " +
    "녹화 관련 기능은 버튼을 지원하지 않습니다.";
            // 
            // SharpMacroMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.SharpMacroTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "SharpMacroMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpMacro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SharpMacroMain_FormClosed);
            this.Load += new System.EventHandler(this.SharpMacroMain_Load);
            this.SharpMacroTab.ResumeLayout(false);
            this.MouseTab.ResumeLayout(false);
            this.MouseTab.PerformLayout();
            this.KeyboardTab.ResumeLayout(false);
            this.KeyboardTab.PerformLayout();
            this.HelpTab.ResumeLayout(false);
            this.HelpTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SharpMacroTab;
        private System.Windows.Forms.TabPage MouseTab;
        private System.Windows.Forms.TabPage KeyboardTab;
        private System.Windows.Forms.Button KeyboardRecordStartButton;
        private System.Windows.Forms.Button KeyboardMacroStopButton;
        private System.Windows.Forms.Button KeyboardMacroStartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PressedKeyPrintBox;
        private System.Windows.Forms.Button KeyboardRecordStopButton;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.TabPage HelpTab;
        private System.Windows.Forms.TextBox KeyboardHelp;
        private System.Windows.Forms.TextBox MouseHelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MouseRecordStartButton;
        private System.Windows.Forms.TextBox MouseRecordPrintBox;
        private System.Windows.Forms.Button MouseMacroStopButton;
        private System.Windows.Forms.Button MouseMacroStartButton;
        private System.Windows.Forms.Button MouseRecordStopButton;
    }
}

