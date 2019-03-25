using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculate;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMakeFormula()
        {
            for(int i = 0; i < 100; i++)
            {
                string str=Formula.MakeFormula();
                Console.WriteLine(str);
            }
        }
    }
}
