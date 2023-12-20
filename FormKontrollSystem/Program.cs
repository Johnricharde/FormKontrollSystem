namespace FormKontrollSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myShapes = new List<Shape>();

            myShapes.Add(new Circle("Yellow", 2));
            myShapes.Add(new Circle("Blue", 4));

            myShapes.Add(new Rectangle("Green", 2, 3));
            myShapes.Add(new Rectangle("Orange", 3, 2));

            myShapes.Add(new Triangle("Purple", 2, 3));
            myShapes.Add(new Triangle("Pink", 3, 2));





            ShowList(SortListBy(myShapes, shape => shape.Color));






            void ShowList(List<Shape> shapes)
            {
                foreach (var shape in shapes)
                {
                    Console.WriteLine($"Name:  {shape.Name}");
                    Console.WriteLine($"Color: {shape.Color}");
                    Console.WriteLine($"Area:  {shape.CalculateArea():F2}");
                    Console.WriteLine();
                }
            }

            void TotalArea(List<Shape> shapeList)
            {
                decimal totalArea = 0;
                foreach (var shape in shapeList)
                {
                    totalArea += shape.CalculateArea();
                }
                Console.WriteLine($"Total Area: {totalArea}");
            }

            List<Shape> SortListBy(List<Shape> shapeList, Func<Shape, IComparable> keySelector)
            {
                List<Shape> sortedShapes = shapeList.OrderBy(keySelector).ToList();
                return sortedShapes;
            }
        }
    }
}
