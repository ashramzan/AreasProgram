using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AreasProgram
{
    internal class Circle
    {
        double pi = Math.PI;
        [TestCase (5, 78.54)]
        public void CheckCircleArea (double input, double expectedValue)
        {
            Calc c = new Calc ();
            double radius = (input);
            double actualValue = Math.Round(c.AreaCircle(radius), 2);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestCase (5, 31.42)]
        public void CheckPerimeterCircle(double input, double expectedValue)
        {
            Calc c = new Calc();
            double radius = (input);
            double actualValue = Math.Round(c.PerimeterCircle(radius), 2);
            Assert.AreEqual (expectedValue, actualValue);
        }
    }
}
