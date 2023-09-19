using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberOla.Exceptions;
using UberOla.Model;

namespace UberOla.Database
{
    public class CabManager
    {
        Dictionary<String, Cab> cabs = new ();

        public void createCab(Cab newCab)
        {
            if (cabs.ContainsKey(newCab.Id))
            {
                throw new CabAlreadyExistsException();
            }

            cabs.Add(newCab.Id, newCab);
        }

        public Cab getCab(String cabId)
        {
            if (!cabs.ContainsKey(cabId))
            {
                throw new CabNotFoundException();
            }
            return cabs[cabId];
        }

        public void updateCabLocation(String cabId, Location newLocation)
        {
            if (!cabs.ContainsKey(cabId))
            {
                throw new CabNotFoundException();
            }
            cabs[cabId].Location = newLocation;
        }

        public void updateCabAvailability(
            String cabId, Boolean newAvailability)
        {
            if (!cabs.ContainsKey(cabId))
            {
                throw new CabNotFoundException();
            }
            cabs[cabId].IsAvailable = newAvailability;
        }

        public List<Cab> getCabs(Location fromPoint, Double distance)
        {
            List<Cab> result = new ();
            foreach (Cab cab  in cabs.Values)
            {
                // TODO: Use epsilon comparison because of double
                if (cab.IsAvailable && cab.Location.distance(fromPoint) <= distance)
                {
                    result.Add(cab);
                }
            }
            return result;
        }
    }
}
