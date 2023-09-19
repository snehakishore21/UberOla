using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberOla.Model
{
    public class Cab
    {
        public string Id { get; private set; }

        public string DriverName { get; private set; }

        public double DriverRating { get; private set; }

        public Trip Trip { get; set; }

        public Location Location { get; set; }

        public bool IsAvailable { get; set; }

        public Cab (string id, string driver, double driverRating = 5)
        {
            this.Id = id;
            this.DriverName = driver;
            this.IsAvailable = true;
            this.DriverRating = driverRating;
        }

        public String toString()
        {
            return "Cab{" +
                "id='" + Id + '\'' +
                ", driverName='" + DriverName + '\'' +
                ", currentLocation=" + Location +
                ", isAvailable=" + IsAvailable +
                '}';
        }
    }
}
