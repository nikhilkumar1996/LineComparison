using System;
namespace LineComparison
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Line Comparison Program");

            Geometry geo = new Geometry(4, 3, 6, 2, "Line1", "Line2");
            geo.Coordinates("Line1", "Line2");
            geo.ComparingLines();

        }
    }
}

