using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasProgram
{
    internal class Calc
    {
        double pi = Math.PI;
        public double AreaCircle(double radius)
        {
            return pi * (radius * radius);
        }
        public double PerimeterCircle (double radius)
        {
            return 2 * pi * radius;
        }
        public double AreaRectangle (double height, double width)
        {
            return height * width;
        }
        public double PerimeterRectangle (double height, double width)
        {
            return (2 * height) + (2 * width);
        }
        public double AreaTriangle (double SideA, double SideB, double SideC)
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s-SideA) * (s-SideB) * (s-SideC));
        }
        public double PerimeterTriangle(double SideA, double SideB, double SideC)
        {
            double s = SideA + SideB + SideC;
            return s;
            
        }
    }
}
