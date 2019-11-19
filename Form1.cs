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
            scheduler.Settings = new Entry(@"C:\", "Doc");
            scheduler.UpdateCount();
            MessageBox.Show("Directory " + scheduler.Settings.MonitoredDirectory + " has " + scheduler.Settings.CurrentCount + " files of type " + scheduler.Settings.MonitoredFileType);
            
        
        }
    }
}
;