using System;
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
                tsslblCountdown.Text = string.Format(
                    // "{0:D2}h:{1:D2}m:{2:D2}s",
                    "{0:D2}:{1:D2}:{2:D2}",
                    t.Hours,
                    t.Minutes,
                    t.Seconds
                );
                ntfIcn.Text = "(" + _countdown_default.ToString() + ") " + ntfIcnText;
            }
        }
        private string ntfIcnText;

        public frmMain()
        {
            InitializeComponent();
            // init
            shotNowToolStripMenuItem.ShortcutKeyDisplayString = Properties.Settings.Default.ShortcutKey;
            gitHubToolStripMenuItem.URI = Properties.Settings.Default.GitHubURI;
            ntfIcnText = ntfIcn.Text;
            // set manager
            actionManager = new CActionManager();
            // set settings
            destination_folder = Properties.Settings.Default.DestinationFolder;
            timer_interval = Properties.Settings.Default.TimerInterval;
            play_sound = Properties.Settings.Default.PlaySound;
            // hook (старт перехвата клавы)
            CInterceptKeys.Hook();
            CInterceptKeys.KeyUp += InterceptKeys_KeyUp;
            // on start
            if (b_start_on_run)
            {
                State = FS_START;
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
                if (b_shot_on_exit && State == FS_START) // on exit
                {
                    Shot();
                }
                CInterceptKeys.UnHook(); // UnHook
                actionManager.Stop();
            }
        }

        private void ntfIcn_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            ntfIcn.Visible = false;
            Show();
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

        private void gitHubToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = (sender as prjShotMaster.Components.CToolStripMenuItemLink).Cursor;
        }
    }
}