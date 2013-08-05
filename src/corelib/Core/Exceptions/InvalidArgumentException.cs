using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.openstack.Core.Exceptions
{
    public class InvalidArgumentException : Exception
    {
        public InvalidArgumentException() { }
        public InvalidArgumentException(string message) : base(message) { }
    }
}
