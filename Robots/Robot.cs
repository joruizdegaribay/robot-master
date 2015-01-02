using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RbtApiDriver;

namespace Robots
{
    public enum RobotIds { Sabueso = 24, Pingajo = 80 }
    
    public abstract class Robot
    {
        public const byte NO_DATA_BYTE = 0xFE;
        public const UInt16 NO_DATA_UINT16 = 0xFFFE;

        #region Attributes

        protected RobotIds id;

        #endregion

        #region Propierties

        public RobotIds Id { get { return this.id; } }

        #endregion

        public Robot()
        {
            RbtApi.Connection.EventReceived += Connection_EventReceived;
        }

        void Connection_EventReceived(object sender, RbtApiEventArgs args)
        {
            this.EventReceived((RbtApiEvent)args.Packet);
        }

        public virtual void EventReceived(RbtApiEvent eventResponse)
        {
            throw new RobotException("This methods cannot be called");
        }

        public static Robot GetRobot(RobotIds id)
        {
            Robot robot = null;
            switch (id)
            {
                case RobotIds.Sabueso:
                    robot = new Sabueso.SabuesoRobot();
                    break;
                case RobotIds.Pingajo:
                    robot = new Pingajo.PingajoRobot();
                    break;
            }
            return robot;
        }

        public static bool CheckRobotId(byte id)
        {
            return Enum.IsDefined(typeof(RobotIds), (int)id);
        }

        public static List<RobotIds> GetRobotIds()
        {
            List<RobotIds> robots = new List<RobotIds>();
            foreach (RobotIds robot in Enum.GetValues(typeof(RobotIds)))
                robots.Add(robot);
            robots.Sort();
            return robots;
        }
    }
}
