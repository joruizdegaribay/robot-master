namespace RobotMaster
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.robotMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.miRobots = new System.Windows.Forms.ToolStripMenuItem();
            this.miPortNames = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.miDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tscbPortName = new System.Windows.Forms.ToolStripComboBox();
            this.tsbConnect = new System.Windows.Forms.ToolStripButton();
            this.tsbDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscbRobot = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.horizontalScroll = new System.Windows.Forms.HScrollBar();
            this.verticalScroll = new System.Windows.Forms.VScrollBar();
            this.pContainer = new System.Windows.Forms.Panel();
            this.lLog = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chShowEvents = new System.Windows.Forms.CheckBox();
            this.bClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robotMasterToolStripMenuItem,
            this.mConnection,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // robotMasterToolStripMenuItem
            // 
            this.robotMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.robotMasterToolStripMenuItem.Name = "robotMasterToolStripMenuItem";
            this.robotMasterToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.robotMasterToolStripMenuItem.Text = "Application";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Exit";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.miExit_Click);
            // 
            // mConnection
            // 
            this.mConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRobots,
            this.miPortNames,
            this.toolStripSeparator2,
            this.miConnect,
            this.miDisconnect});
            this.mConnection.Name = "mConnection";
            this.mConnection.Size = new System.Drawing.Size(81, 20);
            this.mConnection.Text = "Connection";
            this.mConnection.DropDownOpening += new System.EventHandler(this.mConnection_DropDownOpening);
            // 
            // miRobots
            // 
            this.miRobots.Name = "miRobots";
            this.miRobots.Size = new System.Drawing.Size(133, 22);
            this.miRobots.Text = "Robots";
            // 
            // miPortNames
            // 
            this.miPortNames.Name = "miPortNames";
            this.miPortNames.Size = new System.Drawing.Size(133, 22);
            this.miPortNames.Text = "Com Port";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(130, 6);
            // 
            // miConnect
            // 
            this.miConnect.Image = ((System.Drawing.Image)(resources.GetObject("miConnect.Image")));
            this.miConnect.Name = "miConnect";
            this.miConnect.Size = new System.Drawing.Size(133, 22);
            this.miConnect.Text = "Connect";
            this.miConnect.Click += new System.EventHandler(this.miConnect_Click);
            // 
            // miDisconnect
            // 
            this.miDisconnect.Enabled = false;
            this.miDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("miDisconnect.Image")));
            this.miDisconnect.Name = "miDisconnect";
            this.miDisconnect.Size = new System.Drawing.Size(133, 22);
            this.miDisconnect.Text = "Disconnect";
            this.miDisconnect.Click += new System.EventHandler(this.miDisconnect_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ayudaToolStripMenuItem.Text = "Help";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercaDeToolStripMenuItem.Text = "About";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbPortName,
            this.tsbConnect,
            this.tsbDisconnect,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.tscbRobot});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(728, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tscbPortName
            // 
            this.tscbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbPortName.Name = "tscbPortName";
            this.tscbPortName.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tscbPortName.Size = new System.Drawing.Size(75, 27);
            this.tscbPortName.Sorted = true;
            this.tscbPortName.DropDown += new System.EventHandler(this.tscbPortName_DropDown);
            this.tscbPortName.SelectedIndexChanged += new System.EventHandler(this.tscbPortName_SelectedIndexChanged);
            // 
            // tsbConnect
            // 
            this.tsbConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbConnect.Image")));
            this.tsbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnect.Name = "tsbConnect";
            this.tsbConnect.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tsbConnect.Size = new System.Drawing.Size(26, 24);
            this.tsbConnect.Text = "Connect";
            this.tsbConnect.Click += new System.EventHandler(this.tsbConnect_Click);
            // 
            // tsbDisconnect
            // 
            this.tsbDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDisconnect.Enabled = false;
            this.tsbDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbDisconnect.Image")));
            this.tsbDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDisconnect.Name = "tsbDisconnect";
            this.tsbDisconnect.Size = new System.Drawing.Size(23, 24);
            this.tsbDisconnect.Text = "Disconnect";
            this.tsbDisconnect.Click += new System.EventHandler(this.tsbDisconnect_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 24);
            this.toolStripLabel1.Text = "Robot:";
            // 
            // tscbRobot
            // 
            this.tscbRobot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbRobot.Name = "tscbRobot";
            this.tscbRobot.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tscbRobot.Size = new System.Drawing.Size(75, 27);
            this.tscbRobot.SelectedIndexChanged += new System.EventHandler(this.tscbRobot_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slConnection});
            this.statusStrip1.Location = new System.Drawing.Point(3, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(728, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slConnection
            // 
            this.slConnection.Name = "slConnection";
            this.slConnection.Size = new System.Drawing.Size(79, 17);
            this.slConnection.Text = "Disconnected";
            // 
            // horizontalScroll
            // 
            this.horizontalScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.horizontalScroll.Enabled = false;
            this.horizontalScroll.LargeChange = 1;
            this.horizontalScroll.Location = new System.Drawing.Point(3, 351);
            this.horizontalScroll.Maximum = 10;
            this.horizontalScroll.Name = "horizontalScroll";
            this.horizontalScroll.Size = new System.Drawing.Size(704, 17);
            this.horizontalScroll.TabIndex = 3;
            this.horizontalScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.horizontalScroll_Scroll);
            // 
            // verticalScroll
            // 
            this.verticalScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verticalScroll.Enabled = false;
            this.verticalScroll.LargeChange = 1;
            this.verticalScroll.Location = new System.Drawing.Point(708, 3);
            this.verticalScroll.Maximum = 10;
            this.verticalScroll.Name = "verticalScroll";
            this.verticalScroll.Size = new System.Drawing.Size(17, 347);
            this.verticalScroll.TabIndex = 2;
            this.verticalScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.verticalScroll_Scroll);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.BackColor = System.Drawing.SystemColors.Window;
            this.pContainer.Location = new System.Drawing.Point(3, 3);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(704, 347);
            this.pContainer.TabIndex = 1;
            this.pContainer.Resize += new System.EventHandler(this.pContainer_Resize);
            // 
            // lLog
            // 
            this.lLog.AutoSize = true;
            this.lLog.Location = new System.Drawing.Point(3, 12);
            this.lLog.Name = "lLog";
            this.lLog.Size = new System.Drawing.Size(28, 15);
            this.lLog.TabIndex = 0;
            this.lLog.Text = "Log";
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.BackColor = System.Drawing.SystemColors.Window;
            this.tbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbLog.Location = new System.Drawing.Point(3, 30);
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.tbLog.Size = new System.Drawing.Size(722, 96);
            this.tbLog.TabIndex = 2;
            this.tbLog.TabStop = false;
            this.tbLog.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Location = new System.Drawing.Point(3, 63);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.pContainer);
            this.splitContainer1.Panel1.Controls.Add(this.horizontalScroll);
            this.splitContainer1.Panel1.Controls.Add(this.verticalScroll);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.chShowEvents);
            this.splitContainer1.Panel2.Controls.Add(this.bClear);
            this.splitContainer1.Panel2.Controls.Add(this.lLog);
            this.splitContainer1.Panel2.Controls.Add(this.tbLog);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(728, 523);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 2;
            // 
            // chShowEvents
            // 
            this.chShowEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chShowEvents.AutoSize = true;
            this.chShowEvents.Location = new System.Drawing.Point(6, 130);
            this.chShowEvents.Name = "chShowEvents";
            this.chShowEvents.Size = new System.Drawing.Size(96, 19);
            this.chShowEvents.TabIndex = 3;
            this.chShowEvents.Text = "Show Events";
            this.chShowEvents.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.ForeColor = System.Drawing.SystemColors.Control;
            this.bClear.Image = ((System.Drawing.Image)(resources.GetObject("bClear.Image")));
            this.bClear.Location = new System.Drawing.Point(685, 128);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(22, 22);
            this.bClear.TabIndex = 1;
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 612);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Master";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem robotMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripComboBox tscbPortName;
        private System.Windows.Forms.ToolStripMenuItem mConnection;
        private System.Windows.Forms.ToolStripMenuItem miPortNames;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miConnect;
        private System.Windows.Forms.ToolStripMenuItem miDisconnect;
        private System.Windows.Forms.ToolStripButton tsbConnect;
        private System.Windows.Forms.ToolStripButton tsbDisconnect;
        private System.Windows.Forms.ToolStripComboBox tscbRobot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem miRobots;
        private System.Windows.Forms.ToolStripStatusLabel slConnection;
        private System.Windows.Forms.HScrollBar horizontalScroll;
        private System.Windows.Forms.VScrollBar verticalScroll;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Label lLog;
        private System.Windows.Forms.RichTextBox tbLog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.CheckBox chShowEvents;
    }
}

