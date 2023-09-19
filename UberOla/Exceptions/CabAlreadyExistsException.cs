using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UberOla.Model;

namespace UberOla.Exceptions
{
    public class CabAlreadyExistsException : Exception
    {
        public CabAlreadyExistsException()
        {
        }

        public CabAlreadyExistsException(string message)
            : base(message)
        {
        }

        public CabAlreadyExistsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
