using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberOla.Model;

namespace UberOla.Strategies
{
    public class CabMappingStrategyDefault: ICabMappingStrategy
    {
        public Cab MatchCabToRider(
      Rider rider,
      List<Cab> candidateCabs,
      Location fromPoint,
      Location toPoint)
        {
            if (!candidateCabs.Any())
            {
                return null;
            }
            return candidateCabs[0];
        }
    }
}
