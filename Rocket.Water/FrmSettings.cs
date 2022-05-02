using Microsoft.Win32;
using System;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace Rocket.Water
{
    public partial class FrmSettings : Form
    {
        private bool keepApplicationOpen = true;
        private readonly string path = @"C:\Program Files (x86)\Rocket Water\Rocket Water.exe";
        private readonly string subKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private readonly int numberConvertToMinutes = 60000;

        public FrmSettings()
        {
            InitializeComponent();
        }

       [SupportedOSPlatform("windows")]
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            string notificationTime = Properties.Settings.Default.NotificationTimeDrinkWater;

            cbxNotificationTime.DataSource = new string[] { "5", "10", "15", "30", "45", "60" };
            cbxNotificationTime.SelectedItem = notificationTime;

            ToolStripMenuItem[] menus = new ToolStripMenuItem[]
            {
                new ToolStripMenuItem("Settings", null, OpenSettings_Click),
                new ToolStripMenuItem("Close", null, CloseSettings_Click)
            };

            ContextMenuStrip contextMenu = new();

            contextMenu.Items.AddRange(menus);
            systemTray.ContextMenuStrip = contextMenu;

            tmrNotificationTime.Interval = Convert.ToInt32(notificationTime) * numberConvertToMinutes;
            tmrNotificationTime.Enabled = true;

            using RegistryKey key = Registry.CurrentUser.OpenSubKey(subKey, true);
            chkStartWithWindows.Checked = key.GetValue(path) != null;
        }

        [SupportedOSPlatform("windows")]
        private void ChkStartWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            using RegistryKey key = Registry.CurrentUser.OpenSubKey(subKey, true);
            if (chkStartWithWindows.Checked)
                key.SetValue(path, $"\"{Application.ExecutablePath}\"");
            else
                key.DeleteValue(path, false);
        }

        private void CloseSettings_Click(object sender, EventArgs e)
        {
            keepApplicationOpen = false;
            this.Close();
        }

        private void OpenSettings_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = keepApplicationOpen;
            base.OnFormClosing(e);
        }

        private void TmrNotificationWater_Tick(object sender, EventArgs e)
        {
            systemTray.ShowBalloonTip(7000, "Drink Water", "It's time to drink water!", ToolTipIcon.Info);
        }

        private void CbxTimeNotification_SelectedIndexChanged(object sender, EventArgs e)
        {
            string notificationTime = (string)cbxNotificationTime.SelectedItem;
            tmrNotificationTime.Interval = Convert.ToInt32(notificationTime) * numberConvertToMinutes;
            Properties.Settings.Default.NotificationTimeDrinkWater = notificationTime;
            Properties.Settings.Default.Save();
        }
    }
}