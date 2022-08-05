using System;

namespace Figures
{
    public class Circle:Figure
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Sides of triangle should be greater than 0 ");
                }
            }
        }
        public override double CalcSquare()
        {
           
            return Radius * Math.PI;
        }
    }
}
