using UberOla.Controller;
using UberOla.Database;
using UberOla.Exceptions;
using UberOla.Strategies;

namespace Declaring_Method
{
    class Program
    {
        static CabsController cabsController;
        static RidersController ridersController;
        static void SetUp()
        {
            CabManager CabManager = new CabManager();
            RiderManager RiderManager = new RiderManager();

            ICabMappingStrategy cabMatchingStrategy = new CabMappingStrategyDefault();
            IPriceMappingStrategy pricingStrategy = new PriceMappingStrategyDefault();

            TripManager tripsManager = new TripManager(RiderManager, CabManager, cabMatchingStrategy, pricingStrategy);

            cabsController = new CabsController(CabManager, tripsManager);
            ridersController = new RidersController(RiderManager, tripsManager);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SetUp();
            testCabBookingFlow();
        }

        static void testCabBookingFlow()
        {

            String r1 = "r1";
            ridersController.registerRider(r1, "ud");
            String r2 = "r2";
            ridersController.registerRider(r2, "du");
            String r3 = "r3";
            ridersController.registerRider(r3, "rider3");
            String r4 = "r4";
            ridersController.registerRider(r4, "rider4");

            String c1 = "c1";
            cabsController.regiserCab(c1, "driver1");
            String c2 = "c2";
            cabsController.regiserCab(c2, "driver2");
            String c3 = "c3";
            cabsController.regiserCab(c3, "driver3");
            String c4 = "c4";
            cabsController.regiserCab(c4, "driver4");
            String c5 = "c5";
            cabsController.regiserCab(c5, "driver5");

            cabsController.updateCabLocation(c1, 1.0, 1.0);
            cabsController.updateCabLocation(c2, 2.0, 2.0); //na
            cabsController.updateCabLocation(c3, 100.0, 100.0);
            cabsController.updateCabLocation(c4, 110.0, 110.0); //na
            cabsController.updateCabLocation(c5, 4.0, 4.0);

            cabsController.updateCabAvailability(c2, false);
            cabsController.updateCabAvailability(c4, false);

            ridersController.book(r1, 0.0, 0.0, 500.0, 500.0);
            ridersController.book(r2, 0.0, 0.0, 500.0, 500.0);

            Console.WriteLine("\n### Printing current trips for r1 and r2");
            Console.WriteLine(ridersController.fetchHistory(r1));
            Console.WriteLine(ridersController.fetchHistory(r2));

            cabsController.updateCabLocation(c5, 50.0, 50.0);

            Console.WriteLine("\n### Printing current trips for r1 and r2");
            Console.WriteLine(ridersController.fetchHistory(r1));
            Console.WriteLine(ridersController.fetchHistory(r2));

            cabsController.endTrip(c5);

            Console.WriteLine("\n### Printing current trips for r1 and r2");
            Console.WriteLine(ridersController.fetchHistory(r1));
            Console.WriteLine(ridersController.fetchHistory(r2));

            ridersController.book(r4, 48.0, 48.0, 500.0, 500.0);

            Console.WriteLine("\n### Printing current trips for r1, r2 and r4");
            Console.WriteLine(ridersController.fetchHistory(r1));
            Console.WriteLine(ridersController.fetchHistory(r2));
            Console.WriteLine(ridersController.fetchHistory(r4));


            //6 Exception scenarios
            ridersController.book(r3, 0.0, 0.0, 500.0, 500.0);

            ridersController.book("abcd", 0.0, 0.0, 500.0, 500.0);

            cabsController.regiserCab("c1", "skjhsfkj");

            cabsController.updateCabLocation("shss", 110.0, 110.0);

            cabsController.updateCabAvailability("shss", false);

            ridersController.registerRider("r1", "shjgf");
        }
    }
}