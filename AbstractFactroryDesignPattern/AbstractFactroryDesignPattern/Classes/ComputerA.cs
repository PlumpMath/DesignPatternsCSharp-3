using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactroryDesignPattern.Interfaces;

namespace AbstractFactroryDesignPattern.Classes
{
	public class ComputerA : IComputer
	{
		public IMemory Memory { get; private set; }
		public ICpu Cpu { get; private set; }
 
		public ComputerA(IMemory memory, ICpu cpu)
		{
			Memory = memory;
			Cpu = cpu;
		}

		public IMemory GetMemory()
		{
			return Memory;
		}

		public ICpu GetCpu()
		{
			return Cpu;
		}
		//public IComputer<MemoryA, CpuA> GetComputer(IMemory<MemoryA> memory, ICpu<CpuA> cpu)
		//{
		//	return new ComputerA(memory, cpu);
		//}
	}
}
