using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectsConstructor
{
	internal class Motorcycle
	{
		public string Brend;
		public string Model;
		public int Year;
		public int MaxSpeed;
		public bool HasSidecar;
        public Motorcycle(int maxspeed)
        {
			MaxSpeed = maxspeed;
        }
    }
}
