using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if(value > 0)
                {
                    a = value;
                }
                else
                {
                    throw new ArgumentException("Sides of triangle should be greater than 0 ");
                }
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    throw new ArgumentException("Sides of triangle should be greater than 0 ");
                }
            }
        }

        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
                else
                {
                    throw new ArgumentException("Sides of triangle should be greater than 0 ");
                }
            }
        }

        public override double CalcSquare()
        {
            
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }


        public bool isRectangular()
        {
            var eps = 0.00000001;
            if (A > B && A > C)
            {
                if(A * A - (B * B + C * C) < eps)
                {
                    return true;
                }
            }
            else if (B > A && B > C)
            {
                if (B * B - (A * A + C * C) < eps)
                {
                    return true;
                }
            }
            else if (C > A && C > B)
            {
                if (C * C -(A * A + B * B) < eps)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
