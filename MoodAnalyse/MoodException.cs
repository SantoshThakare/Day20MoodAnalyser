using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyse
{
    public class MoodException : Exception
    {
            public enum ExceptionTypes
            {
                NULL_MOOD_EXCEPTION,
                EMPTY_MOOD_EXCEPTION
            }
            public ExceptionTypes type;
            public MoodException(ExceptionTypes type, string message) : base(message)
            {
                this.type = type;
            }
        
    }
}
