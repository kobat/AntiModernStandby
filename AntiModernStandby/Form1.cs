using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace AntiModernStandby
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Timer timer;
        private StreamWriter writer;
        
        private void log(Object o)
        {
            System.Diagnostics.Debug.WriteLine(o);
            writer.WriteLine(o);
            writer.Flush();
        }

        // SetThreadExecutionState
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern uint SetThreadExecutionState(uint esFlags);
        private const uint ES_AWAYMODE_REQUIRED = 0x00000040;
        private const uint ES_CONTINUOUS = 0x80000000;
        private const uint ES_DISPLAY_REQUIRED = 0x00000002;
        private const uint ES_SYSTEM_REQUIRED = 0x00000001;
        private const uint ES_USER_PRESENT = 0x00000004;

        // SC_MONITORPOWER
        // -1 (the display is powering on)
        //  1 (the display is going to low power)
        //  2 (the display is being shut off)
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SendMessage(int hWnd, uint Msg, int wParam, int lParam);
        private const uint WM_SYSCOMMAND = 0x0112;
        private const int SC_MONITORPOWER = 0xF170;

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 30 * 1000;
            timer.Tick += new EventHandler((ss, ee) => {
                var dt = DateTime.Now;
                //System.Diagnostics.Debug.WriteLine(dt);
                //writer.WriteLine(dt);
                log(dt);
            });

            writer = new StreamWriter(Application.StartupPath + "\\AntiModernStandby.log");
            log("-- START");
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            log("-- CLOSE");
            writer.Close();
        }
        
        private void radioButtonNone_CheckedChanged(object sender, EventArgs e)
        {
            uint result = SetThreadExecutionState(ES_CONTINUOUS);
            timer.Enabled = false;

            log("-- NONE");
        }

        private void radioButtonSystemRequired_CheckedChanged(object sender, EventArgs e)
        {
            log("-- ES_SYSTEM_REQUIRED");

            uint result = SetThreadExecutionState(ES_SYSTEM_REQUIRED | ES_CONTINUOUS);
            timer.Enabled = true;
        }

        private void radioButtonDisplayRequired_CheckedChanged(object sender, EventArgs e)
        {
            log("-- ES_DISPLAY_REQUIRED");

            uint result = SetThreadExecutionState(ES_DISPLAY_REQUIRED | ES_CONTINUOUS);
            timer.Enabled = true;
        }

        //private void buttonMonitorPowerOff_Click(object sender, EventArgs e)
        //{
        //    Thread.Sleep(1000); // Wait a little after clicking this button.
        //    SendMessage(-1, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        //}
    }
}
