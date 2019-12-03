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
        private Engine scheduler;

        public Form1()
        {
            InitializeComponent();
            scheduler = new Engine();

            //for (int i = 0; i < scheduler.Settings.Count; i++) {
            //    scheduler.Settings[i].FileCount = scheduler.Settings[i].CountFiles();
            //    string message = "Directory " + scheduler.Settings[i].MonitoredDirectory;
            //    message += " has " + scheduler.Settings[i].FileCount + " files of type ";
            //    message += scheduler.Settings[i].MonitoredFileType;
            //    //MessageBox.Show(message);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DisplayBallonTip();
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            //DisplayBallonTip();
            //notifyIcon1.
        }

        private void DisplayBallonTip(string theText, string theTitle) {
            
            notifyIcon1.BalloonTipText = theText;
            notifyIcon1.BalloonTipTitle = theTitle;
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(50000);

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            //notifyIcon1.Visible = !notifyIcon1.Visible;
        }

        private void button2_Click(object sender, EventArgs e) {

            
            
        }

        private void timer1_Tick(object sender, EventArgs e) {

            for (int i = 0; i < scheduler.Settings.Count; i++) {
                //int currentCount = scheduler.Settings[i].FileCount;
                //int newCount = scheduler.Settings[i].CountFiles();
                //scheduler.Settings[i].FileCount = newCount;

                if (scheduler.Settings[i].UpdateCount()) {
                    string message = "Directory " + scheduler.Settings[i].MonitoredDirectory;
                    message += " file count changed for files of type ";
                    message += scheduler.Settings[i].MonitoredFileType;
                    //MessageBox.Show(message);
                    DisplayBallonTip(message, "AThing");
                }
            
            }
        }
    }
}
;