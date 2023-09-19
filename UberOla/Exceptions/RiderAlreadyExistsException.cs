using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberOla.Exceptions
{
    public class RiderAlreadyExistsException: Exception
    {

        public RiderAlreadyExistsException()
        {
        }

        public RiderAlreadyExistsException(string message)
            : base(message)
        {
        }
    }
}
