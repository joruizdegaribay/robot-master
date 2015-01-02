using System;

using RbtApiDriver;
using Robots.Peripherals;

namespace Robots.Sabueso
{
    public enum SabuesoState { NONE = -1, IDLE = 0, WAIT_RUN, RUN }

    public class SabuesoRobot : Robot
    {

        #region Commands


        //commands
        private const string STATE_CMD = "STATE";
        private const string START_CMD = "START";
        private const string STOP_CMD = "STOP";
        private const string SPEED_CMD = "SPEED";
        private const string KP_CMD = "KP";
        private const string KD_CMD = "KD";
        private const string INTERVAL_CMD = "INTERVAL";
        //events
        private const string STATE_EVENT = "STATE_EVT";
        private const string SENSORS_EVENT = "SENSORS_EVT";
        private const string ERROR_EVENT = "ERROR_EVT";
        private const string RIGHT_MOTOR_EVENT = "RIGHT_M_EVT";
        private const string LEFT_MOTOR_EVENT = "LEFT_M_EVT";

        #endregion

        #region Atributos

        private SabuesoState state = SabuesoState.NONE;
        private UInt16 speed = NO_DATA_UINT16;
        private UInt16 kp = NO_DATA_UINT16;
        private UInt16 kd = NO_DATA_UINT16;
        private byte interval = NO_DATA_BYTE;
        private Int16 error = 0;
        private Cny70Sensor[] sensors = new Cny70Sensor[8];
        private Motor leftMotor = new Motor();
        private Motor rightMotor = new Motor();

        #endregion

        #region Propiedades

        public SabuesoState State
        {
            get
            {
                if (this.state == SabuesoState.NONE)
                {
                    RbtApiResponse reply = RbtApi.Connection.SendMessage(new RbtApiCommand(STATE_CMD + "?", new string[] { }), true);
                    if ((reply != null) && (reply.Command == STATE_CMD) && (reply.NumberOfParameters == 1))
                        this.state = (SabuesoState)Convert.ToInt16(reply.Parameters[0]);
                }
                return this.state;
            }
        }
        public UInt16 Speed
        {
            get
            {
                if (this.speed == NO_DATA_UINT16)
                {
                    RbtApiResponse reply = RbtApi.Connection.SendMessage(new RbtApiCommand(SPEED_CMD + "?", new string[] { }), true);
                    if ((reply != null) && (reply.Command == SPEED_CMD) && (reply.NumberOfParameters == 1))
                        this.speed = Convert.ToUInt16(reply.Parameters[0]);
                }
                return this.speed;
            }
        }
        public UInt16 Kp
        {
            get
            {
                if (this.kp == NO_DATA_UINT16)
                {
                    RbtApiResponse reply = RbtApi.Connection.SendMessage(new RbtApiCommand(KP_CMD + "?", new string[] { }), true);
                    if ((reply != null) && (reply.Command == KP_CMD) && (reply.NumberOfParameters == 1))
                        this.kp = Convert.ToUInt16(reply.Parameters[0]);
                }
                return this.kp;
            }
        }
        public UInt16 Kd
        {
            get
            {
                if (this.kd == NO_DATA_UINT16)
                {
                    RbtApiResponse reply = RbtApi.Connection.SendMessage(new RbtApiCommand(KD_CMD + "?", new string[] { }), true);
                    if ((reply != null) && (reply.Command == KD_CMD) && (reply.NumberOfParameters == 1))
                        this.kd = Convert.ToUInt16(reply.Parameters[0]);
                }
                return this.kd;
            }
        }
        public byte Interval
        {
            get
            {
                if (this.interval == NO_DATA_BYTE)
                {
                    RbtApiResponse reply = RbtApi.Connection.SendMessage(new RbtApiCommand(INTERVAL_CMD + "?", new string[] { }), true);
                    if ((reply != null) && (reply.Command == INTERVAL_CMD) && (reply.NumberOfParameters == 1))
                        this.interval = Convert.ToByte(reply.Parameters[0]);
                }
                return this.interval;
            }
        }
        public Int16 Error { get { return this.error; } }
        public Cny70Sensor[] Sensors { get { return this.sensors; } }
        public Motor LeftMotor { get { return this.leftMotor; } }
        public Motor RightMotor { get { return this.rightMotor; } }

        #endregion

        #region Eventos

        public event EventHandler StateChanged;
        public event EventHandler ErrorChanged;
        public event EventHandler SensorsChanged;
        public event EventHandler LeftMotorChanged;
        public event EventHandler RightMotorChanged;

        #endregion

        public SabuesoRobot()
        {
            this.id = RobotIds.Sabueso;
            for (int i = 0; i < 8; i++)
                this.sensors[i] = new Cny70Sensor();
        }

        public bool Start()
        {
            RbtApiResponse reply = RbtApi.Connection.SendMessage(new RbtApiCommand(START_CMD, new string[] { }), true);
            if ((reply != null) && (reply.Command == "OK"))
            {
                this.state = SabuesoState.RUN;
                return true;
            }
            return false;
        }

        public bool Stop()
        {
            RbtApiResponse reply = RbtApi.Connection.SendMessage(new RbtApiCommand(STOP_CMD, new string[] {  }), true);
            if ((reply != null) && (reply.Command == "OK"))
            {
                this.state = SabuesoState.IDLE;
                return true;
            }
            return false;
        }

        public bool SetSpeed(UInt16 speed)
        {
            if (this.speed != speed)
            {
                RbtApiResponse reply = RbtApi.Connection.SendMessage(new RbtApiCommand(SPEED_CMD, new string[] { speed.ToString() }), true);
                if ((reply != null) && (reply.Command == "OK"))
                {
                    this.speed = speed;
                    return true;
                }
            }
            return false;
        }

        public bool SetKp(UInt16 kp)
        {
            if (this.kp != kp)
            {
                RbtApiResponse reply = RbtApi.Connection.SendMessage(new RbtApiCommand(KP_CMD, new string[] { kp.ToString() }), true);
                if ((reply != null) && (reply.Command == "OK"))
                {
                    this.kp = kp;
                    return true;
                }
            }
            return false;
        }

        public bool SetKd(UInt16 kd)
        {
            if (this.kd != kd)
            {
                RbtApiResponse reply = RbtApi.Connection.SendMessage(new RbtApiCommand(KD_CMD, new string[] { kd.ToString() }), true);
                if ((reply != null) && (reply.Command == "OK"))
                {
                    this.kd = kd;
                    return true;
                }
            }
            return false;
        }

        public bool SetInterval(byte interval)
        {
            if (this.interval != interval)
            {
                RbtApiResponse reply = RbtApi.Connection.SendMessage(new RbtApiCommand(INTERVAL_CMD, new string[] { interval.ToString() }), true);
                if ((reply != null) && (reply.Command == "OK"))
                {
                    this.interval = interval;
                    return true;
                }
            }
            return false;
        }

        public override void EventReceived(RbtApiEvent eventResponse)
        {
            switch (eventResponse.Command)
            {
                case STATE_EVENT:
                    if (eventResponse.NumberOfParameters == 1)
                    {
                        int tempState = Convert.ToInt32(eventResponse.Parameters[0]);
                        if ((int)this.state != tempState)
                        {
                            this.state = (SabuesoState)tempState;
                            if (this.StateChanged != null)
                                this.StateChanged(this, new EventArgs());
                        }
                    }
                    break;
                case SENSORS_EVENT:
                    if ((eventResponse.NumberOfParameters == 1) && (eventResponse.Parameters[0].Length == 8))
                    {
                        bool sensorsChanged = false;
                        for (int i = 0; i < 8; i++)
                        {
                            int tempState = Convert.ToInt32(eventResponse.Parameters[0][i]) - 48;
                            if ((int)sensors[i].State != tempState)
                            {
                                sensors[i].UpdateState((Cny70Value)tempState);
                                sensorsChanged = true;
                            }
                        }
                        if ((sensorsChanged) && (this.SensorsChanged != null))
                            this.SensorsChanged(this, new EventArgs());
                    }
                    break;
                case RIGHT_MOTOR_EVENT:
                    if (eventResponse.NumberOfParameters == 1)
                    {
                        int tempSpeed = Convert.ToInt16(eventResponse.Parameters[0]);
                        if (this.rightMotor.SpeedWithSign != tempSpeed)
                        {
                            this.rightMotor.UpdateMotor(tempSpeed);
                            if (this.RightMotorChanged != null)
                                this.RightMotorChanged(this, new EventArgs());
                        }
                    }
                    break;
                case LEFT_MOTOR_EVENT:
                    if (eventResponse.NumberOfParameters == 1)
                    {
                        int tempSpeed = Convert.ToInt16(eventResponse.Parameters[0]);
                        if (this.leftMotor.SpeedWithSign != tempSpeed)
                        {
                            this.leftMotor.UpdateMotor(tempSpeed);
                            if (this.LeftMotorChanged != null)
                                this.LeftMotorChanged(this, new EventArgs());
                        }
                    }
                    break;
                case ERROR_EVENT:
                    if (eventResponse.NumberOfParameters == 1)
                    {
                        Int16 tempError = Convert.ToInt16(eventResponse.Parameters[0]);
                        if (tempError != this.error)
                        {
                            this.error = tempError;
                            if (this.ErrorChanged != null)
                                this.ErrorChanged(this, new EventArgs());
                        }
                    }
                    break;
            }
        }
    }
}