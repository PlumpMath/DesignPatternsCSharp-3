using FactoryMethodDesignPattern.Interfaces;

namespace FactoryMethodDesignPattern.Classes
{
	public class EconomyClassAirTicket : IAirTicket
	{
		public string TicketType { get; private set; }

		public EconomyClassAirTicket()
		{
			TicketType = "Economy Class.";
		}

		public string Name()
		{
			return TicketType;
		}
	}
}
