using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace LembreteBeberAgua
{
    public partial class FrmConfiguracoes : Form
    {
        private bool manterAplicacaoAberta = true;
        private readonly string caminho = @"C:\Program Files (x86)\Lembrete Beber Agua\LembreteAgua.exe";
        private readonly string subKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

        public FrmConfiguracoes()
        {
            InitializeComponent();
        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            string tempoNotificacao = Properties.Settings.Default.TempoNotificacaoAgua;

            cbxTempoNotificacao.DataSource = new string[] { "5", "10", "15", "30", "45", "60" };
            cbxTempoNotificacao.SelectedItem = tempoNotificacao;

            ToolStripMenuItem[] menus = new ToolStripMenuItem[]
            {
                new ToolStripMenuItem("Configurações", null, AbrirConfiguracoes_Click),
                new ToolStripMenuItem("Fechar", null, Fechar_Click)
            };

            ContextMenuStrip contextMenu = new();

            contextMenu.Items.AddRange(menus);
            icnBandeja.ContextMenuStrip = contextMenu;

            tmrNotificacaoAgua.Interval = Convert.ToInt32(tempoNotificacao) * 60000;
            tmrNotificacaoAgua.Enabled = true;

            using RegistryKey key = Registry.CurrentUser.OpenSubKey(subKey, true);
            chkIniciarComWindows.Checked = key.GetValue(caminho) != null;
        }

        private void ChkIniciarComWindows_CheckedChanged(object sender, EventArgs e)
        {
            using RegistryKey key = Registry.CurrentUser.OpenSubKey(subKey, true);
            if (chkIniciarComWindows.Checked)
                key.SetValue(caminho, $"\"{Application.ExecutablePath}\"");
            else
                key.DeleteValue(caminho, false);
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

        private void TmrNotificacaoAgua_Tick(object sender, EventArgs e)
        {
            icnBandeja.ShowBalloonTip(7000, "Tome água", "Está na hora de beber água!", ToolTipIcon.Info);
        }

        private void CbxTempoNotificacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempoNotificacao = (string)cbxTempoNotificacao.SelectedItem;
            tmrNotificacaoAgua.Interval = Convert.ToInt32(tempoNotificacao) * 60000;
            Properties.Settings.Default.TempoNotificacaoAgua = tempoNotificacao;
            Properties.Settings.Default.Save();
        }
    }
}