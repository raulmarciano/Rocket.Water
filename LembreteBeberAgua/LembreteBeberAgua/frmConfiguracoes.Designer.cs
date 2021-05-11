
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
            this.cbxTempoNotificacao.Location = new System.Drawing.Point(135, 24);
            this.cbxTempoNotificacao.Name = "cbxTempoNotificacao";
            this.cbxTempoNotificacao.Size = new System.Drawing.Size(136, 21);
            this.cbxTempoNotificacao.TabIndex = 0;
            this.cbxTempoNotificacao.SelectedIndexChanged += new System.EventHandler(this.CbxTempoNotificacao_SelectedIndexChanged);
            // 
            // lblTempoNotificacao
            // 
            this.lblTempoNotificacao.AutoSize = true;
            this.lblTempoNotificacao.Location = new System.Drawing.Point(6, 27);
            this.lblTempoNotificacao.Name = "lblTempoNotificacao";
            this.lblTempoNotificacao.Size = new System.Drawing.Size(123, 13);
            this.lblTempoNotificacao.TabIndex = 1;
            this.lblTempoNotificacao.Text = "Minutos para notificação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIniciarComWindows);
            this.groupBox1.Controls.Add(this.cbxTempoNotificacao);
            this.groupBox1.Controls.Add(this.lblTempoNotificacao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // chkIniciarComWindows
            // 
            this.chkIniciarComWindows.AutoSize = true;
            this.chkIniciarComWindows.Location = new System.Drawing.Point(135, 51);
            this.chkIniciarComWindows.Name = "chkIniciarComWindows";
            this.chkIniciarComWindows.Size = new System.Drawing.Size(133, 17);
            this.chkIniciarComWindows.TabIndex = 2;
            this.chkIniciarComWindows.Text = "Iniciar com o Windows";
            this.chkIniciarComWindows.UseVisualStyleBackColor = true;
            this.chkIniciarComWindows.CheckedChanged += new System.EventHandler(this.ChkIniciarComWindows_CheckedChanged);
            // 
            // tmrNotificacaoAgua
            // 
            this.tmrNotificacaoAgua.Tick += new System.EventHandler(this.TmrNotificacaoAgua_Tick);
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 114);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguracoes";
            this.Text = "Configurações do lembrete para beber água";
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

