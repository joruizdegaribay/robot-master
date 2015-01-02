using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Threading;

namespace RbtApiDriver
{
    public class RbtApi
    {
        #region Protocol Constants

        private const char END_COMMAND = '\r';
        private const char COMMAND_SEP = ' ';
        private const char PARAMETER_SEP = ',';

        private const string EVENT_ID = "EVT";

        #endregion

        #region Commands

        private const string ID_CMD = "ID";

        #endregion

        #region Atributos

        private SerialPort comPort = new SerialPort(RbtApiSettings.Default.PortName, 57600);
        private string receiveBuffer = "";
        private ManualResetEvent m_waitResponse;
        private RbtApiResponse m_response;

        #endregion

        #region Properties

        public string PortName
        {
            get { return this.comPort.PortName; }
            set
            {
                if (this.comPort.IsOpen)
                    throw new RbtApiException("Serial Port is open");
                this.comPort.PortName = value;
                RbtApiSettings.Default.PortName = value;
                RbtApiSettings.Default.Save();
            }
        }
        public bool Connected { get { return this.comPort.IsOpen; } }

        #endregion

        #region Events

        public event EventHandler StateChanged;
        public event RbtApiEventHandler EventReceived;
        public event RbtApiEventHandler MessageSended;
        public event RbtApiEventHandler MessageReceived;

        #endregion

        #region Implementación del patrón Singleton

        private static readonly Lazy<RbtApi> instance = new Lazy<RbtApi>(() => new RbtApi());

        private RbtApi()
        {
            this.m_waitResponse = new ManualResetEvent(false);
            this.comPort.DataReceived += comPort_DataReceived;
        }

        public static RbtApi Connection
        {
            get
            {
                return instance.Value;
            }
        }

        #endregion

        #region Com port events

        void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.receiveBuffer += this.comPort.ReadExisting();
            int index;
            do
            {
                index = this.receiveBuffer.IndexOf(END_COMMAND);
                if (index != -1)
                {
                    string message = this.receiveBuffer.Substring(0, index);
                    this.receiveBuffer = this.receiveBuffer.Substring(index + 1);
                    RbtApiEventResponse evtRsp = new RbtApiEventResponse(message);
                    if (evtRsp.Command.Contains(EVENT_ID))
                    {
                        RbtApiEvent ev = new RbtApiEvent(evtRsp.Command, evtRsp.Parameters);
                        if (this.EventReceived != null)
                            this.EventReceived(this, new RbtApiEventArgs(ev));
                        if (this.MessageReceived != null)
                            this.MessageReceived(this, new RbtApiEventArgs(ev));
                    }
                    else
                    {
                        this.m_response = new RbtApiResponse(evtRsp.Command, evtRsp.Parameters);
                        this.m_waitResponse.Set();
                        if (this.MessageReceived != null)
                            this.MessageReceived(this, new RbtApiEventArgs(this.m_response));
                    }
                }
            }
            while (index != -1);
        }

        #endregion

        #region Public methods

        public byte Connect()
        {
            try
            {
                this.comPort.Open();
            }
            catch
            {
                throw new RbtApiException("Cannot open com port selected");
            }
            byte robotId = this.getRobotId();
            if (this.StateChanged != null)
                this.StateChanged(this, new EventArgs());
            return robotId;
        }

        public void Disconnect()
        {
            if (this.comPort.IsOpen)
            {
                this.comPort.Close();
                if (this.StateChanged != null)
                    this.StateChanged(this, new EventArgs());
            }
        }

        #region public static methods

        public static List<string> GetPortNames()
        {
            List<String> portNames = new List<string>();;
            foreach (string portName in SerialPort.GetPortNames())
            {
                string finalName = portName;
                while (!char.IsNumber(finalName[finalName.Length - 1]))
                    finalName = finalName.Substring(0, portName.Length - 1);
                portNames.Add(finalName);
            }
            portNames.Sort();
            return portNames;
        }

        #endregion

        public RbtApiResponse SendMessage(RbtApiCommand command, bool waitReply)
        {
            if (!this.comPort.IsOpen)
                throw new RbtApiException("Com Port is closed");
            // wait for response
            this.m_waitResponse.Reset();
            this.m_response = null;
            //send message
            this.comPort.Write(command.Command);
            if (command.NumberOfParameters > 0)
            {
                this.comPort.Write(COMMAND_SEP.ToString());
                for (int i = 0; i < command.NumberOfParameters; i++)
                {
                    if (i > 0)
                        this.comPort.Write(PARAMETER_SEP.ToString());
                    this.comPort.Write(command.Parameters[i]);
                }
            }
            this.comPort.Write(END_COMMAND.ToString());
            if (this.MessageSended != null)
                this.MessageSended(this, new RbtApiEventArgs(command));

            if (!waitReply)
            return null;
            
            if (!m_waitResponse.WaitOne(500))
                return null;
            
            return m_response;
        }

        #endregion

        #region Private methods

        private byte getRobotId()
        {
            RbtApiEventResponse response = this.SendMessage(new RbtApiCommand(ID_CMD+"?", new string[] { }), true);
            if (response == null)
                throw new RbtApiException("Robot do not response");
            if (response.Command != ID_CMD)
                throw new RbtApiException("Robot response command is unreconizable");
            if (response.NumberOfParameters != 1)
                throw new RbtApiException("Number of parameters are incorrect");
            return Convert.ToByte(response.Parameters[0]);
        }

        #endregion
    }
}
