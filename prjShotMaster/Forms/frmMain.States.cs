using System;
using System.Windows.Forms;

namespace prjShotMaster
{
    public partial class frmMain
    {
        // Form States
        private static int FS_STOP = 0;
        private static int FS_START = 1;

        // Action Tags
        private static string AT_START = "Start";
        private static string AT_STOP = "Stop";

        // Action text "icons"
        private static string AI_START = "▶"; // "Working"
        private static string AI_STOP = "■"; // "Stopped"

        private bool b_shot_on_start = true;
        private bool b_shot_on_stop = true;

        private string _state_text_icon;
        private string state_text_icon
        {
            get
            {
                return _state_text_icon;
            }
            set
            {
                _state_text_icon = value;
                ntfIcn.Text = String.Format("{0}\n{1} {2}", ntfIcnText, state_text_icon, tsslblCountdown.Text);
            }
        }

        private int _state;
        public int state
        {
            get { return _state; }
            set
            {
                _state = value;
                if (value == FS_START)
                {
                    Start();
                }
                else if (value == FS_STOP)
                {
                    Stop();
                }
            }
        }

        private void Start()
        {
            actionManager.Start();
            tmrDefault.Start();
            tmrOneSecond.Start();
            toggleByTag(AT_STOP, true);
            toggleByTag(AT_START, false);
            if (b_shot_on_start)
            {
                Shot();
            }
            state_text_icon = AI_START;
        }

        private void Stop()
        {
            if (b_shot_on_stop)
            {
                Shot();
            }
            actionManager.Stop();
            tmrDefault.Stop();
            tmrOneSecond.Stop();
            countdown_default = tmrDefault.Interval / 1000;
            toggleByTag(AT_STOP, false);
            toggleByTag(AT_START, true);
            state_text_icon = AI_STOP;
        }

        private void Shot()
        {
            tmrDefault.Stop();
            tmrOneSecond.Stop();
            double tmp_opacity = this.Opacity;
            this.Opacity = 0;

            actionManager.Shot();

            this.Opacity = tmp_opacity;
            countdown_default = tmrDefault.Interval / 1000;
            tmrDefault.Start();
            tmrOneSecond.Start();
        }

        private void toggleByTag(string tag, bool show)
        {
            if (tag == AT_START)
            {
                startToolStripMenuItem.Visible = show;
                startToolStripMenuItem1.Visible = show;
                tsbtnStart.Visible = show;
                stopToolStripMenuItem.Visible = !show;
                stopToolStripMenuItem1.Visible = !show;
                tsbtnStop.Visible = !show;
            }
            else if (tag == AT_STOP)
            {
                startToolStripMenuItem.Visible = !show;
                startToolStripMenuItem1.Visible = !show;
                tsbtnStart.Visible = !show;
                stopToolStripMenuItem.Visible = show;
                stopToolStripMenuItem1.Visible = show;
                tsbtnStop.Visible = show;
            }
        }

    }
}
