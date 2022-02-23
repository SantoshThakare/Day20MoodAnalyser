using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyse
{
    public class MoodAnalyserFactory
    { 
        public object CreateMoodAnalyserObject(string className, string constructor)
        {
            
            string p = @"." + constructor + "$";
            Match result = Regex.Match(className, p);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    var res = Activator.CreateInstance(moodAnalyserType);
                    return res;
                }
                catch (Exception)
                {
                    throw new MoodException(MoodException.ExceptionTypes.CLASS_NOT_FOUND, "The Given Class IS Not Found");
                }
            }
            else
            {
                throw new MoodException(MoodException.ExceptionTypes.CONSTRUCTOR_NOT_FOUND, "The Given Constructor Is Not Found");
            }
        }
    }
}
