using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class RobotException:Exception
    {
        public RobotException(string message)
            : base(message)
        {
        }
    }
}
