using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    internal class Circle : Shape
    {
        double Radius { get; set; }

        public Circle(string color, double radius)
        {
            this.Name = "Circle";
            this.Color = color;
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
