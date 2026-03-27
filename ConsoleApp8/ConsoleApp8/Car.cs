using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class Car:Vehicle
    {
        private string fuelType;
        private int doorCount;
        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }
        public int DoorCount
        {
            get { return doorCount; }
            set {  doorCount = value; }
        }
        public Car(string fuelType, int doorCount, string brand, string model, int year) : base(brand, model, year)
        {
            FuelType = fuelType;
            DoorCount = doorCount;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $",Fuel:{FuelType},Doors:{DoorCount}";
        }
    }
}
