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
    }
}
