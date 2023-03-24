using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception2_csharp.Entities.Exceptions
{
    internal class DomainException : Exception
    {
        public DomainException(string message) : base(message) { }
    }
}
