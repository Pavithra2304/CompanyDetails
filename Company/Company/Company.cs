using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
	class Company
	{
		string name;
		string sector;
		string location;
		int age;

		public Company(string name, string sector, string location, int age)
		{
			Name = name;
			Sector = sector;
			Location = location;
			Age = age;
		}

		public string Name { get => name; set => name = value; }
		public string Sector { get => sector; set => sector = value; }
		public string Location { get => location; set => location = value; }
		public int Age { get => age; set => age = value; }

		public override string ToString()
		{
			return string.Format("Name : {0}\nSector : {1}\nLocation : {2}\nAge: {3}", Name, Sector, Location, Age);
		}
		public override bool Equals(object obj)
		{
			Company c1 = (Company)obj;
			return this.Name.Equals(c1.Name) && this.Location.Equals(c1.Location);
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
