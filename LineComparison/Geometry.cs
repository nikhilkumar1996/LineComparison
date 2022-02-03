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
        public Geometry(int CorX1, int CorY1, int CorX2, int CorY2)
        {
            this.x1 = CorX1;
            this.x2 = CorX2;
            this.y1 = CorY1;
            this.y2 = CorY2;
        }
        public double Coordinates()
        {
            double length = Math.Sqrt(Math.Pow((x1 - x2), 2)) + Math.Sqrt(Math.Pow((y2 - y1), 2));
            return length;
        }
    }

}
