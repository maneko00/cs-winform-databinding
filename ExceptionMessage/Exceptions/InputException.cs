using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonMvvm.Exceptions
{
    public sealed class InputException : ExceptionBase
    {
        public InputException(string message)  : base(message)
        {
        }

        public override MessageKind MessageKind => MessageKind.Warning;
    }
}
