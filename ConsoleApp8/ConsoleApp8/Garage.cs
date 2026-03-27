using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class Garage
    {
        private List <Vehicle> vehicles = new List <Vehicle> ();    
        public void AddVehicle(Vehicle v)
        {
            vehicles.Add (v);
        }
        public void ShowAllVehicles() {
            foreach (var v in vehicles){

                Console.WriteLine(v.GetInfo());
            }
        }
    }
}
