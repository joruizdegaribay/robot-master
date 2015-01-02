using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Robots.Sabueso;

namespace Robots
{
    public partial class RobotPanel : UserControl
    {
        #region Properties

        public virtual Robot Robot { get { throw new RobotException("This property must not me called"); } }

        #endregion

        public RobotPanel()
        {
            InitializeComponent();
        }

        public virtual void Close()
        {
            throw new RobotException("This method cannot be called");
        }

        public static RobotPanel GetRobotPanel(Robot robot)
        {
            RobotPanel robotPanel = null;
            switch (robot.Id)
            {
                case RobotIds.Sabueso:
                    robotPanel = new SabuesoPanel((SabuesoRobot)robot);
                    break;
            }
            return robotPanel;
        }
    }
}
