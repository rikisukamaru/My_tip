using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_tip.Form1;
using System;
using System.Collections.Generic;
using System.Text;

namespace My_tip.Form1.Tests
{
    [TestClass()]
    public class DrobTests
    {
        [TestMethod()]
        public void SummaTest()
        {
            int nu1 = 1;
            int denu1 = 2;
            int nu2 = 1;
            int denu2 = 2;

            Assert.AreEqual(11, 11);
        }

        [TestMethod()]
        public void UmnogTest()
        {
            int nu1 = 2;
            int denu1 = 2;
            int nu2 = 1;
            int denu2 = 2;

            Assert.AreEqual(12, 12);
        }

        [TestMethod()]
        public void DelenTest()
        {
            int nu1 = 2;
            int denu1 = 2;
            int nu2 = 1;
            int denu2 = 2;

            Assert.AreEqual(21, 21);
        }
    }
}