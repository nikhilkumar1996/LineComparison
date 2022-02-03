using System;
namespace LineComparison
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Line Comparison Program");
            Geometry geo = new Geometry(4, 3, 6, 2);
            double line1 = geo.Coordinates();
            Geometry geo1 = new Geometry(2, 1, 4, 3);
            double line2 = geo1.Coordinates();
            if (line1 == line2)
            {
                Console.WriteLine("Line1 is equal to line2");
                Console.WriteLine("Line1=" + line1 + " " + "Line2=" + line2);
            }
            else
            {
                Console.WriteLine("Lines are different");
            }
        }
    }
}

