namespace prjShotMaster
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlSettingsDefault = new System.Windows.Forms.Panel();
            this.pnlPlaySoundDefault = new System.Windows.Forms.Panel();
            this.cbPlaySoundDefault = new System.Windows.Forms.CheckBox();
            this.pnlTimerIntervalDefault = new System.Windows.Forms.Panel();
            this.lblTimerIntervalDefault1 = new System.Windows.Forms.Label();
            this.lblTimerIntervalDefault = new System.Windows.Forms.Label();
            this.tbTimerIntervalDefault = new System.Windows.Forms.TextBox();
            this.pnlDestinationFolderDefault = new System.Windows.Forms.Panel();
            this.btntbDestinationFolderDefault = new System.Windows.Forms.Button();
            this.lblDestinationFolderDefault = new System.Windows.Forms.Label();
            this.tbDestinationFolderDefault = new System.Windows.Forms.TextBox();
            this.btnApplyDefault = new System.Windows.Forms.Button();
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shotNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDestinationFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new prjShotMaster.Components.CToolStripMenuItemLink();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ntfIcn = new System.Windows.Forms.NotifyIcon(this.components);
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.tmrDefault = new System.Windows.Forms.Timer(this.components);
            this.tmrOneSecond = new System.Windows.Forms.Timer(this.components);
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tsslblCountdown = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnStart = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlSettingsDefault.SuspendLayout();
            this.pnlPlaySoundDefault.SuspendLayout();
            this.pnlTimerIntervalDefault.SuspendLayout();
            this.pnlDestinationFolderDefault.SuspendLayout();
            this.cmsNotify.SuspendLayout();
            this.msMainMenu.SuspendLayout();
            this.ss.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSettingsDefault
            // 
            resources.ApplyResources(this.pnlSettingsDefault, "pnlSettingsDefault");
            this.pnlSettingsDefault.Controls.Add(this.pnlPlaySoundDefault);
            this.pnlSettingsDefault.Controls.Add(this.pnlTimerIntervalDefault);
            this.pnlSettingsDefault.Controls.Add(this.pnlDestinationFolderDefault);
            this.pnlSettingsDefault.Controls.Add(this.btnApplyDefault);
            this.pnlSettingsDefault.Name = "pnlSettingsDefault";
            // 
            // pnlPlaySoundDefault
            // 
            resources.ApplyResources(this.pnlPlaySoundDefault, "pnlPlaySoundDefault");
            this.pnlPlaySoundDefault.Controls.Add(this.cbPlaySoundDefault);
            this.pnlPlaySoundDefault.Name = "pnlPlaySoundDefault";
            // 
            // cbPlaySoundDefault
            // 
            resources.ApplyResources(this.cbPlaySoundDefault, "cbPlaySoundDefault");
            this.cbPlaySoundDefault.Name = "cbPlaySoundDefault";
            this.cbPlaySoundDefault.UseVisualStyleBackColor = true;
            // 
            // pnlTimerIntervalDefault
            // 
            resources.ApplyResources(this.pnlTimerIntervalDefault, "pnlTimerIntervalDefault");
            this.pnlTimerIntervalDefault.Controls.Add(this.lblTimerIntervalDefault1);
            this.pnlTimerIntervalDefault.Controls.Add(this.lblTimerIntervalDefault);
            this.pnlTimerIntervalDefault.Controls.Add(this.tbTimerIntervalDefault);
            this.pnlTimerIntervalDefault.Name = "pnlTimerIntervalDefault";
            // 
            // lblTimerIntervalDefault1
            // 
            resources.ApplyResources(this.lblTimerIntervalDefault1, "lblTimerIntervalDefault1");
            this.lblTimerIntervalDefault1.Name = "lblTimerIntervalDefault1";
            // 
            // lblTimerIntervalDefault
            // 
            resources.ApplyResources(this.lblTimerIntervalDefault, "lblTimerIntervalDefault");
            this.lblTimerIntervalDefault.Name = "lblTimerIntervalDefault";
            // 
            // tbTimerIntervalDefault
            // 
            resources.ApplyResources(this.tbTimerIntervalDefault, "tbTimerIntervalDefault");
            this.tbTimerIntervalDefault.Name = "tbTimerIntervalDefault";
            // 
            // pnlDestinationFolderDefault
            // 
            resources.ApplyResources(this.pnlDestinationFolderDefault, "pnlDestinationFolderDefault");
            this.pnlDestinationFolderDefault.Controls.Add(this.btntbDestinationFolderDefault);
            this.pnlDestinationFolderDefault.Controls.Add(this.lblDestinationFolderDefault);
            this.pnlDestinationFolderDefault.Controls.Add(this.tbDestinationFolderDefault);
            this.pnlDestinationFolderDefault.Name = "pnlDestinationFolderDefault";
            // 
            // btntbDestinationFolderDefault
            // 
            resources.ApplyResources(this.btntbDestinationFolderDefault, "btntbDestinationFolderDefault");
            this.btntbDestinationFolderDefault.Name = "btntbDestinationFolderDefault";
            this.btntbDestinationFolderDefault.UseVisualStyleBackColor = true;
            this.btntbDestinationFolderDefault.Click += new System.EventHandler(this.btntbDestinationFolderDefault_Click);
            // 
            // lblDestinationFolderDefault
            // 
            resources.ApplyResources(this.lblDestinationFolderDefault, "lblDestinationFolderDefault");
            this.lblDestinationFolderDefault.Name = "lblDestinationFolderDefault";
            // 
            // tbDestinationFolderDefault
            // 
            resources.ApplyResources(this.tbDestinationFolderDefault, "tbDestinationFolderDefault");
            this.tbDestinationFolderDefault.Name = "tbDestinationFolderDefault";
            // 
            // btnApplyDefault
            // 
            resources.ApplyResources(this.btnApplyDefault, "btnApplyDefault");
            this.btnApplyDefault.Name = "btnApplyDefault";
            this.btnApplyDefault.UseVisualStyleBackColor = true;
            this.btnApplyDefault.Click += new System.EventHandler(this.applySettingsDefault);
            // 
            // cmsNotify
            // 
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.cmsNotify.Name = "contextMenuStrip1";
            resources.ApplyResources(this.cmsNotify, "cmsNotify");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.exitApp);
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.msMainMenu, "msMainMenu");
            this.msMainMenu.Name = "msMainMenu";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.startToolStripMenuItem,
            this.shotNowToolStripMenuItem,
            this.openDestinationFolderToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.tsmiFile.Name = "tsmiFile";
            resources.ApplyResources(this.tsmiFile, "tsmiFile");
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            resources.ApplyResources(this.stopToolStripMenuItem, "stopToolStripMenuItem");
            this.stopToolStripMenuItem.Tag = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.Stop);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            this.startToolStripMenuItem.Tag = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.Start);
            // 
            // shotNowToolStripMenuItem
            // 
            this.shotNowToolStripMenuItem.Name = "shotNowToolStripMenuItem";
            resources.ApplyResources(this.shotNowToolStripMenuItem, "shotNowToolStripMenuItem");
            this.shotNowToolStripMenuItem.Click += new System.EventHandler(this.Shot);
            // 
            // openDestinationFolderToolStripMenuItem
            // 
            this.openDestinationFolderToolStripMenuItem.Name = "openDestinationFolderToolStripMenuItem";
            resources.ApplyResources(this.openDestinationFolderToolStripMenuItem, "openDestinationFolderToolStripMenuItem");
            this.openDestinationFolderToolStripMenuItem.Click += new System.EventHandler(this.openDestFolder);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitApp);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.gitHubToolStripMenuItem, "gitHubToolStripMenuItem");
            this.gitHubToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.URI = null;
            this.gitHubToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gitHubToolStripMenuItem_MouseMove);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            // 
            // ntfIcn
            // 
            this.ntfIcn.ContextMenuStrip = this.cmsNotify;
            resources.ApplyResources(this.ntfIcn, "ntfIcn");
            this.ntfIcn.DoubleClick += new System.EventHandler(this.ntfIcn_DoubleClick);
            // 
            // tmrDefault
            // 
            this.tmrDefault.Tick += new System.EventHandler(this.tmrDefault_Tick);
            // 
            // tmrOneSecond
            // 
            this.tmrOneSecond.Interval = 1000;
            this.tmrOneSecond.Tick += new System.EventHandler(this.tmrOneSecond_Tick);
            // 
            // ss
            // 
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblCountdown});
            resources.ApplyResources(this.ss, "ss");
            this.ss.Name = "ss";
            this.ss.SizingGrip = false;
            // 
            // tsslblCountdown
            // 
            this.tsslblCountdown.Name = "tsslblCountdown";
            resources.ApplyResources(this.tsslblCountdown, "tsslblCountdown");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnStart,
            this.tsbtnStop,
            this.toolStripSeparator1});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // tsbtnStart
            // 
            this.tsbtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnStart.ForeColor = System.Drawing.Color.Green;
            this.tsbtnStart.Name = "tsbtnStart";
            resources.ApplyResources(this.tsbtnStart, "tsbtnStart");
            this.tsbtnStart.Tag = "Start";
            this.tsbtnStart.Click += new System.EventHandler(this.Start);
            // 
            // tsbtnStop
            // 
            this.tsbtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnStop.ForeColor = System.Drawing.Color.Red;
            this.tsbtnStop.Name = "tsbtnStop";
            resources.ApplyResources(this.tsbtnStop, "tsbtnStop");
            this.tsbtnStop.Tag = "Stop";
            this.tsbtnStop.Click += new System.EventHandler(this.Stop);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnApplyDefault;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.msMainMenu);
            this.Controls.Add(this.pnlSettingsDefault);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlSettingsDefault.ResumeLayout(false);
            this.pnlPlaySoundDefault.ResumeLayout(false);
            this.pnlPlaySoundDefault.PerformLayout();
            this.pnlTimerIntervalDefault.ResumeLayout(false);
            this.pnlTimerIntervalDefault.PerformLayout();
            this.pnlDestinationFolderDefault.ResumeLayout(false);
            this.pnlDestinationFolderDefault.PerformLayout();
            this.cmsNotify.ResumeLayout(false);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSettingsDefault;
        private System.Windows.Forms.Button btnApplyDefault;
        private System.Windows.Forms.Panel pnlDestinationFolderDefault;
        private System.Windows.Forms.Label lblDestinationFolderDefault;
        private System.Windows.Forms.TextBox tbDestinationFolderDefault;
        private System.Windows.Forms.Button btntbDestinationFolderDefault;
        private System.Windows.Forms.Panel pnlTimerIntervalDefault;
        private System.Windows.Forms.TextBox tbTimerIntervalDefault;
        private System.Windows.Forms.Label lblTimerIntervalDefault;
        private System.Windows.Forms.Label lblTimerIntervalDefault1;
        private System.Windows.Forms.Panel pnlPlaySoundDefault;
        private System.Windows.Forms.CheckBox cbPlaySoundDefault;
        private System.Windows.Forms.ContextMenuStrip cmsNotify;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.NotifyIcon ntfIcn;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shotNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openDestinationFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Timer tmrDefault;
        private System.Windows.Forms.Timer tmrOneSecond;
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripStatusLabel tsslblCountdown;
        private Components.CToolStripMenuItemLink gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnStart;
        private System.Windows.Forms.ToolStripButton tsbtnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

