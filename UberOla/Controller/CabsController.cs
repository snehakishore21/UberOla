using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberOla.Database;
using UberOla.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace UberOla.Controller
{
    public class CabsController
    {
        private CabManager CabManager;
        private TripManager TripManager;

        public CabsController(CabManager CabManager, TripManager TripManager)
        {
            this.CabManager = CabManager;
            this.TripManager = TripManager;
        }

        //@RequestMapping(value = "/register/cab", method = RequestMethod.POST)
        public IActionResult regiserCab(String cabId, String driverName)
        {
            CabManager.createCab(new Cab(cabId, driverName));
            OkResult ok = new();
            return ok;
        }

        //@RequestMapping(value = "/update/cab/location", method = RequestMethod.POST)
        public IActionResult updateCabLocation(
             String cabId, Double newX, Double newY)
        {

            CabManager.updateCabLocation(cabId, new Location(newX, newY));
            OkResult ok = new();
            return ok;
        }

        //@RequestMapping(value = "/update/cab/availability", method = RequestMethod.POST)
        public IActionResult updateCabAvailability(String cabId, Boolean newAvailability)
        {
            CabManager.updateCabAvailability(cabId, newAvailability);
            OkResult ok = new();
            return ok;
        }

        //@RequestMapping(value = "/update/cab/end/trip", method = RequestMethod.POST)
        public IActionResult endTrip(String cabId)
        {
            TripManager.EndTrip(CabManager.getCab(cabId));
            OkResult ok = new();
            return ok;
        }
    }
}
