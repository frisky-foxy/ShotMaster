using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using prjShotMaster.Actions;

namespace prjShotMaster
{
    public partial class frmMain : Form
    {
        public CActionManager actionManager;
        private bool b_minimize_on_close = true;
        private static string AC_TAG_PAUSE = "Pause";
        private static string AC_TAG_START = "Start";
        private int timeToActionDefault = 0;

        public frmMain()
        {
            InitializeComponent();
            // validate DestinationFolder
            string path = Properties.Settings.Default.DestinationFolder;
            // если путь относительный (без ":"), считаем, что относительно Рабочего стола текущего пользователя
            if (path.IndexOf(':') < 0)
            {
                // f.e., C:\Users\Username\Desktop
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + path;
                Properties.Settings.Default.DestinationFolder = path;
                Properties.Settings.Default.Save();
            }
            // set manager
            actionManager = new CActionManager();
            // show settings
            fillSettingsControls();
            // hook (старт перехвата клавы)
            CInterceptKeys.Hook();
            CInterceptKeys.KeyUp += InterceptKeys_KeyUp;
            // init
            pauseToolStripMenuItem.Tag = AC_TAG_PAUSE;
            shotNowToolStripMenuItem.ShortcutKeyDisplayString = Properties.Settings.Default.ShortcutKey;
            // Start
            actionManager.Start();
            // on start
            shotNow(null, null);
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
                shotNow(null, null);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (b_minimize_on_close)
            {
                e.Cancel = true;
                Hide();
            }
            else
            {
                shotNow(sender, e); // on exit
                CInterceptKeys.UnHook(); // UnHook
                actionManager.Stop();
            }
        }

        /* Menu actions */
        private void gitHubToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void exitApp(object sender, EventArgs e)
        {
            b_minimize_on_close = false;
            Close();
        }

        private void shotNow(object sender, EventArgs e)
        {
            tmrDefault.Stop();
            // if (is_visible) Hide();
            double tmp_opacity = this.Opacity;
            this.Opacity = 0;
            actionManager.Shot();
            this.Opacity = tmp_opacity;
            timeToActionDefault = tmrDefault.Interval / 1000;
            tmrDefault.Start();
        }

        private void pauseStart(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Tag.ToString() == AC_TAG_PAUSE)
            {
                shotNow(sender, e);
                actionManager.Stop();
                tmrDefault.Stop();
                (sender as ToolStripMenuItem).Tag = AC_TAG_START;
            }
            else if ((sender as ToolStripMenuItem).Tag.ToString() == AC_TAG_START)
            {
                actionManager.Start();
                tmrDefault.Start();
                shotNow(sender, e);
                (sender as ToolStripMenuItem).Tag = AC_TAG_PAUSE;
            }
        }

        private void openDestFolder(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.DestinationFolder);
        }

        private void openGitHubLink(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.GitHubLink);
        }
        /* /Menu actions */

        private void ntfIcn_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
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

        private void applySettingsDefault(object sender, EventArgs e)
        {
            Enabled = false;
            Properties.Settings.Default.PlaySound = cbPlaySoundDefault.Checked;
            Properties.Settings.Default.TimerInterval = Convert.ToInt32(tbTimerIntervalDefault.Text);
            Properties.Settings.Default.TimerIntervalS = Convert.ToInt32(tbTimerIntervalDefault.Text);
            Properties.Settings.Default.TimerIntervalW = Convert.ToInt32(tbTimerIntervalDefault.Text);
            Properties.Settings.Default.DestinationFolder = tbDestinationFolderDefault.Text;
            Properties.Settings.Default.DestinationFolderS = tbDestinationFolderDefault.Text;
            Properties.Settings.Default.DestinationFolderW = tbDestinationFolderDefault.Text;
            Properties.Settings.Default.Save();
            Enabled = true;

            actionManager.applySettings();
            fillSettingsControls();
        }

        private void fillSettingsControls()
        {
            tbDestinationFolderDefault.Text = Properties.Settings.Default.DestinationFolder;
            tbTimerIntervalDefault.Text = Properties.Settings.Default.TimerInterval.ToString();
            cbPlaySoundDefault.Checked = Properties.Settings.Default.PlaySound;
            tmrDefault.Stop();
            tmrDefault.Interval = Properties.Settings.Default.TimerInterval * 1000;
            timeToActionDefault = tmrDefault.Interval / 1000;
            tmrDefault.Start();
        }

        private void tmrDefault_Tick(object sender, EventArgs e)
        {
            timeToActionDefault = (sender as Timer).Interval / 1000;
        }

        private void tmrOneSecond_Tick(object sender, EventArgs e)
        {
            timeToActionDefault--;
            if (timeToActionDefault > 0)
            {
                Text = timeToActionDefault.ToString();
            }
            else
            {
                Text = "Shot!";
            }
        }
    }
}
