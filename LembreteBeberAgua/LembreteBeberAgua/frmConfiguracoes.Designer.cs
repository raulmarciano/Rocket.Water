
namespace LembreteBeberAgua
{
    partial class FrmConfiguracoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracoes));
            this.icnBandeja = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbxTempoNotificacao = new System.Windows.Forms.ComboBox();
            this.lblTempoNotificacao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIniciarComWindows = new System.Windows.Forms.CheckBox();
            this.tmrNotificacaoAgua = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // icnBandeja
            // 
            this.icnBandeja.Icon = ((System.Drawing.Icon)(resources.GetObject("icnBandeja.Icon")));
            this.icnBandeja.Text = "Lembrete para beber água";
            this.icnBandeja.Visible = true;
            this.icnBandeja.DoubleClick += new System.EventHandler(this.AbrirConfiguracoes_Click);
            // 
            // cbxTempoNotificacao
            // 
            this.cbxTempoNotificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTempoNotificacao.FormattingEnabled = true;
            this.cbxTempoNotificacao.Location = new System.Drawing.Point(158, 28);
            this.cbxTempoNotificacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxTempoNotificacao.Name = "cbxTempoNotificacao";
            this.cbxTempoNotificacao.Size = new System.Drawing.Size(158, 23);
            this.cbxTempoNotificacao.TabIndex = 0;
            this.cbxTempoNotificacao.SelectedIndexChanged += new System.EventHandler(this.CbxTempoNotificacao_SelectedIndexChanged);
            // 
            // lblTempoNotificacao
            // 
            this.lblTempoNotificacao.AutoSize = true;
            this.lblTempoNotificacao.Location = new System.Drawing.Point(7, 31);
            this.lblTempoNotificacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempoNotificacao.Name = "lblTempoNotificacao";
            this.lblTempoNotificacao.Size = new System.Drawing.Size(139, 15);
            this.lblTempoNotificacao.TabIndex = 1;
            this.lblTempoNotificacao.Text = "Minutos para notificação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIniciarComWindows);
            this.groupBox1.Controls.Add(this.cbxTempoNotificacao);
            this.groupBox1.Controls.Add(this.lblTempoNotificacao);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(337, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // chkIniciarComWindows
            // 
            this.chkIniciarComWindows.AutoSize = true;
            this.chkIniciarComWindows.Location = new System.Drawing.Point(158, 59);
            this.chkIniciarComWindows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkIniciarComWindows.Name = "chkIniciarComWindows";
            this.chkIniciarComWindows.Size = new System.Drawing.Size(147, 19);
            this.chkIniciarComWindows.TabIndex = 2;
            this.chkIniciarComWindows.Text = "Iniciar com o Windows";
            this.chkIniciarComWindows.UseVisualStyleBackColor = true;
            this.chkIniciarComWindows.CheckedChanged += new System.EventHandler(this.ChkIniciarComWindows_CheckedChanged);
            // 
            // tmrNotificacaoAgua
            // 
            this.tmrNotificacaoAgua.Tick += new System.EventHandler(this.TmrNotificacaoAgua_Tick);
            // 
            // FrmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 132);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracoes";
            this.Text = "Rocket Water";
            this.Load += new System.EventHandler(this.FrmConfiguracoes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon icnBandeja;
        private System.Windows.Forms.ComboBox cbxTempoNotificacao;
        private System.Windows.Forms.Label lblTempoNotificacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIniciarComWindows;
        private System.Windows.Forms.Timer tmrNotificacaoAgua;
    }
}

