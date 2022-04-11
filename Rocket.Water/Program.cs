using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Rocket.Water
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Process process = Process.GetCurrentProcess();

            if (Process.GetProcessesByName(process.ProcessName).Any(p => p.Id != process.Id && !p.HasExited))
            {
                MessageBox.Show("Rock Water is already running!", "Information");
                Process.GetCurrentProcess().Kill();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSettings());
        }
    }
}