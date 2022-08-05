using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figure
    {
        public double A { get; set; } = 0;
        public double B { get; set; } = 0;
        public double C { get; set; } = 0;

        public override double CalcSquare()
        {
            if ( A <= 0 || B <= 0 || C <= 0)
            {
                throw new ArgumentException("Sides of triangle should be greater than 0 ");
            }
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }


        public bool isRectangular()
        {
            if(A > B && A > C)
            {
                if(A * A == B * B + C * C)
                {
                    return true;
                }
            }
            else if (B > A && B > C)
            {
                if (B * B == A * A + C * C)
                {
                    return true;
                }
            }
            else if (C > A && C > B)
            {
                if (C * C == A * A + B * B)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
