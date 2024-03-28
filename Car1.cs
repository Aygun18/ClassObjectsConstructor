using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectsConstructor
{
	internal class Car1
	{
		public string Brend;
		public string Model;
		public int Year;
		public int MaxSpeed;
		public int NumSeats;
        public Car1(int maxspeed)
        {
			MaxSpeed = maxspeed;
        }

    }
}
