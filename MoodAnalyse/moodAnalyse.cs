using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyse
{
    public class moodAnalyse
    {
      private  string message;
        public moodAnalyse(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        { 
            try
            {

                if (this.message == (null))
                    throw new MoodException(MoodException.ExceptionTypes.NULL_MOOD_EXCEPTION, "Message should not be null");
                else if (this.message.Equals(string.Empty))
                    throw new MoodException(MoodException.ExceptionTypes.EMPTY_MOOD_EXCEPTION, "Message should not be empty");
                else if (message.ToLower().Contains("sad"))
                    return "sad";
                else
                    return "happy";

            }
            catch (MoodException e)

            {
                return e.Message;
            }

        }
    }
}
