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
using System.Reflection;

namespace prjShotMaster
{
    public partial class frmMain : Form
    {
        public CActionManager actionManager;

        private bool b_minimize_on_close = true;
        private bool b_start_on_run = false;
        private bool b_shot_on_exit = true;

        private int _countdown_default = 0;
        public int countdown_default
        {
            get { return _countdown_default; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _countdown_default = value;
                TimeSpan t = TimeSpan.FromSeconds(_countdown_default);
                tsslblCountdown.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
                ntfIcn.Text = String.Format("{0}\n{1} {2}", ntfIcnText, state_text_icon, tsslblCountdown.Text);
            }
        }
        private string ntfIcnText;

        public frmMain()
        {
            InitializeComponent();
            // init
            shotNowToolStripMenuItem.ShortcutKeyDisplayString = Properties.Settings.Default.ShortcutKey;
            shotNowToolStripMenuItem1.ShortcutKeyDisplayString = Properties.Settings.Default.ShortcutKey;
            // ntfIcn
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
            ntfIcn.Text = titleAttribute.Title;
            ntfIcnText = ntfIcn.Text;
            // set settings
            destination_folder = Properties.Settings.Default.DestinationFolder;
            timer_interval = Properties.Settings.Default.TimerInterval;
            play_sound = Properties.Settings.Default.PlaySound;
            // here set actionManager
            do_action_w = Properties.Settings.Default.DoActionW;
            // hook (старт перехвата клавы)
            CInterceptKeys.Hook();
            CInterceptKeys.KeyUp += InterceptKeys_KeyUp;
            // on start
            if (b_start_on_run)
            {
                state = FS_START;
            }
        }

        private void InterceptKeys_KeyUp(Keys Key)
        {
            // глобальный перехват клавы
            List<Keys> PressedKeys = CInterceptKeys.KeysDown;
            // Ctrl + K + J - в настройках хранится
            // string[] arr = (Properties.Settings.Default.ShortcutKey as String).Split('+');
            if (
                (
                    PressedKeys.Contains(Keys.Control)
                    || PressedKeys.Contains(Keys.LControlKey)
                    || PressedKeys.Contains(Keys.RControlKey)
                )
                && PressedKeys.Contains(Keys.K)
                && PressedKeys.Contains(Keys.J)
            )
            {
                Shot();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (b_minimize_on_close)
            {
                e.Cancel = true;
                ShowInTaskbar = false;
                ntfIcn.Visible = true;
                Hide();
            }
            else
            {
                if (b_shot_on_exit && state == FS_START) // on exit
                {
                    Shot();
                }
                CInterceptKeys.UnHook(); // UnHook
                actionManager.Stop();
            }
        }

        private void btntbDestinationFolderDefault_Click(object sender, EventArgs e)
        {
            fbd.SelectedPath = Properties.Settings.Default.DestinationFolder;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbDestinationFolderDefault.Text = fbd.SelectedPath;
            }
        }

        private void applySettings(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Enabled = false;
            try
            {
                destination_folder = tbDestinationFolderDefault.Text;
                timer_interval = Convert.ToInt32(nudTimerIntervalDefault.Value);
                play_sound = cbPlaySoundDefault.Checked;
                do_action_w = cbCameraShot.Checked;
                actionManager.applySettings();
            }
            finally
            {
                Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void tmrDefault_Tick(object sender, EventArgs e)
        {
            countdown_default = (sender as Timer).Interval / 1000;
        }

        private void tmrOneSecond_Tick(object sender, EventArgs e)
        {
            countdown_default--;
        }

        private void Stop(object sender, EventArgs e)
        {
            maStop(sender, e);
        }

        private void Start(object sender, EventArgs e)
        {
            maStart(sender, e);
        }

        private void Shot(object sender, EventArgs e)
        {
            maShot(sender, e);
        }

        private void ntfIcn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
                ntfIcn.Visible = false;
                // (sender as NotifyIcon).Visible = false;
                Show();
            }
        }
    }
}