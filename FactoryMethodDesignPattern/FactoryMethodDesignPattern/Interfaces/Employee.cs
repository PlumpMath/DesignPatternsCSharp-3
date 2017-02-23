using System;

namespace FactoryMethodDesignPattern.Interfaces
{
	public abstract class Employee
	{
		public abstract IAirTicket CreateAirTicket();
		public abstract ICarRental CreateCarRental();

		/// <summary>
		/// THis function delegates the responsibility of creating teh AirTicket to the classes below the hierarchy.
		/// </summary>
		public void GetReadyForTravel()
		{
			IAirTicket airTicket = CreateAirTicket();
			ICarRental carRental = CreateCarRental();

			Console.WriteLine("Air Ticket = {0} Car Rental = {1}", airTicket.Name(), carRental.Name());
		}
	}
}
