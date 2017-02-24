using FactoryMethodDesignPattern.Interfaces;

namespace FactoryMethodDesignPattern.Classes
{
	public class OrdinaryEmployee : Employee
	{
		public IAirTicket AirTicket { get; private set; }
		public ICarRental CarRental { get; private set; }

		public OrdinaryEmployee()
		{
			AirTicket = new EconomyClassAirTicket();
			CarRental = new CompactCarRental();
		}

		public override IAirTicket CreateAirTicket() { return new EconomyClassAirTicket(); }
		public override ICarRental CreateCarRental() { return new CompactCarRental(); }
	}
}
