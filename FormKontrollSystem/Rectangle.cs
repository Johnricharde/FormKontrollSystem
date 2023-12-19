using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    internal class Rectangle : Shape
    {
        double Length {  get; set; }
        double Width {  get; set; }

        public Rectangle(string color, double length, double width)
        {
            this.Name = "Rectangle";
            this.Color = color;
            Length = length;
            Width = width;  
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}
