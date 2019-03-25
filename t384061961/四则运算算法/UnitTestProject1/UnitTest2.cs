using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculate;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestArithmetic()
        {
            string str1 = "4";
            string str2 = "2";
            string opreator = "+";
            string result = "6";
            Calculate.Calculate calculate = new Calculate.Calculate();
            Assert.AreEqual(calculate.Arithmetic(str1, str2, opreator),result);
        }
    }
}
