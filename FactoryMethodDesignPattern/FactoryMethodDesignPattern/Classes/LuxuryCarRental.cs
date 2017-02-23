using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodDesignPattern.Interfaces;

namespace FactoryMethodDesignPattern.Classes
{
	public class LuxuryCarRental : ICarRental
	{
		public string CarName { get; private set; }

		public LuxuryCarRental()
		{
			CarName = "Luxury Car.";
		}

		public string Name()
		{
			return CarName;
		}
	}
}
