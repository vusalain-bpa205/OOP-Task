using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class Vehicle
    {
        private string model;
        private string brand;
        private int year;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set {  model = value; }
        }
        public int Year
        {
            get { return year;}
            set
            {
                if (value >= 1900)
                    year = value;
                else
                    Console.WriteLine("Year 1900-den kicik ola bilmez");
            }
        }
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public virtual string GetInfo()
        {
            return $"Brand:{Brand},Model:{Model},Year:{Year}";

        }
    }
}
