using FactoryMethodDesignPattern.Interfaces;

namespace FactoryMethodDesignPattern.Classes
{
	public class FirstClassAirTicket : IAirTicket
	{
		public string TicketType { get; private set; }

		public FirstClassAirTicket()
		{
			TicketType = "First Class.";
		}

		public string Name()
		{
			return TicketType;
		}
	}
}
