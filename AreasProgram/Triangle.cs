using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasProgram
{
    internal class Triangle
    {
        [TestCase(8,8,8,27.71)]
        public void CheckAreaTriangle(double SideA, double SideB, double SideC, double expectedValue)
        {
            Calc c = new Calc();
            double actualValue = Math.Round(c.AreaTriangle(SideA, SideB, SideC), 2);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestCase(10,10,8,28)]
        public void CheckPerimeterTriangle(double SideA, double SideB, double SideC, double expectedValue)
        {
            Calc c = new Calc();
            double actualValue = Math.Round(c.PerimeterTriangle(SideA, SideB, SideC), 2);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
