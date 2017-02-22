using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactroryDesignPattern.Interfaces;

namespace AbstractFactroryDesignPattern.Classes
{
	public class ComputerA : IComputer<ComputerA, MemoryA, CpuA>
	{
		public IMemory<MemoryA> Memory { get; private set; }
		public ICpu<CpuA> Cpu { get; private set; }
 
		public ComputerA(IMemory<MemoryA> memory, ICpu<CpuA> cpu)
		{
			Memory = memory;
			Cpu = cpu;
		}

		public ComputerA GetComputer(IMemory<MemoryA> memory, ICpu<CpuA> cpu)
		{
			return new ComputerA(memory, cpu);
		}
	}
}
