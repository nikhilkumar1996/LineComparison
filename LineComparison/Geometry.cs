using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class Geometry
    {
        int x1, y1, x2, y2;
        string line1, line2;
        public Geometry(int CorX1, int CorX2, int CorY1, int CorY2, string line1, string line2)
        {
            this.x1 = CorX1;
            this.x2 = CorX2;
            this.y1 = CorY1;
            this.y2 = CorY2;
            this.line1 = line1;
            this.line2 = line2;
        }
        public double Coordinates(string line1, string line2)
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2)) + Math.Sqrt(Math.Pow((y2 - y1), 2));
            return length;


        }

        public void ComparingLines()
        {
            if (line1 == line2)
            {
                Console.WriteLine(" Line1 is equal to line2 ");

            }
            if (line1.CompareTo(line2) > 0)
            {

                Console.WriteLine("Line1 is greater than line2");

            }
            else
            {
                Console.WriteLine("Line1 is less than line2");

            }

        }
    }
}