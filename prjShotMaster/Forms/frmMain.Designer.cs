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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCameraShot = new System.Windows.Forms.CheckBox();
            this.pnlPlaySoundDefault = new System.Windows.Forms.Panel();
            this.cbPlaySoundDefault = new System.Windows.Forms.CheckBox();
            this.pnlTimerIntervalDefault = new System.Windows.Forms.Panel();
            this.nudTimerIntervalDefault = new System.Windows.Forms.NumericUpDown();
            this.lblTimerIntervalDefault1 = new System.Windows.Forms.Label();
            this.lblTimerIntervalDefault = new System.Windows.Forms.Label();
            this.pnlDestinationFolderDefault = new System.Windows.Forms.Panel();
            this.btntbDestinationFolderDefault = new System.Windows.Forms.Button();
            this.lblDestinationFolderDefault = new System.Windows.Forms.Label();
            this.tbDestinationFolderDefault = new System.Windows.Forms.TextBox();
            this.btnApplyDefault = new System.Windows.Forms.Button();
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shotNowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openDestinationFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
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
            this.panel1.SuspendLayout();
            this.pnlPlaySoundDefault.SuspendLayout();
            this.pnlTimerIntervalDefault.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerIntervalDefault)).BeginInit();
            this.pnlDestinationFolderDefault.SuspendLayout();
            this.cmsNotify.SuspendLayout();
            this.msMainMenu.SuspendLayout();
            this.ss.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSettingsDefault
            // 
            this.pnlSettingsDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettingsDefault.Controls.Add(this.panel1);
            this.pnlSettingsDefault.Controls.Add(this.pnlPlaySoundDefault);
            this.pnlSettingsDefault.Controls.Add(this.pnlTimerIntervalDefault);
            this.pnlSettingsDefault.Controls.Add(this.pnlDestinationFolderDefault);
            this.pnlSettingsDefault.Controls.Add(this.btnApplyDefault);
            this.pnlSettingsDefault.Location = new System.Drawing.Point(3, 58);
            this.pnlSettingsDefault.Name = "pnlSettingsDefault";
            this.pnlSettingsDefault.Size = new System.Drawing.Size(573, 172);
            this.pnlSettingsDefault.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbCameraShot);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 32);
            this.panel1.TabIndex = 15;
            // 
            // cbCameraShot
            // 
            this.cbCameraShot.AutoSize = true;
            this.cbCameraShot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbCameraShot.Location = new System.Drawing.Point(6, 6);
            this.cbCameraShot.Name = "cbCameraShot";
            this.cbCameraShot.Size = new System.Drawing.Size(139, 21);
            this.cbCameraShot.TabIndex = 4;
            this.cbCameraShot.Text = "Camera shots (β)";
            this.cbCameraShot.UseVisualStyleBackColor = true;
            // 
            // pnlPlaySoundDefault
            // 
            this.pnlPlaySoundDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlaySoundDefault.Controls.Add(this.cbPlaySoundDefault);
            this.pnlPlaySoundDefault.Location = new System.Drawing.Point(5, 104);
            this.pnlPlaySoundDefault.Name = "pnlPlaySoundDefault";
            this.pnlPlaySoundDefault.Size = new System.Drawing.Size(561, 32);
            this.pnlPlaySoundDefault.TabIndex = 14;
            // 
            // cbPlaySoundDefault
            // 
            this.cbPlaySoundDefault.AutoSize = true;
            this.cbPlaySoundDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbPlaySoundDefault.Location = new System.Drawing.Point(6, 6);
            this.cbPlaySoundDefault.Name = "cbPlaySoundDefault";
            this.cbPlaySoundDefault.Size = new System.Drawing.Size(100, 21);
            this.cbPlaySoundDefault.TabIndex = 3;
            this.cbPlaySoundDefault.Text = "Play sound";
            this.cbPlaySoundDefault.UseVisualStyleBackColor = true;
            // 
            // pnlTimerIntervalDefault
            // 
            this.pnlTimerIntervalDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTimerIntervalDefault.Controls.Add(this.nudTimerIntervalDefault);
            this.pnlTimerIntervalDefault.Controls.Add(this.lblTimerIntervalDefault1);
            this.pnlTimerIntervalDefault.Controls.Add(this.lblTimerIntervalDefault);
            this.pnlTimerIntervalDefault.Location = new System.Drawing.Point(5, 70);
            this.pnlTimerIntervalDefault.Name = "pnlTimerIntervalDefault";
            this.pnlTimerIntervalDefault.Size = new System.Drawing.Size(561, 32);
            this.pnlTimerIntervalDefault.TabIndex = 13;
            // 
            // nudTimerIntervalDefault
            // 
            this.nudTimerIntervalDefault.Location = new System.Drawing.Point(162, 6);
            this.nudTimerIntervalDefault.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTimerIntervalDefault.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTimerIntervalDefault.Name = "nudTimerIntervalDefault";
            this.nudTimerIntervalDefault.Size = new System.Drawing.Size(57, 22);
            this.nudTimerIntervalDefault.TabIndex = 2;
            this.nudTimerIntervalDefault.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblTimerIntervalDefault1
            // 
            this.lblTimerIntervalDefault1.AutoSize = true;
            this.lblTimerIntervalDefault1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTimerIntervalDefault1.Location = new System.Drawing.Point(225, 8);
            this.lblTimerIntervalDefault1.Name = "lblTimerIntervalDefault1";
            this.lblTimerIntervalDefault1.Size = new System.Drawing.Size(15, 17);
            this.lblTimerIntervalDefault1.TabIndex = 6;
            this.lblTimerIntervalDefault1.Text = "s";
            // 
            // lblTimerIntervalDefault
            // 
            this.lblTimerIntervalDefault.AutoSize = true;
            this.lblTimerIntervalDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTimerIntervalDefault.Location = new System.Drawing.Point(3, 8);
            this.lblTimerIntervalDefault.Name = "lblTimerIntervalDefault";
            this.lblTimerIntervalDefault.Size = new System.Drawing.Size(94, 17);
            this.lblTimerIntervalDefault.TabIndex = 5;
            this.lblTimerIntervalDefault.Text = "Timer interval";
            // 
            // pnlDestinationFolderDefault
            // 
            this.pnlDestinationFolderDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDestinationFolderDefault.Controls.Add(this.btntbDestinationFolderDefault);
            this.pnlDestinationFolderDefault.Controls.Add(this.lblDestinationFolderDefault);
            this.pnlDestinationFolderDefault.Controls.Add(this.tbDestinationFolderDefault);
            this.pnlDestinationFolderDefault.Location = new System.Drawing.Point(5, 36);
            this.pnlDestinationFolderDefault.Name = "pnlDestinationFolderDefault";
            this.pnlDestinationFolderDefault.Size = new System.Drawing.Size(561, 33);
            this.pnlDestinationFolderDefault.TabIndex = 9;
            // 
            // btntbDestinationFolderDefault
            // 
            this.btntbDestinationFolderDefault.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btntbDestinationFolderDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btntbDestinationFolderDefault.Location = new System.Drawing.Point(532, 5);
            this.btntbDestinationFolderDefault.Name = "btntbDestinationFolderDefault";
            this.btntbDestinationFolderDefault.Size = new System.Drawing.Size(23, 23);
            this.btntbDestinationFolderDefault.TabIndex = 1;
            this.btntbDestinationFolderDefault.Text = "…";
            this.btntbDestinationFolderDefault.UseVisualStyleBackColor = true;
            this.btntbDestinationFolderDefault.Click += new System.EventHandler(this.btntbDestinationFolderDefault_Click);
            // 
            // lblDestinationFolderDefault
            // 
            this.lblDestinationFolderDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDestinationFolderDefault.Location = new System.Drawing.Point(3, 8);
            this.lblDestinationFolderDefault.Name = "lblDestinationFolderDefault";
            this.lblDestinationFolderDefault.Size = new System.Drawing.Size(153, 23);
            this.lblDestinationFolderDefault.TabIndex = 2;
            this.lblDestinationFolderDefault.Text = "Destination folder";
            // 
            // tbDestinationFolderDefault
            // 
            this.tbDestinationFolderDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDestinationFolderDefault.Location = new System.Drawing.Point(162, 5);
            this.tbDestinationFolderDefault.Name = "tbDestinationFolderDefault";
            this.tbDestinationFolderDefault.Size = new System.Drawing.Size(364, 22);
            this.tbDestinationFolderDefault.TabIndex = 5;
            // 
            // btnApplyDefault
            // 
            this.btnApplyDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnApplyDefault.Location = new System.Drawing.Point(485, 140);
            this.btnApplyDefault.Name = "btnApplyDefault";
            this.btnApplyDefault.Size = new System.Drawing.Size(75, 25);
            this.btnApplyDefault.TabIndex = 5;
            this.btnApplyDefault.Text = "&Apply";
            this.btnApplyDefault.UseVisualStyleBackColor = true;
            this.btnApplyDefault.Click += new System.EventHandler(this.applySettings);
            // 
            // cmsNotify
            // 
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem1,
            this.startToolStripMenuItem1,
            this.shotNowToolStripMenuItem1,
            this.openDestinationFolderToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.closeToolStripMenuItem});
            this.cmsNotify.Name = "contextMenuStrip1";
            this.cmsNotify.Size = new System.Drawing.Size(237, 130);
            // 
            // stopToolStripMenuItem1
            // 
            this.stopToolStripMenuItem1.Image = global::prjShotMaster.Properties.Resources.Stop;
            this.stopToolStripMenuItem1.Name = "stopToolStripMenuItem1";
            this.stopToolStripMenuItem1.Size = new System.Drawing.Size(236, 24);
            this.stopToolStripMenuItem1.Tag = "Stop";
            this.stopToolStripMenuItem1.Text = "Stop";
            this.stopToolStripMenuItem1.Visible = false;
            this.stopToolStripMenuItem1.Click += new System.EventHandler(this.Stop);
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.Image = global::prjShotMaster.Properties.Resources.Start;
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(236, 24);
            this.startToolStripMenuItem1.Tag = "Start";
            this.startToolStripMenuItem1.Text = "Start";
            this.startToolStripMenuItem1.Click += new System.EventHandler(this.Start);
            // 
            // shotNowToolStripMenuItem1
            // 
            this.shotNowToolStripMenuItem1.Name = "shotNowToolStripMenuItem1";
            this.shotNowToolStripMenuItem1.Size = new System.Drawing.Size(236, 24);
            this.shotNowToolStripMenuItem1.Text = "Shot now";
            this.shotNowToolStripMenuItem1.Click += new System.EventHandler(this.Shot);
            // 
            // openDestinationFolderToolStripMenuItem1
            // 
            this.openDestinationFolderToolStripMenuItem1.Name = "openDestinationFolderToolStripMenuItem1";
            this.openDestinationFolderToolStripMenuItem1.Size = new System.Drawing.Size(236, 24);
            this.openDestinationFolderToolStripMenuItem1.Text = "Open destination folder";
            this.openDestinationFolderToolStripMenuItem1.Click += new System.EventHandler(this.maOpenDestFolder);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(233, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.maExitApp);
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.helpToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(578, 28);
            this.msMainMenu.TabIndex = 2;
            this.msMainMenu.Text = "menuStrip1";
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
            this.tsmiFile.Size = new System.Drawing.Size(44, 24);
            this.tsmiFile.Text = "&File";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::prjShotMaster.Properties.Resources.Stop;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.stopToolStripMenuItem.Tag = "Stop";
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Visible = false;
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.Stop);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::prjShotMaster.Properties.Resources.Start;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.startToolStripMenuItem.Tag = "Start";
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.Start);
            // 
            // shotNowToolStripMenuItem
            // 
            this.shotNowToolStripMenuItem.Name = "shotNowToolStripMenuItem";
            this.shotNowToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.shotNowToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.shotNowToolStripMenuItem.Text = "Shot now";
            this.shotNowToolStripMenuItem.Click += new System.EventHandler(this.Shot);
            // 
            // openDestinationFolderToolStripMenuItem
            // 
            this.openDestinationFolderToolStripMenuItem.Name = "openDestinationFolderToolStripMenuItem";
            this.openDestinationFolderToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.openDestinationFolderToolStripMenuItem.Text = "Open destination folder";
            this.openDestinationFolderToolStripMenuItem.Click += new System.EventHandler(this.maOpenDestFolder);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(233, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.maExitApp);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.aboutToolStripMenuItem.Text = "About…";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.maShowAboutForm);
            // 
            // ntfIcn
            // 
            this.ntfIcn.ContextMenuStrip = this.cmsNotify;
            this.ntfIcn.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIcn.Icon")));
            this.ntfIcn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ntfIcn_MouseClick);
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
            this.ss.Location = new System.Drawing.Point(0, 232);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(578, 22);
            this.ss.SizingGrip = false;
            this.ss.TabIndex = 6;
            this.ss.Text = "statusStrip1";
            // 
            // tsslblCountdown
            // 
            this.tsslblCountdown.Name = "tsslblCountdown";
            this.tsslblCountdown.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnStart,
            this.tsbtnStop,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(578, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnStart
            // 
            this.tsbtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnStart.ForeColor = System.Drawing.Color.Green;
            this.tsbtnStart.Name = "tsbtnStart";
            this.tsbtnStart.Size = new System.Drawing.Size(26, 24);
            this.tsbtnStart.Tag = "Start";
            this.tsbtnStart.Text = "▶";
            this.tsbtnStart.ToolTipText = "Start";
            this.tsbtnStart.Click += new System.EventHandler(this.Start);
            // 
            // tsbtnStop
            // 
            this.tsbtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnStop.ForeColor = System.Drawing.Color.Red;
            this.tsbtnStop.Name = "tsbtnStop";
            this.tsbtnStop.Size = new System.Drawing.Size(26, 24);
            this.tsbtnStop.Tag = "Stop";
            this.tsbtnStop.Text = "■";
            this.tsbtnStop.ToolTipText = "Stop";
            this.tsbtnStop.Visible = false;
            this.tsbtnStop.Click += new System.EventHandler(this.Stop);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnApplyDefault;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 254);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.msMainMenu);
            this.Controls.Add(this.pnlSettingsDefault);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlSettingsDefault.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPlaySoundDefault.ResumeLayout(false);
            this.pnlPlaySoundDefault.PerformLayout();
            this.pnlTimerIntervalDefault.ResumeLayout(false);
            this.pnlTimerIntervalDefault.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerIntervalDefault)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnStart;
        private System.Windows.Forms.ToolStripButton tsbtnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.NumericUpDown nudTimerIntervalDefault;
        private System.Windows.Forms.ToolStripMenuItem shotNowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem openDestinationFolderToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbCameraShot;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
    }
}

