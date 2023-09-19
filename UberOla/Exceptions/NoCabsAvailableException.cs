using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberOla.Exceptions
{
    public class NoCabsAvailableException : Exception
    {

        public NoCabsAvailableException()
        {
        }

        public NoCabsAvailableException(string message)
            : base(message)
        {
        }
    }
}
