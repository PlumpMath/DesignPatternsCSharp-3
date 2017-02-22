using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactroryDesignPattern.Interfaces;

namespace AbstractFactroryDesignPattern.Classes
{
	public class ComputerB: IComputer<ComputerB, MemoryB, CpuB>
	{
		public IMemory<MemoryB> Memory { get; private set; }
		public ICpu<CpuB> Cpu { get; private set; }

		public ComputerB(IMemory<MemoryB> memory, ICpu<CpuB> cpu)
		{
			Memory = memory;
			Cpu = cpu;
		}

		//public IMemory<MemoryB> GetMemory()
		//{
		//	return Memory;
		//}

		//public CpuB GetCpu()
		//{
		//	return Cpu;
		//}

		public ComputerB GetComputer(IMemory<MemoryB> memory, ICpu<CpuB> cpu)
		{
			return new ComputerB(memory, cpu);
		}
	}
}
