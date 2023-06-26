using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAgeException
{
    public class PersonAgeCustomeException : Exception
    {
        public enum ExceptionType
        {
            NullMessage,
            EmptyMessage,
            InvalidMessage
        }

        private readonly ExceptionType type;

        public PersonAgeCustomeException(ExceptionType type,string message) : base(message)
        {
            this.type = type;
        }
    }
}
