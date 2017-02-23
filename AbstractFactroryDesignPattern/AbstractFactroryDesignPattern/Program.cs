using System;
using System.Text;
using AbstractFactroryDesignPattern.Classes;
using AbstractFactroryDesignPattern.Interfaces;

namespace AbstractFactroryDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Computer computer = new Computer(new Memory("Memory"), new Cpu("Cpu"));
			Console.WriteLine(GiveComputerDetailsViolatesOCP(computer));

			ComputerA computerA = new ComputerA(new MemoryA("MemoryA"), new CpuA("CpuA"));
			Console.WriteLine(GiveComputerDetails(computerA));

			ComputerA computerB = new ComputerA(new MemoryB("MemoryB"), new CpuB("CpuB"));
			Console.WriteLine(GiveComputerDetails(computerB));

			Console.ReadKey();
		}

		/// <summary>
		/// Violates Open closed principle. If a new computer comes over and this method will not be able to handle it without extending it.
		/// </summary>
		/// <param name="Computer computer"></param>
		/// <returns></returns>
		private static string GiveComputerDetailsViolatesOCP(Computer computer)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Memory: ");
			stringBuilder.Append(computer.Memory.Name);
			stringBuilder.Append(", Cpu: ");
			stringBuilder.Append(computer.Cpu.Name);
			
			return stringBuilder.ToString();
		}

		/// <summary>
		/// Any number of new computers can be added and as long as they implement IComputer interface this method will not change.
		/// </summary>
		/// <param name="IComputer computer"></param>
		/// <returns></returns>
		private static string GiveComputerDetails(IComputer computer)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Memory: ");
			stringBuilder.Append(computer.GetMemory().GetName());
			stringBuilder.Append(", Cpu: ");
			stringBuilder.Append(computer.GetCpu().GetName());

			return stringBuilder.ToString();
		}
	}
}
