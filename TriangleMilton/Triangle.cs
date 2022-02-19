using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleMilton
{
    internal class Triangle
    {
        private double a, b, c;

        public double getA()
        {
            return a;
        }

        public double getB()
        {
            return b;
        }

        public double getC()
        {
            return c;
        }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool isRegular()
        {
            if (a == b && b == c && a == c) // (a == b && a == c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double perimeter()
        {
            return (a + b + c);
        }

        public double area()
        {
            // Herón formula
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s -b) * (s - c);
        }
    }
}
