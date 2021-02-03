using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace LembreteBeberAgua
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process processoAtual = Process.GetCurrentProcess();

            if (Process.GetProcessesByName(processoAtual.ProcessName).Any(p => p.Id != processoAtual.Id && !p.HasExited))
            {
                MessageBox.Show("O aplicativo já está em execução!", "Já está em execução");
                Process.GetCurrentProcess().Kill();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConfiguracoes());
        }
    }
}
