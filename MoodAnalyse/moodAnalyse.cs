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
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
                
            }
            else
            {
                return "sad";

            }
        }
    }
}
