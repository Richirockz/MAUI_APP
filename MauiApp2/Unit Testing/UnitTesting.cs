using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Java.Lang;

namespace MauiApp2.Unit_Testing
{
    public class UnitTesting
    {
        [Fact]
        public void PassingTest()
        {
            AssertionError.AreEqual(4, 2 + 2);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.AreEqual(5, 2 + 2);
        }
    }
}
