using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_testing.Tests
{
    [TestClass()]
    public class SampleTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Sample s1 = new Sample();
            int res = s1.Add(10, 20);
            Assert.AreEqual(30, res);
        }
        [TestMethod()]
        public void SubTest()
        {
            Sample s1 = new Sample();
            int res = s1.Subtract(20, 10);
            Assert.AreEqual(10, res);
        }

        [TestMethod()]
        public void GetDataTest()
        {
            Sample s1 = new Sample();
            int res = s1.GetData(-10);

        }
    }

}