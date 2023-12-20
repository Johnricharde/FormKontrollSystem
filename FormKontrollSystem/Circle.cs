using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    internal class Circle : Shape
    {
        public decimal Radius { get; set; }

        public Circle(string color, decimal radius)
        {
            this.Name = "Circle";
            this.Color = color;
            Radius = radius;
        }

        public override decimal CalculateArea()
        {
            decimal _area = (decimal)(Math.PI * Math.Pow((double)Radius, 2));
            return decimal.Round((decimal)_area, 2);
        }
    }
}
