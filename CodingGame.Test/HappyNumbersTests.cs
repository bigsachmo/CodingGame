using System;
using NUnit.Framework;

namespace CodingGame.Test
{
    [TestFixture]
    public class HappyNumbersTests
    {
        [Test]
        public void ComputeNextNumberOne()
        {
            string s = HappyNumbers.Program.ComputeNextNumber("100");
            Assert.AreEqual("1", s);

            s = HappyNumbers.Program.ComputeNextNumber("23");
            Assert.AreEqual(s, "13");

            s = HappyNumbers.Program.ComputeNextNumber("24");
            Assert.AreEqual(s, "20");
        }


        [Test]
        public void ComputeNextNumberTwo()
        {
            string s = HappyNumbers.Program.ComputeNextNumbersFull("23");
            Assert.AreEqual(s, "1");
        }

    }
}
