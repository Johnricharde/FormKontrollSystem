using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    internal class Rectangle : Shape
    {
        decimal Length {  get; set; }
        decimal Width {  get; set; }

        public Rectangle(string color, decimal length, decimal width)
        {
            this.Name = "Rectangle";
            this.Color = color;
            Length = length;
            Width = width;  
        }

        public override decimal CalculateArea()
        {
            return Length * Width;
        }
    }
}
