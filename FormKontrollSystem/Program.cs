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

            foreach (var shape in myShapes)
            {
                Console.WriteLine($"Name:  {shape.Name}");
                Console.WriteLine($"Color: {shape.Color}");
                Console.WriteLine($"Area:  {shape.CalculateArea()}");
                Console.WriteLine();
            }
        }
    }
}
