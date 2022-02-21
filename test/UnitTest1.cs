using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyse;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [TestCategory("SAD Message")]
        public void GivenSadMoodShouldReturnSAD()
        {
            string expected = "sad";
            string message = "I am in Sad Mood";
            moodAnalyse mood = new moodAnalyse(message);


            string moodAnalyse = mood.AnalyseMood();

            Assert.AreEqual(expected.ToLower(), moodAnalyse.ToLower());
        }
       
    }
}
