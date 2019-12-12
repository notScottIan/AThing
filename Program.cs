// AThing

// Bld  Ver    Date      Notes
//             17/11/19  Started

using System;
using System.Windows.Forms;

namespace AThing
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
