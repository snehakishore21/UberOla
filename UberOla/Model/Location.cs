using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberOla.Model
{
    public class Location
    {
        private Double x;
        private Double y;

        public Double distance(Location location2)
        {
            return Math.Sqrt(Math.Pow(this.x - location2.x, 2) + Math.Pow(this.y - location2.y, 2));
        }

        public Location(Double x, Double y) { this.x = x; this.y = y;}
    }
}
