

using ConsoleApp8;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();

            Car car = new Car("BMW", 4, "Petrol", "X5", 2020);
            Motorcycle motorcycle = new Motorcycle("Yamaha", "R6", 2018, "Petrol", 600);
            Truck truck = new Truck("Volvo", "FH", 2015, 20);
            garage.AddVehicle(car);
            garage.AddVehicle(motorcycle);
            garage.AddVehicle(truck);
            garage.ShowAllVehicles();

        }
    }
}