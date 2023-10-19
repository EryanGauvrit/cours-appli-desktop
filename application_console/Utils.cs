using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public static class Utils
    {
        public static int CalculDistance(RobotsPoint p1, RobotsPoint p2)
        {
            return Math.Abs(p1._positionX - p2._positionX) + Math.Abs(p1._positionY - p2._positionY);
        }


    }
}
