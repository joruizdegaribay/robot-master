using System;
using System.Collections.Generic;

namespace RbtApiDriver
{
    public class RbtApiPacket
    {
        #region Attributes

        protected string command;
        protected List<String> parameters = new List<string>();

        #endregion

        #region Properties

        public string Command { get { return this.command; } }
        public int NumberOfParameters { get { return this.parameters.Count; } }
        public String[] Parameters
        {
            get
            {
                string[] parameters = new string[this.parameters.Count];
                for (int i = 0; i < this.parameters.Count; i++)
                    parameters[i] = this.parameters[i];
                return parameters;
            }
        }

        #endregion

        public RbtApiPacket()
        {
        }

        public RbtApiPacket(string command, string[] parameters)
        {
            this.command = command;
            this.parameters.AddRange(parameters);
        }

        public RbtApiPacket(string message)
        {
            int index = message.IndexOf(' ');
            if (index == -1)
                this.command = message;
            else
            {
                this.command = message.Substring(0, index);
                String parameters = message.Substring(index + 1);
                do
                {
                    index = parameters.IndexOf(',');
                    if (index != -1)
                    {
                        this.parameters.Add(parameters.Substring(0, index));
                        parameters = parameters.Substring(index + 1);
                    }
                }
                while (index != -1);
                this.parameters.Add(parameters);
            }
        }

        public override string ToString()
        {
            string message = this.command;
            if (this.parameters.Count > 0)
            {
                message += " ";
                for (int i = 0; i < this.parameters.Count; i++)
                {
                    if (i > 0)
                        message += ",";
                    message += this.parameters[i];
                }
            }
            return message;
        }
    }

    public class RbtApiCommand : RbtApiPacket
    {
        public RbtApiCommand(string command, string[] parameters)
            : base(command, parameters)
        { }
    }

    public class RbtApiEventResponse : RbtApiPacket
    {
        public RbtApiEventResponse()
        {
        }

        public RbtApiEventResponse(string message)
            : base(message)
        {
        }

        public RbtApiEventResponse(string command, string[] parameters)
            : base(command, parameters)
        {
        }
    }

    public class RbtApiEvent : RbtApiEventResponse
    {
        public RbtApiEvent(string command, string[] parameters)
            : base(command, parameters)
        {
        }
    }

    public class RbtApiResponse : RbtApiEventResponse
    {
        public RbtApiResponse(string command, string[] parameters)
            : base(command, parameters)
        {
        }
    }
}