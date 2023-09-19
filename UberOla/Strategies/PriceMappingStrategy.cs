using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberOla.Model;

namespace UberOla.Strategies
{
    public interface IPriceMappingStrategy
    {
        Double FindPrice(Location fromPoint, Location toPoint);
    }
}
