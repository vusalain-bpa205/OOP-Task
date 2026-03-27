using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class Motorcycle:Vehicle
    {
        private string fuelType;
        private int engineSize;
        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }
        public int EngineSize
        {
            get { return engineSize; }
            set {  engineSize = value; }
        }
        public Motorcycle(string brand, string model, int year, string fuelType, int engineSize) : base(brand, model, year)
        {
            FuelType = fuelType;
            EngineSize = engineSize;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $",Fuel:{FuelType},Engine:{EngineSize}";
        }
    }
}
