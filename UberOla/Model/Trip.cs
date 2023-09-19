using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberOla.Model
{
    public enum TripStatus
    {
        INPROGRESS,
        CANCELLED,
        COMPLETED
    }

    public class Trip
    {
        public string Id { get; private set; }
        public Rider Rider { get; set; }

        public Cab Cab { get; set; }

        public Location From { get; set; }

        public Location To { get; set; }

        public double Price { get; set; }

        public TripStatus TripStatus { get; private set; }

        public int Distance { get; set; }

        public Trip(string id, Rider rider, Cab cab, Location from, Location to, double price)
        {
            this.Id = id;
            this.Rider = rider;
            this.Cab = cab;
            this.From = from;
            this.To = to;
            this.Price = price;
            this.TripStatus = TripStatus.INPROGRESS;
        }

        public void CancelTrip()
        {
            this.TripStatus = TripStatus.CANCELLED;
        }

        public void EndTrip()
        {
            this.TripStatus = TripStatus.COMPLETED;
        }
    }

}
