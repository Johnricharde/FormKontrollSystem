using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    internal class Triangle : Shape
    {
        double BaseLength {  get; set; }
        double Height {  get; set; }

        public Triangle(string color, double baseLength, double height)
        {
            this.Name = "Triangle";
            this.Color = color;
            BaseLength = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * BaseLength * Height;
        }
    }
}
