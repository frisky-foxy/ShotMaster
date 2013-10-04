using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjShotMaster.Components
{
    class CToolStripMenuItemLink : ToolStripMenuItem
    {
        private Uri _URI = null;
        public Uri URI
        {
            get { return _URI; }
            set { _URI = value;  }
        }

        private Cursor _Cursor = Cursors.Hand;
        public Cursor Cursor
        {
            get { return _Cursor; }
            set { _Cursor = value; }
        }

        protected override void OnClick(EventArgs e)
        {
            if (URI != null)
            {
                try
                {
                    System.Diagnostics.Process.Start(URI.ToString());
                }
                catch // not finally
                {
                    base.OnClick(e);
                }
            }
            else
            {
                base.OnClick(e);
            }
        }
    }
}