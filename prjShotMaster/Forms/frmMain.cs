﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjShotMaster.Actions;

namespace prjShotMaster
{
    public partial class frmMain : Form
    {
        public CActionManager actionManager = new CActionManager();
        private bool b_minimize_on_close = true;

        public frmMain()
        {
            InitializeComponent();
            fillSettingsControls();
            // hook (старт перехвата клавы)
            CInterceptKeys.Hook();
            CInterceptKeys.KeyUp += InterceptKeys_KeyUp;
            // TEST MODE
            pnlDestinationFolderDefault.Enabled = false;
            // /TEST MODE
            // Start
            actionManager.Start();
            // on start
            actionManager.Shot();
            Visible = false;
        }

        private void InterceptKeys_KeyUp(Keys Key)
        {
            // глобальный перехват клавы
            List<Keys> PressedKeys = CInterceptKeys.KeysDown;
            // Ctrl + L + K - в настройках хранить
            if (
                (
                    PressedKeys.Contains(Keys.Control)
                    || PressedKeys.Contains(Keys.LControlKey)
                    || PressedKeys.Contains(Keys.RControlKey)
                )
                && PressedKeys.Contains(Keys.L)
                && PressedKeys.Contains(Keys.K)
            )
            {
                actionManager.Shot();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (b_minimize_on_close)
            {
                e.Cancel = true;
                Visible = false;
            }
            else
            {
                // on exit
                actionManager.Shot();
                // Stop
                actionManager.Stop();
                // UnHook
                CInterceptKeys.UnHook();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b_minimize_on_close = false;
            Close();
        }

        private void ntfIcn_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Show();
        }

        private void btnApplyDefault_Click(object sender, EventArgs e)
        {
            applySettingsDefault();
        }

        private void applySettingsDefault()
        {
            Properties.Settings.Default.PlaySound = cbPlaySoundDefault.Checked;
            Properties.Settings.Default.TimerInterval = Convert.ToInt32(tbTimerIntervalDefault.Text);
            Properties.Settings.Default.DestinationFolder = tbDestinationFolderDefault.Text;
            Properties.Settings.Default.Save();

            fillSettingsControls();
        }

        private void fillSettingsControls()
        {
            // lbDeviceIndex
            foreach (System.Collections.DictionaryEntry actionEntry in actionManager.actionList)
            {
                CShotAction action = (actionEntry.Value as CShotAction);
                Control lbDeviceIndex = findControlByName("lbDeviceIndex" + action.action_code);
                (lbDeviceIndex as ListBox).Items.Clear();
                foreach (string str in action.DeviceList)
                {
                    (lbDeviceIndex as ListBox).Items.Add(str);
                }
            }
            // show current settings values
            fillSettingsControlsState();
        }

        private void fillSettingsControlsState()
        {
            tbDestinationFolderDefault.Text = Properties.Settings.Default.DestinationFolder;
            tbTimerIntervalDefault.Text = Properties.Settings.Default.TimerInterval.ToString();
            cbPlaySoundDefault.Checked = Properties.Settings.Default.PlaySound;
        }

        private Control findControlByName(string name)
        {
            foreach (Control control in this.Controls.Find(name, true))
            {
                if (control.Name == name)
                {
                    return control;
                }
            }
            return null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b_minimize_on_close = false;
            Close();
        }
    }
}
