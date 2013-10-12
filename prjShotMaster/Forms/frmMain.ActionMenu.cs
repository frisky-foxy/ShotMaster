using System;
using System.Windows.Forms;
using prjShotMaster.Forms;

namespace prjShotMaster
{
    public partial class frmMain
    {
        private void maExitApp(object sender, EventArgs e)
        {
            b_minimize_on_close = false;
            Close();
        }

        private void maOpenDestFolder(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.DestinationFolder);
        }

        private void maStop(object sender, EventArgs e)
        {
            State = FS_STOP;
        }

        private void maShot(object sender, EventArgs e)
        {
            Shot();
        }

        private void maStart(object sender, EventArgs e)
        {
            State = FS_START;
        }

        private void maShowAboutForm(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog(this);
        }
    }
}
