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
        [TestMethod]
        [TestCategory("HAPPY Message")]

        public void GivenHappyMoodShouldReturnHAPPY()
        {
            string expected = "happy";
            string message = "I am in Happy Mood";
            moodAnalyse mood = new moodAnalyse(message);
            string moodAnalyse = mood.AnalyseMood();

            Assert.AreEqual(expected.ToLower(), moodAnalyse.ToLower());

        }
        [TestMethod]

        [TestCategory("Null Exception")]
        public void GivenNullMessageException()
        {

            string msg = null;
            string expected = "happy";

            moodAnalyse mood = new moodAnalyse("I am in Happy Mood");
            string moodAnalyse = mood.AnalyseMood();

            Assert.AreEqual(expected.ToLower(), moodAnalyse.ToLower());

        }
        [TestMethod]
        [TestCategory("Custom Exception")]
        
        public void TestCustomNullException()
        {
            
            string msg = null;
            string expected = "message should not be null";
            moodAnalyse mood = new moodAnalyse(msg);


            string moodAnalyse = mood.AnalyseMood();
           
                Assert.AreEqual(expected.ToLower(), moodAnalyse.ToLower());

        }
        [TestMethod]
        [TestCategory("Custom Exception")]       
        public void TestCustomEmptyException()
        {
            
            string msg = "";
            string expected = "message should not be empty";
            moodAnalyse mood = new moodAnalyse(msg);
            
            string moodAnalyse = mood.AnalyseMood();
            
               
                Assert.AreEqual(expected.ToLower(), moodAnalyse.ToLower());
            
        }
    }
}
