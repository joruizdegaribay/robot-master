using System;

namespace Robots.Peripherals
{
    public enum Direction { FORWARD = 0, BACKWARD = 1 }

    public class Motor
    {
        #region Atributos

        private Direction direction = Direction.FORWARD;
        private UInt16 speed = 0;

        #endregion

        #region Properties

        public Direction Direction { get { return this.direction; } }
        public UInt16 Speed { get { return this.speed; } }
        public int SpeedWithSign
        {
            get
            {
                if (this.direction == Direction.BACKWARD)
                    return -this.speed;
                else
                    return this.speed;
            }
        }

        #endregion

        public Motor()
        {
        }

        public void UpdateMotor(int speed)
        {
            if (speed < 0)
                this.direction = Direction.BACKWARD;
            else
                this.direction = Direction.FORWARD;
            this.speed = (UInt16)Math.Abs(speed);
        }

        public void UpdateMotor(Direction direction, UInt16 speed)
        {
            this.direction = direction;
            this.speed = speed;
        }
    }
}
