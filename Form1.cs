using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AThing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayBallonTip();
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            //notifyIcon1.Dispose();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            DisplayBallonTip();
        }

        private void DisplayBallonTip()
        {
            notifyIcon1.BalloonTipText = "New files were detected";
            notifyIcon1.BalloonTipTitle = "AThing";
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(50000);
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e) {

            Engine scheduler = new Engine();
            scheduler.Settings.Add(new Entry(@"C:\Stuff", "*.txt"));
            scheduler.Settings.Add(new Entry(@"C:\Stuff", "*.doc"));
            scheduler.Settings.Add(new Entry(@"C:\Stuff", "*.bat"));

            for (int i = 0; i < scheduler.Settings.Count; i++) {
                scheduler.Settings[i].FileCount = scheduler.Settings[i].CountFiles();
                string message = "Directory " + scheduler.Settings[i].MonitoredDirectory;
                message += " has " + scheduler.Settings[i].FileCount + " files of type ";
                message += scheduler.Settings[i].MonitoredFileType;
                MessageBox.Show(message);
            }
            
        }
    }
}
;