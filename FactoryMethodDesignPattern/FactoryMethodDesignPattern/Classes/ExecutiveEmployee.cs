using FactoryMethodDesignPattern.Interfaces;

namespace FactoryMethodDesignPattern.Classes
{
	public class ExecutiveEmployee : Employee
	{
		public IAirTicket AirTicket { get; private set; }
		public ICarRental CarRental { get; private set; }

		public ExecutiveEmployee()
		{
			AirTicket = new FirstClassAirTicket();
			CarRental = new LuxuryCarRental();
		}

		public override IAirTicket CreateAirTicket() { return new FirstClassAirTicket(); }
		public override ICarRental CreateCarRental() { return new LuxuryCarRental(); }
	}
}
