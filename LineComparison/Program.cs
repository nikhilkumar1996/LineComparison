using System;
namespace LineComparison
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Line Comparison Program");
            Geometry geo = new Geometry(7, 9, 8, 3);
            double a = geo.Coordinates();
            Console.WriteLine("length of line = {0}cm",a);
        }
    }
}

