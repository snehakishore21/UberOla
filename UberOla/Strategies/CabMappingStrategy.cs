using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberOla.Model;

namespace UberOla.Strategies
{
    public interface ICabMappingStrategy
    {
        public abstract Cab MatchCabToRider(Rider rider, List<Cab> candidateCabs, Location fromPoint, Location toPoint);
    }
}
