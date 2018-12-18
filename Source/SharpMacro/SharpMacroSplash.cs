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

namespace SharpMacro
{
    public partial class SharpMacroSplash : Form
    {
        delegate void CloseFormDelegate();

        public SharpMacroSplash()
        {
            InitializeComponent();
        }

        private void SharpMacroSplash_Load(object sender, EventArgs e)
        {
            Thread KeepScreenThread = new Thread(KeepScreen);
            KeepScreenThread.IsBackground = true;
            KeepScreenThread.Start();
        }

        private void CloseForm()
        {
            Close();
        }

        private void KeepScreen()
        {
            Thread.Sleep(2000);
            Invoke(new CloseFormDelegate(CloseForm));
        }
    }
}
