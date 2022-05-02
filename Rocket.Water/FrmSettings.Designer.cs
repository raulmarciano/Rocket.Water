
namespace Rocket.Water
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.systemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbxNotificationTime = new System.Windows.Forms.ComboBox();
            this.lblNotificationTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStartWithWindows = new System.Windows.Forms.CheckBox();
            this.tmrNotificationTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // icnBandeja
            // 
            this.systemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("icnBandeja.Icon")));
            this.systemTray.Text = "Lembrete para beber água";
            this.systemTray.Visible = true;
            this.systemTray.DoubleClick += new System.EventHandler(this.OpenSettings_Click);
            // 
            // cbxNotificationTime
            // 
            this.cbxNotificationTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNotificationTime.FormattingEnabled = true;
            this.cbxNotificationTime.Location = new System.Drawing.Point(188, 28);
            this.cbxNotificationTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxNotificationTime.Name = "cbxNotificationTime";
            this.cbxNotificationTime.Size = new System.Drawing.Size(128, 23);
            this.cbxNotificationTime.TabIndex = 0;
            this.cbxNotificationTime.SelectedIndexChanged += new System.EventHandler(this.CbxTimeNotification_SelectedIndexChanged);
            // 
            // lblNotificationTime
            // 
            this.lblNotificationTime.AutoSize = true;
            this.lblNotificationTime.Location = new System.Drawing.Point(15, 31);
            this.lblNotificationTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificationTime.Name = "lblNotificationTime";
            this.lblNotificationTime.Size = new System.Drawing.Size(163, 15);
            this.lblNotificationTime.TabIndex = 1;
            this.lblNotificationTime.Text = "Interval between notifications";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkStartWithWindows);
            this.groupBox1.Controls.Add(this.cbxNotificationTime);
            this.groupBox1.Controls.Add(this.lblNotificationTime);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(337, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // chkStartWithWindows
            // 
            this.chkStartWithWindows.AutoSize = true;
            this.chkStartWithWindows.Location = new System.Drawing.Point(188, 57);
            this.chkStartWithWindows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkStartWithWindows.Name = "chkStartWithWindows";
            this.chkStartWithWindows.Size = new System.Drawing.Size(128, 19);
            this.chkStartWithWindows.TabIndex = 2;
            this.chkStartWithWindows.Text = "Start with Windows";
            this.chkStartWithWindows.UseVisualStyleBackColor = true;
            this.chkStartWithWindows.CheckedChanged += new System.EventHandler(this.ChkStartWithWindows_CheckedChanged);
            // 
            // tmrNotificacaoAgua
            // 
            this.tmrNotificationTime.Tick += new System.EventHandler(this.TmrNotificationWater_Tick);
            // 
            // FrmSettings
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
            this.Name = "FrmSettings";
            this.Text = "Rocket Water";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon systemTray;
        private System.Windows.Forms.ComboBox cbxNotificationTime;
        private System.Windows.Forms.Label lblNotificationTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkStartWithWindows;
        private System.Windows.Forms.Timer tmrNotificationTime;
    }
}

