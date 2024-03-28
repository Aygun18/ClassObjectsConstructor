using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectsConstructor
{
	internal class User
	{
		public string Name;
		public string Surname;
		public byte Age;
		public string Email; 
		public string Password;
        public User(string name,string password)
        {
           Name = name;
		   Password = password;
        }
        public bool IsPasswordValid()
		{
			if (Password.Length < 6)
			{
				return false;
			}
			if (Password.ToLower().Contains(Name.ToLower()))
			{
				return false;
			}
			foreach (char c in Password)
			{
				if (char.IsDigit(c))
				{

					return true;
					
				}
			}
		   return false;
		}
	}
}
