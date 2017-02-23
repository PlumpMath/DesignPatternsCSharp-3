using System;
using FactoryMethodDesignPattern.Classes;
namespace FactoryMethodDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			ExecutiveEmployee executiveEmployee = new ExecutiveEmployee();
			executiveEmployee.GetReadyForTravel();

			OrdinaryEmployee ordinaryEmployee = new OrdinaryEmployee();
			ordinaryEmployee.GetReadyForTravel();

			Console.ReadKey();
		}
	}
}
