namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 1200;
            PrintVehicleDetails(myCar);
            PrintVehicleDetails(myTruck);


            Console.ReadLine();
        }
        private static void PrintVehicleDetails(Vehicle vehicle)
        {
            if (vehicle is Truck)
            {
                Console.WriteLine("Here are the Truck details: {0}", vehicle.FormatMe());
            }
            else if (vehicle is Car)
            {
                Console.WriteLine("Here are the car details: {0}", vehicle.FormatMe());
            }
        }
    }
        abstract class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public string Color { get; set; }
            public abstract string FormatMe();
        }
    class Car : Vehicle
    {
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        }
    }
    class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }
        public override string FormatMe() 
        {
            return String.Format("{0} - {1} - {2} Towing units",
                this.Year,
                this.Make,
                this.TowingCapacity);
        }
    }

}
