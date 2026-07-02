using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UV7_Logon_Options
{
    public partial class Form_main : Form
    {
        string shutdown = Application.StartupPath;
        ProcessStartInfo sdProc = new ProcessStartInfo();
        public Form_main()
        {
            InitializeComponent();
            if (IntPtr.Size == 8)
            {
                sdProc.FileName = Path.Combine(shutdown, "psshutdown.exe");
            }
            else
            {
                sdProc.FileName = Path.Combine(shutdown, "psshutdown64.exe");
            }

            sdProc.UseShellExecute = false;
            sdProc.CreateNoWindow = true;
            sdProc.Arguments = "/t 0 /accepteula ";
        }

        private void Sleep(object sender, EventArgs e)
        {
            sdProc.Arguments += "/d";
            Process.Start(sdProc);
        }

        private void Hibernate(object sender, EventArgs e)
        {
            sdProc.Arguments += "/h";
            Process.Start(sdProc);
        }

        private void Shutdown(object sender, EventArgs e)
        {
            sdProc.Arguments += "/s";
            Process.Start(sdProc);
        }

        private void Restart(object sender, EventArgs e)
        {
            sdProc.Arguments += "/r";
            Process.Start(sdProc);
        }

        private void EaseOfAccess(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Environment.SystemDirectory, "utilman.exe"));
        }

        private void Form_main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form_main_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_main_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
