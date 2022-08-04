using System;

namespace Figures
{
    public class Circle:Figure
    {
        public double Radius { get; set; } = 0;

        public override double CalcSquare()
        {
            if (Radius <= 0)
                throw new ArgumentException("Radius should be greater than 0 ");
            return Radius * Math.PI;
        }
    }
}
