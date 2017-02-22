using System;
using AbstractFactroryDesignPattern.Classes;
using AbstractFactroryDesignPattern.Interfaces;

namespace AbstractFactroryDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Computer computer = new Computer(new Memory("Memory"), new Cpu("Cpu"));
			Computer newComputer = BuildComputerViolatesOCP(computer);
			Console.WriteLine("Memory: {0}, Cpu: {1}", newComputer.Memory.Name, newComputer.Cpu.Name);

			ComputerA computerA = new ComputerA(new MemoryA(""), new CpuA(""));
			ComputerA newComputerA = computerA.GetComputer(new MemoryA("MemoryA"), new CpuA("CpuA"));
			Console.WriteLine("Memory: {0}, Cpu: {1}", newComputerA.Memory.GetName(), newComputerA.Cpu.GetName());


			Console.ReadKey();
		}

		/// <summary>
		/// Violates Open closed principle
		/// </summary>
		/// <param name="computer"></param>
		/// <returns></returns>
		private static Computer BuildComputerViolatesOCP(Computer computer)
		{
			return new Computer(computer.Memory, computer.Cpu);
		}

		/// <summary>
		/// Violates Open closed principle
		/// </summary>
		/// <param name="computerA"></param>
		/// <returns></returns>
		private static T BuildComputer(IComputer<T, M, C> computer)
		{
			return computer.GetComputer(computer.)
		}
	}
}
