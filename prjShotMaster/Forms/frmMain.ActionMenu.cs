using System;
using System.Windows.Forms;

namespace prjShotMaster
{
    public partial class frmMain
    {
        private void gitHubToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = (sender as prjShotMaster.Components.CToolStripMenuItemLink).Cursor;
        }

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
            State = FS_SHOT;
        }

        private void Start(object sender, EventArgs e)
        {
            State = FS_START;
        }
    }
}
