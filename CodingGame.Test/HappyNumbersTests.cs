using System;
using NUnit.Framework;

namespace CodingGame.Test
{
    [TestFixture]
    public class HappyNumbersTests
    {
        [Test]
        public void ComputeNextNumber0()
        {
            string s = HappyNumbers.Program.ComputeNextNumber("100");
            Assert.AreEqual("1", s);

            s = HappyNumbers.Program.ComputeNextNumber("23");
            Assert.AreEqual(s, "13");

            s = HappyNumbers.Program.ComputeNextNumber("24");
            Assert.AreEqual(s, "20");
        }


        [Test]
        public void ComputeNextNumber1()
        {
            string s = HappyNumbers.Program.ComputeNextNumbersFull("23");
            Assert.AreEqual(s, "1");
        }

        [Test]
        public void ComputeNextNumber2()
        {
            string s = HappyNumbers.Program.ComputeNextNumbersFull("24");
            Assert.AreNotEqual(s, "1");

        }

        [Test]
        public void ComputeNextNumber3()
        {
            string s = HappyNumbers.Program.ComputeNextNumbersFull("761");
            Assert.AreEqual(s, "1");

        }

        [Test]
        public void ComputeNextNumber4()
        {
            string s = HappyNumbers.Program.ComputeNextNumbersFull("16525534153749833");
            Assert.AreEqual(s, "1");

        }

        [Test]
        public void ComputeNextNumber5()
        {
            string s = HappyNumbers.Program.ComputeNextNumbersFull("697719833245520439");
            Assert.AreNotEqual(s, "1");

        }

    }
}
