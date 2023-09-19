using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberOla.Exceptions;
using UberOla.Model;
using UberOla.Strategies;

namespace UberOla.Database
{
    public class TripManager
    {
        Dictionary<String, List<Trip>> trips = new();

        public RiderManager riderManager;

        public CabManager cabManager;

        public ICabMappingStrategy cabMappingStrategy;

        public IPriceMappingStrategy priceMappingStrategy;

        public TripManager (RiderManager riderManager, CabManager cabManager, ICabMappingStrategy cabMappingStrategy, IPriceMappingStrategy priceMappingStrategy)
        {
            this.riderManager = riderManager;
            this.cabManager = cabManager;
            this.cabMappingStrategy = cabMappingStrategy;
            this.priceMappingStrategy = priceMappingStrategy;
        }

        public void CreateTrip(Rider rider, Location toPoint, Location fromPoint)
        {
                List<Cab> closeByCabs =
                    cabManager.getCabs(fromPoint,Double.Parse(Resource1.MAX_ALLOWED_TRIP_MATCHING_DISTANCE));
                
                List<Cab> closeByAvailableCabs =
                    closeByCabs;
                    //Select(cab->cab.getCurrentTrip() == null).collect(Collectors.toList());

                Cab selectedCab =
                    cabMappingStrategy.MatchCabToRider(rider, closeByAvailableCabs, fromPoint, toPoint);
                if (selectedCab == null)
                {
                    throw new NoCabsAvailableException();
                }

                Double price = priceMappingStrategy.FindPrice(fromPoint, toPoint);
                Trip newTrip = new Trip(Guid.NewGuid().ToString(), rider, selectedCab, fromPoint, toPoint, price);
                if (!trips.ContainsKey(rider.Id))
                {
                    trips.Add(rider.Id, new ());
                }
                trips[rider.Id].Add(newTrip);
                selectedCab.Trip =newTrip;
       }

        public List<Trip> tripHistory(Rider rider)
        {
            return trips[rider.Id];
        }

        public void EndTrip(Cab cab)
        {
            if (cab.Trip == null)
            {
                throw new TripNotFoundException();
            }
            Trip currTrip = cab.Trip;
            currTrip.EndTrip();
            cab.IsAvailable = true;
        }   
    }
}
