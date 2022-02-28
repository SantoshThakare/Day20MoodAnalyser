using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyse;
using System;

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
        [TestCategory("Reflection")]

        [DataRow("MoodAnalyserProblems.Customer", "Customer")]
        [DataRow("MoodAnalyserProblems.MoodAnalyser", "MoodAnalyser")]
        public void ReturnDefaultConstructor(string className, string constructor)
        {
            moodAnalyse expected = new moodAnalyse();
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserObject(className, constructor);

            }
            catch (MoodException ex)
            {
                throw new Exception(ex.Message);
            }
            expected.Equals(obj);
        }

        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("MoodAnalyserProblems.Linklist", "Linklist", "The Given Class IS Not Found")]
        [DataRow("MoodAnalyserProblems.Stack", "Stack", "The Given Class IS Not Found")]
        public void ReturnDefaultConstructorNoClassFound(string className, string constructor, string expected)
        {
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserObject(className, constructor);

            }
            catch (MoodException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("MoodAnalyserProblems.MoodAnalyser", "Linklist", "The Given Constructor Is Not Found")]
        [DataRow("MoodAnalyserProblems.MoodAnalyser", "Customer", "The Given Constructor Is Not Found")]
        public void ReturnDefaultConstructorNoConstructorFound(string className, string constructor, string expected)
        {
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserObject(className, constructor);

            }
            catch (MoodException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("I am in happy mood")]
        [DataRow("I am in sad mood")]
        [DataRow("I am in any mood")]
        public void GivenMessageReturenParameterizedConstuctor(string message)
        {
            moodAnalyse expected = new moodAnalyse(message);
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserParameterizedObject("moodAnalyse", "moodAnalyse", message);
            }
            catch (MoodException actual)
            {

                Assert.AreEqual(expected, actual.Message);
                obj.Equals(expected);
            }

        }
        
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("MoodAnalyse.Queues", "I am in Happy mood", "No Such Class")]
        [DataRow("MoodAnalyse.Linkedlist", "I am in Sad mood", "No Such Class")]
        [DataRow("MoodAnalyse.Stack", "I am in any mood", "No Such Class")]
        public void GivenMessageReturnParameterizedClassNotFound(string className, string message, string expextedError)
        {
            moodAnalyse expected = new moodAnalyse(message);
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserParameterizedObject(className, "MoodAnalyse", message);

            }
            catch (MoodException actual)
            {
                Assert.AreEqual(expextedError, actual.Message);
            }
        }

    
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("Customer", "I am in Happy mood", "No Such Constructor")]
        [DataRow("Linkedlist", "I am in Sad mood", "No Such Constructor")]
        [DataRow("Stack", "I am in any mood", "No Such Constructor")]
        public void GivenMessageReturnParameterizedConstructorNotFound(string constructor, string message, string expextedError)
        {
            moodAnalyse expected = new moodAnalyse(message);
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserParameterizedObject("moodAnalyse", constructor, message);

            }
            catch (MoodException Actual)
            {
                Assert.AreEqual(expextedError , Actual.Message);
                
            }
        }
    }
}
