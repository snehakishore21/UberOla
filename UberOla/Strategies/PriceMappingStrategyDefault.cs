using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberOla.Model;

namespace UberOla.Strategies
{
    public class PriceMappingStrategyDefault: IPriceMappingStrategy
    {
        public Double FindPrice(Location fromPoint, Location toPoint)
        {
            return fromPoint.distance(toPoint) * Double.Parse(Resource1.PER_KM_RATE);
        }
    }
}
