using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Inheritance
{
    public class AgeException : Exception
    {
        public AgeException() : base() { }
        public AgeException(string message) : base(message) { }
        public AgeException(string message, Exception e) : base(message, e) { }
    }
}
