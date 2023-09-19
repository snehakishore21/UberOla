using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberOla.Exceptions
{
    public class CabNotFoundException : Exception
    {
        public CabNotFoundException()
        {
        }

        public CabNotFoundException(string message)
            : base(message)
        {
        }

    }
}
