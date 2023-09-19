using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberOla.Exceptions;
using UberOla.Model;

namespace UberOla.Database
{
    public class RiderManager
    {
        Dictionary<String, Rider> riders = new ();

        public void createRider(Rider newRider)
        {
            if (riders.ContainsKey(newRider.Id))
            {
                throw new RiderAlreadyExistsException();
            }

            riders.Add(newRider.Id, newRider);
        }

        public Rider getRider(String riderId)
        {
            if (!riders.ContainsKey(riderId))
            {
                throw new RiderNotFoundException();
            }
            return riders[riderId];
        }
    }
}
