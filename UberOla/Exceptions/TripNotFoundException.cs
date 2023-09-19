using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberOla.Exceptions
{
    public class TripNotFoundException: Exception
    {
        public TripNotFoundException()
        {
        }

        public TripNotFoundException(string message)
            : base(message)
        {
        }
    }
}
