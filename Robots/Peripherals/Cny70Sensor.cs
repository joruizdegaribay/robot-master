using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.Peripherals
{
    public enum Cny70Value { WHITE = 0, BLACK = 1 }

    public class Cny70Sensor
    {
        #region Atributes

        private Cny70Value state = Cny70Value.WHITE;

        #endregion

        #region Properties

        public Cny70Value State { get { return this.state; } }

        #endregion

        public Cny70Sensor()
        {
        }

        public void UpdateState(Cny70Value state)
        {
            this.state = state;
        }
    }
}
