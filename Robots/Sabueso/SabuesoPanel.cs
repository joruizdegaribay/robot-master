using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Robots.Peripherals;

namespace Robots.Sabueso
{
    public partial class SabuesoPanel : RobotPanel
    {
        #region Atributes

        private SabuesoRobot robot;
        private List<Panel> pSensors = new List<Panel>();
        private bool sensorChanged = false;
        private bool leftMotorChanged = false;
        private bool rightMotorChanged = false;
        private bool errorChanged = false;
        private Timer tUpdateStatus = new Timer();

        #endregion

        #region Properties

        public override Robot Robot { get { return this.robot; } }

        #endregion

        public SabuesoPanel(SabuesoRobot robot)
        {
            InitializeComponent();
            this.tUpdateStatus.Interval = 50;
            this.tUpdateStatus.Tick += tUpdateStatus_Tick;
            this.robot = robot;
            this.robot.StateChanged += robot_StateChanged;
            this.robot.SensorsChanged += robot_SensorsChanged;
            this.robot.ErrorChanged += robot_ErrorChanged;
            this.robot.LeftMotorChanged += robot_LeftMotorChanged;
            this.robot.RightMotorChanged += robot_RightMotorChanged;
            this.pSensors.Add(this.pSensor0);
            this.pSensors.Add(this.pSensor1);
            this.pSensors.Add(this.pSensor2);
            this.pSensors.Add(this.pSensor3);
            this.pSensors.Add(this.pSensor4);
            this.pSensors.Add(this.pSensor5);
            this.pSensors.Add(this.pSensor6);
            this.pSensors.Add(this.pSensor7);
        }

        #region Public methods

        public override void Close()
        {
            if (this.robot.State == SabuesoState.RUN)
                this.robot.Stop();
        }

        #endregion

        #region Update timer event

        void tUpdateStatus_Tick(object sender, EventArgs e)
        {
            if (this.sensorChanged)
            {
                this.sensorChanged = false;
                this.updateSensors(this.robot.Sensors);
            }
            if (this.rightMotorChanged)
            {
                this.rightMotorChanged = false;
                this.updateRightMotor(this.robot.RightMotor.SpeedWithSign);
            }
            if (this.leftMotorChanged)
            {
                this.leftMotorChanged = false;
                this.updateLeftMotor(this.robot.LeftMotor.SpeedWithSign);
            }
            if (this.errorChanged)
            {
                this.errorChanged = false;
                this.updateError(this.robot.Error);
            }
        }

        #endregion

        #region Form general events

        private void SabuesoPanel_Load(object sender, EventArgs e)
        {
            this.nudSpeed.Value = this.robot.Speed;
            this.nudInterval.Value = this.robot.Interval;
            this.nudKp.Value = this.robot.Kp;
            this.nudKd.Value = this.robot.Kd;
            if (this.robot.State == SabuesoState.RUN)
            {
                this.bState.Text = "STOP";
                this.bState.ForeColor = Color.Red;
                if (this.cbShowStatus.Checked)
                    this.showStatus();
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            this.robot.SetSpeed((UInt16)this.nudSpeed.Value);
            this.robot.SetInterval((byte)this.nudInterval.Value);
            this.robot.SetKp((UInt16)this.nudKp.Value);
            this.robot.SetKd((UInt16)this.nudKd.Value);
        }

        private void bState_Click(object sender, EventArgs e)
        {
            if (this.robot.State != SabuesoState.RUN)
            {
                if (robot.Start())
                {
                    this.bState.Text = "STOP";
                    this.bState.ForeColor = Color.Red;
                    if (this.cbShowStatus.Checked)
                        this.showStatus();
                }
            }
            else
            {
                if (this.robot.Stop())
                {
                    this.bState.Text = "START";
                    this.bState.ForeColor = Color.Green;
                    this.hideStatus();
                }
            }
        }

        private void cbShowStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (this.robot.State == SabuesoState.RUN)
                if (this.cbShowStatus.Checked)
                    this.showStatus();
                else
                    this.hideStatus();
        }

        #endregion

        #region Private methods

        private void hideStatus()
        {
            this.tUpdateStatus.Enabled = false;


            foreach(Panel sensor in this.pSensors)
                sensor.BackColor = Color.Black;
            this.lError.Visible = false;
            this.lLeftSpeedBackward.Visible = false;
            this.lLeftSpeedForward.Visible = false;
            this.pbLeftBackward.Visible = false;
            this.pbLeftForward.Visible = false;
            this.pbLeftHidden.Visible = false;
            this.lRightSpeedBackward.Visible = false;
            this.lRightSpeedForward.Visible = false;
            this.pbRightBackward.Visible = false;
            this.pbRightForward.Visible = false;
            this.pbRightHidden.Visible = false;
        }

        private void showStatus()
        {
            this.tUpdateStatus.Enabled = true;
            this.updateSensors(this.robot.Sensors);
            this.lError.Visible = true;
            this.updateError(this.robot.Error);
            this.updateLeftMotor(this.robot.LeftMotor.SpeedWithSign);
            this.updateRightMotor(this.robot.RightMotor.SpeedWithSign);
        }

        private void updateSensors(Cny70Sensor[] sensors)
        {
            for (int i = 0; i < sensors.Length; i++)
                if (sensors[i].State == Cny70Value.BLACK)
                    this.pSensors[i].BackColor = Color.Black;
                else
                    this.pSensors[i].BackColor = Color.White;
        }

        private void updateError(int error)
        {
            this.lError.Text = error.ToString();
        }

        private void updateLeftMotor(int speed)
        {
            if (speed == 0)
            {
                this.lLeftSpeedBackward.Visible = false;
                this.lLeftSpeedForward.Visible = false;
                this.pbLeftBackward.Visible = false;
                this.pbLeftForward.Visible = false;
                this.pbLeftHidden.Visible = false;
            }
            else if (speed > 0)
            {
                if (!this.lLeftSpeedForward.Visible)
                {
                    this.lLeftSpeedForward.Visible = true;
                    this.pbLeftForward.Visible = true;
                }
                if (this.lLeftSpeedBackward.Visible)
                {
                    this.lLeftSpeedBackward.Visible = false;
                    this.pbLeftBackward.Visible = false;
                    this.pbLeftHidden.Visible = false;
                }
                this.lLeftSpeedForward.Text = this.robot.LeftMotor.Speed.ToString();
                int height = (speed * 50) / 1023;
                this.pbLeftForward.Size = new Size(16, height);
                this.pbLeftForward.Location = new Point(17, 253 - height);
            }
            else
            {
                if (this.lLeftSpeedForward.Visible)
                {
                    this.lLeftSpeedForward.Visible = false;
                    this.pbLeftForward.Visible = false;
                }
                if (!this.lLeftSpeedBackward.Visible)
                {
                    this.lLeftSpeedBackward.Visible = true;
                    this.pbLeftBackward.Visible = true;
                    this.pbLeftHidden.Visible = true;
                }
                this.lLeftSpeedBackward.Text = Math.Abs(speed).ToString();
                int height = (Math.Abs(speed) * 50) / 1023;
                this.pbLeftBackward.Location = new Point(17, 203 + height);
            }
        }

        private void updateRightMotor(int speed)
        {
            if (speed == 0)
            {
                this.lRightSpeedBackward.Visible = false;
                this.lRightSpeedForward.Visible = false;
                this.pbRightBackward.Visible = false;
                this.pbRightForward.Visible = false;
                this.pbRightHidden.Visible = false;
            }
            else if (speed > 0)
            {
                if (!this.lRightSpeedForward.Visible)
                {
                    this.lRightSpeedForward.Visible = true;
                    this.pbRightForward.Visible = true;
                }
                if (this.lRightSpeedBackward.Visible)
                {
                    this.lRightSpeedBackward.Visible = false;
                    this.pbRightBackward.Visible = false;
                    this.pbRightHidden.Visible = false;
                }
                this.lRightSpeedForward.Text = speed.ToString();
                int height = (speed * 50) / 1023;
                this.pbRightForward.Size = new Size(16, height);
                this.pbRightForward.Location = new Point(227, 253 - height);
            }
            else
            {
                if (this.lRightSpeedForward.Visible)
                {
                    this.lRightSpeedForward.Visible = false;
                    this.pbRightForward.Visible = false;
                }
                if (!this.lRightSpeedBackward.Visible)
                {
                    this.lRightSpeedBackward.Visible = true;
                    this.pbRightBackward.Visible = true;
                    this.pbRightHidden.Visible = true;
                }
                this.lRightSpeedBackward.Text = Math.Abs(speed).ToString();
                int height = (Math.Abs(speed) * 50) / 1023;
                this.pbRightBackward.Location = new Point(227, 203 + height);
            }

        }
        #endregion

        #region Robot events

        void robot_StateChanged(object sender, EventArgs e)
        {
            if (this.bState.InvokeRequired)
                this.BeginInvoke(new EventHandler(this.robot_StateChanged), new object[] { sender, e });
            else
                if (this.robot.State == SabuesoState.RUN)
                {
                    this.bState.Text = "STOP";
                    this.bState.ForeColor = Color.Red;
                    if (this.cbShowStatus.Checked)
                        this.showStatus();
                }
                else
                {
                    this.bState.Text = "START";
                    this.bState.ForeColor = Color.Green;
                    this.hideStatus();
                }
        }

        void robot_SensorsChanged(object sender, EventArgs e)
        {
            this.sensorChanged = true;
        }

        void robot_ErrorChanged(object sender, EventArgs e)
        {
            this.errorChanged = true;
        }

        void robot_LeftMotorChanged(object sender, EventArgs e)
        {
            this.leftMotorChanged = true;
        }

        void robot_RightMotorChanged(object sender, EventArgs e)
        {
            this.rightMotorChanged = true;
        }

        #endregion
    }
}
