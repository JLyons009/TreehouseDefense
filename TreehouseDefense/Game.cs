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

            MapLocation mapL = new MapLocation(5, 5);

            Console.WriteLine(mapL is Point);
            Console.WriteLine(mapL is MapLocation);
        }
    }
}
