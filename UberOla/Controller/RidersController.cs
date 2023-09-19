using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberOla.Database;
using UberOla.Model;
using Microsoft.AspNetCore.Mvc;

namespace UberOla.Controller
{
    public class RidersController
    {
        private RiderManager RiderManager;
        private TripManager TripManager;

        public RidersController(RiderManager RiderManager, TripManager TripManager)
        {
            this.RiderManager = RiderManager;
            this.TripManager = TripManager;
        }

        //@RequestMapping(value = "/register/rider", method = RequestMethod.POST)
        public IActionResult registerRider(String riderId, String riderName)
        {
            RiderManager.createRider(new Rider(riderId, riderName));
            OkResult ok = new();
            return ok;
        }

        //@RequestMapping(value = "/book", method = RequestMethod.POST)
        public IActionResult book(
             String riderId,
             Double sourceX,
             Double sourceY,
             Double destX,
             Double destY)
        {
            TripManager.CreateTrip(
                RiderManager.getRider(riderId),
                new Location(sourceX, sourceY),
                new Location(destX, destY));
            OkResult ok = new();
            return ok;
        }

        //@RequestMapping(value = "/book", method = RequestMethod.GET)
        public IActionResult fetchHistory(String riderId)
        {
            List<Trip> trips = TripManager.tripHistory(RiderManager.getRider(riderId));
            OkResult ok = new();

            //update trips here
            return ok;
        }
    }
}
