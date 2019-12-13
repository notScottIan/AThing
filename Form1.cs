using System;
using System.Drawing;
using System.Windows.Forms;

namespace AThing
{
    public partial class Form1 : Form
    {
        private Engine scheduler;

        public Form1() {

            InitializeComponent();
            scheduler = new Engine();

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e) {

            DisplayMainForm();

        }

        private void notifyIcon1_Click(object sender, EventArgs e) {

            DisplayMainForm();

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e) {
            
            DisplayMainForm();

        }

        private void timer1_Tick(object sender, EventArgs e) {

            for (int i = 0; i < scheduler.Settings.Count; i++) {

                int countChange = scheduler.Settings[i].UpdateCount();
                if (countChange != 0) {
                    string message = "[" + DateTime.Now.ToString("HH:mm:ss") + "]";
                    message += " Directory " + scheduler.Settings[i].MonitoredDirectory;
                    message += " file count changed (" + countChange.ToString("+#;-#;0") + ") for files of type ";
                    message += scheduler.Settings[i].MonitoredFileType;
                    DisplayBallonTip(message, "AThing");
                    txtEvents.AppendText(message + Environment.NewLine);
                }

            }
        }

        private void DisplayBallonTip(string theText, string theTitle) {
            
            notifyIcon1.BalloonTipText = theText;
            notifyIcon1.BalloonTipTitle = theTitle;            
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(50000);            

        }

        private void DisplayMainForm() {

            WindowState = FormWindowState.Normal;
            Activate();
            notifyIcon1.Visible = false;

        }

        private void btnClear_Click(object sender, EventArgs e) {

            txtEvents.Text = null;

        }

        private void btnConfig_Click(object sender, EventArgs e) {

            foreach (Entry p in scheduler.Settings) {
                txtEvents.AppendText(GetTime() + " " + p.MonitoredFileType + "\t" + p.MonitoredDirectory + Environment.NewLine);
            }            

        }

        private void btnControl_Click(object sender, EventArgs e) {

            txtEvents.AppendText(GetTime());
            if (btnControl.Text == "Stop") {
                timer1.Enabled = false;
                btnControl.Text = "Start";
                txtEvents.AppendText(" Stopping");
            }
            else {
                timer1.Enabled = true;
                btnControl.Text = "Stop";
                txtEvents.AppendText(" Starting");
            }
            
            txtEvents.AppendText(Environment.NewLine);
        }

        private string GetTime() {

            return "[" + DateTime.Now.ToString("HH:mm:ss") + "]";

        }
    }
}