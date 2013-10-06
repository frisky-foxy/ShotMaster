using System;
using System.Windows.Forms;
using prjShotMaster.Forms;

namespace prjShotMaster
{
    public partial class frmMain
    {
        private void exitApp(object sender, EventArgs e)
        {
            b_minimize_on_close = false;
            Close();
        }

        private void openDestFolder(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.DestinationFolder);
        }

        private void Stop(object sender, EventArgs e)
        {
            State = FS_STOP;
        }

        private void Shot(object sender, EventArgs e)
        {
            Shot();
        }

        private void Start(object sender, EventArgs e)
        {
            State = FS_START;
        }

        private void showAboutForm(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.Show();
        }
    }
}
