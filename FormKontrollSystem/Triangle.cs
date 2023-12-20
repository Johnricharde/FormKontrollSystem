using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    internal class Triangle : Shape
    {
        decimal BaseLength {  get; set; }
        decimal Height {  get; set; }

        public Triangle(string color, decimal baseLength, decimal height)
        {
            this.Name = "Triangle";
            this.Color = color;
            BaseLength = baseLength;
            Height = height;
        }

        public override decimal CalculateArea()
        {
            return (decimal)0.5 * BaseLength * Height;
        }
    }
}
