using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactroryDesignPattern.Interfaces;

namespace AbstractFactroryDesignPattern.Classes
{
	public class Computer
	{
		public Memory Memory { get; private set; }
		public Cpu Cpu { get; private set; }

		public Computer(Memory memory, Cpu cpu)
		{
			Memory = memory;
			Cpu = cpu;
		}
	}
}
