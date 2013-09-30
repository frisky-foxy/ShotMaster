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
        public CActionManager actionManager = new CActionManager();
        private bool b_minimize_on_close = true;
        private static string AC_TAG_PAUSE = "Pause";
        private static string AC_TAG_START = "Start";

        public frmMain()
        {
            InitializeComponent();
            fillSettingsControls();
            // hook (старт перехвата клавы)
            CInterceptKeys.Hook();
            CInterceptKeys.KeyUp += InterceptKeys_KeyUp;
            // hide
            Visible = false;
            // Start
            actionManager.Start();
            pauseToolStripMenuItem.Tag = AC_TAG_PAUSE;
            // on start
            actionManager.Shot();
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
                actionManager.Shot(); // on exit
                actionManager.Stop();
                CInterceptKeys.UnHook(); // UnHook
            }
        }

        /* Menu actions */
        private void exitApp(object sender, EventArgs e)
        {
            b_minimize_on_close = false;
            Close();
        }

        private void shotNow(object sender, EventArgs e)
        {
            actionManager.Shot();
        }

        private void pauseStart(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Tag.ToString() == AC_TAG_PAUSE)
            {
                actionManager.Shot();
                actionManager.Stop();
                (sender as ToolStripMenuItem).Tag = AC_TAG_START;
            }
            else if ((sender as ToolStripMenuItem).Tag.ToString() == AC_TAG_START)
            {
                actionManager.Start();
                actionManager.Shot();
                (sender as ToolStripMenuItem).Tag = AC_TAG_PAUSE;
            }
        }

        private void openDestFolder(object sender, EventArgs e)
        {
            string path = Properties.Settings.Default.DestinationFolder;
            // если путь относительный (без ":"), считаем, что относительно Рабочего стола текущего пользователя
            if (path.IndexOf(':') < 0)
            {
                // f.e., C:\Users\Username\Desktop
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + path;
            }
            System.Diagnostics.Process.Start(path);
        }
        /* /Menu actions */

        private void ntfIcn_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Show();
        }

        private void applySettingsDefault(object sender, EventArgs e)
        {
            Properties.Settings.Default.PlaySound = cbPlaySoundDefault.Checked;
            Properties.Settings.Default.TimerInterval = Convert.ToInt32(tbTimerIntervalDefault.Text);
            Properties.Settings.Default.TimerIntervalS = Convert.ToInt32(tbTimerIntervalDefault.Text);
            Properties.Settings.Default.TimerIntervalW = Convert.ToInt32(tbTimerIntervalDefault.Text);
            Properties.Settings.Default.DestinationFolder = tbDestinationFolderDefault.Text;
            Properties.Settings.Default.DestinationFolderS = tbDestinationFolderDefault.Text;
            Properties.Settings.Default.DestinationFolderW = tbDestinationFolderDefault.Text;
            Properties.Settings.Default.Save();

            actionManager.applySettings();
            fillSettingsControls();
        }

        private void fillSettingsControls()
        {
            tbDestinationFolderDefault.Text = Properties.Settings.Default.DestinationFolder;
            tbTimerIntervalDefault.Text = Properties.Settings.Default.TimerInterval.ToString();
            cbPlaySoundDefault.Checked = Properties.Settings.Default.PlaySound;
        }
    }
}
