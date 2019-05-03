using System;
using NUnit.Framework;
using RugbyScore;



namespace RugbyScoreUT
{
    [TestFixture]
    public class RugbyScoreTest
    {
       [Test]
       public void Test12() 
       {
            string result = ComputeRugbyScore.ComputeScore(12);
            string expectedResult = @"0 0 4" + System.Environment.NewLine + "2 1 0";
            Assert.AreEqual(result, expectedResult);
       }
    }
}