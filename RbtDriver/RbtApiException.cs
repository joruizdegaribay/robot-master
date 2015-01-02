using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RbtApiDriver
{
    public class RbtApiException : Exception
    {
        public RbtApiException(string message)
            : base(message)
        {
        }
    }
}
