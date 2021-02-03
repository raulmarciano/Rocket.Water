using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace LembreteBeberAgua
{
    public partial class frmConfiguracoes : Form
    {
        private bool manterAplicacaoAberta = true;
        private readonly string caminho = @"C:\Program Files (x86)\Lembrete Beber Agua\LembreteAgua.exe";
        private readonly string subKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

        public frmConfiguracoes()
        {
            InitializeComponent();
        }
        private void chkIniciarComWindows_CheckedChanged(object sender, EventArgs e)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(subKey, true))
            {
                if (chkIniciarComWindows.Checked)
                    key.SetValue(caminho, $"\"{Application.ExecutablePath}\"");
                else
                    key.DeleteValue(caminho, false);
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            manterAplicacaoAberta = false;
            this.Close();
        }

        private void AbrirConfiguracoes_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = manterAplicacaoAberta;
            base.OnFormClosing(e);
        }

        private void tmrNotificacaoAgua_Tick(object sender, EventArgs e)
        {
            icnBandeja.ShowBalloonTip(8, "Lembrete Para Beber Água", "Está na hora de beber água!", ToolTipIcon.Info);
        }

    }
}
