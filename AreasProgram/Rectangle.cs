using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasProgram
{
    internal class Rectangle
    {
        [TestCase (8,5,40)]
        public void CheckAreaRectangle(double height, double width, double expectedValue)
        {
            Calc c = new Calc();
            double actualValue = c.AreaRectangle(height, width);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestCase (8,5,26)]
        public void CheckPerimeterRectangle(double height, double width, double expectedValue)
        {
            Calc c = new Calc();
            double actualValue = c.PerimeterRectangle(height, width);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
