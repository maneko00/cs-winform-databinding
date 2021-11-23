using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonMvvm.Exceptions
{
    public abstract class ExceptionBase : Exception
    {
        protected ExceptionBase(string message) : base(message)
        {
        }

        public abstract MessageKind MessageKind { get; }
    }

    public enum MessageKind
    {
        Info,
        Warning,
        Error,
    }
}
