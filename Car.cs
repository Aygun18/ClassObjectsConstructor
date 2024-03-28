using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectsConstructor
{
	internal class Car
	{
		public string Brend;
		public string Model;
		public int Year;
		public string FuelType;
		public string Color;
        public Car(string brend,string model,int year,string fueltype,string color)
        {
			Brend = brend;
			Model = model;
			Year = year;
			FuelType = fueltype;
			Color = color;
        }
		public void PrintInfo()
		{
			Console.WriteLine($"{Brend},{Model},{Year},{FuelType},{Color}");
		}
    }
}
