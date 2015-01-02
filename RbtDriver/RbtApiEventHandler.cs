using System;

namespace RbtApiDriver
{
    public delegate void RbtApiEventHandler(object sender, RbtApiEventArgs args);

    public class RbtApiEventArgs
    {
        #region Attributes

        private DateTime time = DateTime.Now;
        private RbtApiPacket packet;

        #endregion

        #region Properties

        public DateTime DateTime { get { return this.time; } }
        public RbtApiPacket Packet { get { return this.packet; } }

        #endregion

        public RbtApiEventArgs(RbtApiPacket packet)
        {
            this.packet = packet;
        }
    }
}
