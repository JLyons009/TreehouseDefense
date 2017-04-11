using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Invader
    {
        private MapLocation _location;

        public MapLocation GetLocation()
        {
            return _location;
        }

        public void SetLocation(MapLocation location)
        {
            _location = location;
        }
    }
}
