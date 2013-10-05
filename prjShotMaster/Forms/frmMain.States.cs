using System.Windows.Forms;

namespace prjShotMaster
{
    public partial class frmMain
    {
        // Form States
        private static int FS_STOP = 0;
        private static int FS_START = 1;
        private static int FS_SHOT = 2;

        // Action Tags
        private static string AT_START = "Start";
        private static string AT_STOP = "Stop";

        private bool b_shot_on_start = false;
        private bool b_shot_on_stop = false;

        private int _State;
        public int State
        {
            get { return _State; }
            set
            {
                _State = value;
                if (value == FS_SHOT)
                {
                    Shot();
                }
                else if (value == FS_START)
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
            timeToActionDefault = tmrDefault.Interval / 1000;
            toggleByTag(AT_STOP, false);
            toggleByTag(AT_START, true);
        }

        private void Shot()
        {
            tmrDefault.Stop();
            double tmp_opacity = this.Opacity;
            this.Opacity = 0;

            actionManager.Shot();

            this.Opacity = tmp_opacity;
            timeToActionDefault = tmrDefault.Interval / 1000;
            tmrDefault.Start();
        }

        private void toggleByTag(string tag, bool show)
        {
            /*
            foreach (Control control in this.Controls.Find(tag, true))
            {
                if (control.Tag != null && control.Tag.ToString() == tag)
                {
                    // control.Visible = show;
                    MessageBox.Show(control.Tag.ToString());
                }
            }
            */
            if (tag == AT_START)
            {
                startToolStripMenuItem.Visible = show;
                tsbtnStart.Visible = show;
                stopToolStripMenuItem.Visible = !show;
                tsbtnStop.Visible = !show;
            }
            else if (tag == AT_STOP)
            {
                startToolStripMenuItem.Visible = !show;
                tsbtnStart.Visible = !show;
                stopToolStripMenuItem.Visible = show;
                tsbtnStop.Visible = show;
            }
        }

    }
}
