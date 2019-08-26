using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;
using NoSpoonEp1;

namespace CodingGame.Test
{
    [TestFixture]
    public class NoSpoonTests
    {
        [Test]
        public void Test1_BuildGrid()
        {
            try
            {
                Program.Y = 2;
                Program.X = 2;
                Program.Grid = new char[Program.Y, Program.X];
                Program.FillGridWithLine("0.", 0);
                Program.FillGridWithLine("00", 1);
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Assert.Fail();
            }

        }

        [Test]
        public void Test2_SampleOutput()
        {
            Program.Y = 1;
            Program.X = 1;
            Program.Grid = new char[Program.Y, Program.X];
            Program.FillGridWithLine("0", 0);
            Program.WalkTheGrid();
            Assert.AreEqual("0 0 -1 -1 -1 -1\r\n", Program.OutPut.ToString()) ;
        }

        [Test]
        public void Test3_x2y2()
        {
            Program.Y = 2;
            Program.X = 2;
            Program.Grid = new char[Program.X, Program.Y ];
            Program.FillGridWithLine("00", 0);
            Program.FillGridWithLine("0.", 1);
            Program.WalkTheGrid();
            Assert.AreEqual("0 0 1 0 0 1\r\n0 1 -1 -1 -1 -1\r\n1 0 -1 -1 -1 -1\r\n", Program.OutPut.ToString());
        }

        [Test]
        public void Test4_Horizontal()
        {
            Program.X = 5;
            Program.Y = 1;
            Program.Grid = new char[Program.X,Program.Y ];
            Program.FillGridWithLine("000.0", 0);
            Program.WalkTheGrid();
            Assert.AreEqual("0 0 1 0 -1 -1\r\n1 0 2 0 -1 -1\r\n2 0 4 0 -1 -1\r\n4 0 -1 -1 -1 -1\r\n", Program.OutPut.ToString());
        }
    }
}
