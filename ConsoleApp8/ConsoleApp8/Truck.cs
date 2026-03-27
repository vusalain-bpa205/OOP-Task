using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class Truck:Vehicle
    {
        private double loadCapacity;
        public double LoadCapacity
        {
            get { return loadCapacity; }
            set {loadCapacity = value;}

    }
        public Truck(string brand,string model,int year,double loadCapacity):base(brand,model,year)
        {
            LoadCapacity = loadCapacity;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $",Load:{LoadCapacity}";
        }



        }
}
