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
            string expectedResult = "0 0 4\r\n2 1 0\r\n";
            Assert.AreEqual(expectedResult , result );
       }

        [Test]
        public void Test15()
        {
            string result = ComputeRugbyScore.ComputeScore(15);
            string expectedResult = "0 0 5\r\n2 1 1\r\n3 0 0\r\n";
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Test21()
        {
            string result = ComputeRugbyScore.ComputeScore(21);
            string expectedResult = "0 0 7\r\n2 1 3\r\n3 0 2\r\n3 3 0\r\n";
            Assert.AreEqual(expectedResult, result);
        }
    }
}