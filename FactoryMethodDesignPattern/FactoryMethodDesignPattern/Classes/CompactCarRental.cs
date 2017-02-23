
using FactoryMethodDesignPattern.Interfaces;

namespace FactoryMethodDesignPattern.Classes
{
	public class CompactCarRental : ICarRental
	{
		public string CarType { get; private set; }

		public CompactCarRental()
		{
			CarType = "Compact Car.";
		}

		public string Name()
		{
			return CarType;
		}
	}
}
