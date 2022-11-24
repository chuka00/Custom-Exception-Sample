using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_exceptions
{
    public class TutlaneCustomException : Exception
    {
        public TutlaneCustomException()
        {
        }
        public TutlaneCustomException(string message) : base(message)
        {
        }
        public TutlaneCustomException(string message, Exception innerexception) : base(message, innerexception)
        {
        }
    }
}
