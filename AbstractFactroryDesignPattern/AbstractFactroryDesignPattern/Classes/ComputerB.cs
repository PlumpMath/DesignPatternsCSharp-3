using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactroryDesignPattern.Interfaces;

namespace AbstractFactroryDesignPattern.Classes
{
	public class ComputerB: IComputer
	{
		public IMemory Memory { get; private set; }
		public ICpu Cpu { get; private set; }

		public ComputerB(IMemory memory, ICpu cpu)
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

		//public IComputer<MemoryB, CpuB> GetComputer(IMemory<MemoryB> memory, ICpu<CpuB> cpu)
		//{
		//	return new ComputerB(memory, cpu);
		//}
	}
}
