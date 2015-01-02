using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RbtApiDriver;
using Robots;
using RobotMaster.Forms;

namespace RobotMaster
{
    public partial class MainForm : Form
    {
        #region Attributes

        private Robot presentRobot = null;
        private RobotPanel presentRobotPanel = null;

        #endregion

        public MainForm()
        {
            InitializeComponent();
            RbtApi.Connection.StateChanged += Connection_StateChanged;
            RbtApi.Connection.MessageSended += Connection_MessageSended;
            RbtApi.Connection.MessageReceived += Connection_MessageReceived;
            Robots.Sabueso.SabuesoRobot b = new Robots.Sabueso.SabuesoRobot();
        }

        #region Generic form events

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.loadTscbPortName();
            foreach (Robots.RobotIds r in Robots.Robot.GetRobotIds())
            {
                this.tscbRobot.Items.Add(r);
                ToolStripMenuItem miRobot = new ToolStripMenuItem(r.ToString());
                miRobot.Click += miRobot_Click;
                this.miRobots.DropDownItems.Add(miRobot);
            }
            this.tscbRobot.SelectedIndex = 0;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.presentRobotPanel != null)
                this.presentRobotPanel.Close();
            RbtApi.Connection.Disconnect();
        }

        private void pContainer_Resize(object sender, EventArgs e)
        {
            this.adjustRobotPanel();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            this.tbLog.Text = "";
        }

        #endregion

        #region Main menu events

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mConnection_DropDownOpening(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menuItem in this.miPortNames.DropDownItems)
                menuItem.Click -= miPortName_Click;
            this.miPortNames.DropDownItems.Clear();
            foreach (String portName in RbtApi.GetPortNames())
            {
                ToolStripMenuItem miPortName = new ToolStripMenuItem(portName);
                if (portName == RbtApi.Connection.PortName)
                    miPortName.Checked = true;
                this.miPortNames.DropDownItems.Add(miPortName);
                miPortName.Click += miPortName_Click;
            }
        }

        void miPortName_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem miPortName = (ToolStripMenuItem)sender;
            RbtApi.Connection.PortName = miPortName.Text;
            this.tscbPortName.SelectedItem = miPortName.Text;
        }

        void miRobot_Click(object sender, EventArgs e)
        {
            RobotIds robotId = (RobotIds)Enum.Parse(typeof(RobotIds), ((ToolStripMenuItem)sender).Text);
            this.tscbRobot.SelectedItem = robotId;
        }

        void miConnect_Click(object sender, EventArgs e)
        {
            this.connect();
        }

        private void miDisconnect_Click(object sender, EventArgs e)
        {
            this.disconnect();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        #endregion

        #region Tool bar events

        private void tsbConnect_Click(object sender, EventArgs e)
        {
            this.connect();
        }

        private void tsbDisconnect_Click(object sender, EventArgs e)
        {
            this.disconnect();
        }

        private void tscbPortName_DropDown(object sender, EventArgs e)
        {
            this.loadTscbPortName();
        }

        private void tscbPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            RbtApi.Connection.PortName = this.tscbPortName.SelectedItem.ToString();
        }

        private void tscbRobot_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in this.miRobots.DropDownItems)
                if (item.Text == this.tscbRobot.SelectedItem.ToString())
                    item.Checked = true;
                else
                    item.Checked = false;
        }

        #endregion

        #region Scroll bar Events

        private void verticalScroll_Scroll(object sender, ScrollEventArgs e)
        {
            int yLocation = ((this.pContainer.Height - this.presentRobotPanel.Height) * this.verticalScroll.Value) / this.verticalScroll.Maximum;
            this.presentRobotPanel.Location = new Point(this.presentRobotPanel.Location.X, yLocation);
        }

        private void horizontalScroll_Scroll(object sender, ScrollEventArgs e)
        {
            int xLocation = (this.pContainer.Width - this.presentRobotPanel.Width) * this.horizontalScroll.Value / this.horizontalScroll.Maximum;
            this.presentRobotPanel.Location = new Point(xLocation, this.presentRobotPanel.Location.Y);
        }

        #endregion

        #region Connection events

        void Connection_StateChanged(object sender, EventArgs e)
        {
            if (RbtApi.Connection.Connected)
            {
                this.slConnection.Text = "Connected";
                this.tscbPortName.Enabled = this.miPortNames.Enabled = false;
                this.tsbConnect.Enabled = this.miConnect.Enabled = false;
                this.tsbDisconnect.Enabled = this.miDisconnect.Enabled = true;
                this.tscbRobot.Enabled = false;
                foreach (ToolStripMenuItem miRobot in this.miRobots.DropDownItems)
                    miRobot.Enabled = false;
            }
            else
            {
                this.slConnection.Text = "Disconnected";
                this.tscbPortName.Enabled = this.miPortNames.Enabled = true;
                this.tsbConnect.Enabled = this.miConnect.Enabled = true;
                this.tsbDisconnect.Enabled = this.miDisconnect.Enabled = false;
                this.tscbRobot.Enabled = true;
                foreach (ToolStripMenuItem miRobot in this.miRobots.DropDownItems)
                    miRobot.Enabled = true;
            }
        }

        void Connection_MessageSended(object sender, RbtApiEventArgs args)
        {
            this.BeginInvoke(new RbtApiEventHandler(this.printLog), new object[] { sender, args });
        }

        void Connection_MessageReceived(object sender, RbtApiEventArgs args)
        {
            this.BeginInvoke(new RbtApiEventHandler(this.printLog), new object[] { sender, args });
        }

        #endregion

        #region Private methods

        private void loadTscbPortName()
        {
            this.tscbPortName.Items.Clear();
            foreach (String portName in RbtApi.GetPortNames())
            {
                this.tscbPortName.Items.Add(portName);
                if (RbtApi.Connection.PortName == portName)
                    this.tscbPortName.SelectedItem = portName;
            }
        }

        private void connect()
        {
            byte id;
            try
            {
                id = RbtApi.Connection.Connect();
            }
            catch (RbtApiException e)
            {
                this.disconnect();
                MessageBox.Show(e.Message, "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Robot.CheckRobotId(id))
            {
                this.disconnect();
                MessageBox.Show("Robot id received do not exist", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RobotIds robotId = (RobotIds)id;
            if (robotId != (RobotIds)this.tscbRobot.SelectedItem)
            {
                if (DialogResult.No == MessageBox.Show("Detected robot is different than selected. Do you want to continue with detected robot?\r\n\tRobot selected: " + this.tscbRobot.SelectedItem + "\r\n\tRobot detected: " + robotId, "Connect", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    this.disconnect();
                    return;
                }
                else
                    this.tscbRobot.SelectedItem = robotId;
            }
            this.presentRobot = Robot.GetRobot((RobotIds)id);
            this.presentRobotPanel = RobotPanel.GetRobotPanel(this.presentRobot);
            this.presentRobotPanel.Location = new Point(0, 0);
            this.pContainer.Controls.Add(this.presentRobotPanel);
            this.adjustRobotPanel();
        }

        private void disconnect()
        {
            RbtApi.Connection.Disconnect();
            this.presentRobot = null;
            this.pContainer.Controls.Remove(this.presentRobotPanel);
            this.presentRobotPanel = null;
        }

        private void printLog(object sender, RbtApiEventArgs args)
        {
            if ((args.Packet is RbtApiEvent) && !this.chShowEvents.Checked)
                return;
            if (this.tbLog.Text != "")
                this.tbLog.AppendText("\r\n");
            this.tbLog.AppendText(args.DateTime.Hour.ToString("00") + ":" + args.DateTime.Minute.ToString("00") + ":" + args.DateTime.Second.ToString("00") + "." + args.DateTime.Millisecond.ToString("000"));
            this.tbLog.SelectionFont = new Font(tbLog.Font, FontStyle.Bold);
            if (args.Packet is RbtApiCommand)
                this.tbLog.AppendText(" TX >> ");
            else
                this.tbLog.AppendText(" RX << ");
            this.tbLog.SelectionFont = new Font(tbLog.Font, FontStyle.Regular);
            this.tbLog.AppendText(args.Packet.ToString());
            this.tbLog.ScrollToCaret();
        }

        private void adjustRobotPanel()
        {
            if (this.presentRobotPanel != null)
            {
                int xLocation = 0;
                if (this.pContainer.Width > this.presentRobotPanel.Width)
                {
                    xLocation = (this.pContainer.Width - this.presentRobotPanel.Width) / 2;
                    this.horizontalScroll.Enabled = false;
                }
                else
                {
                    xLocation = (this.pContainer.Width - this.presentRobotPanel.Width) * this.horizontalScroll.Value / this.horizontalScroll.Maximum;
                    this.horizontalScroll.Maximum = ((this.presentRobotPanel.Width - this.pContainer.Width) / 100) + 1;
                    this.horizontalScroll.Enabled = true;
                }
                if (this.pContainer.Height > this.presentRobotPanel.Height)
                    this.verticalScroll.Enabled = false;
                else
                {
                    this.verticalScroll.Maximum = ((this.presentRobotPanel.Height - this.pContainer.Height) / 100) + 1;
                    this.verticalScroll.Enabled = true;
                }
                int yLocation = 0;
                if (this.verticalScroll.Enabled)
                    yLocation = (this.pContainer.Height - this.presentRobotPanel.Height) * this.verticalScroll.Value / this.verticalScroll.Maximum;
                this.presentRobotPanel.Location = new Point(xLocation, yLocation);
            }
        }

        #endregion

    }
}
