using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            Point point = new Point(4, 2);
            Point point2 = new Point(5, 5);

            Console.WriteLine(point.DistanceTo(5, 5));
            Console.WriteLine(point.DistanceTo(point2));
        }
    }
}
