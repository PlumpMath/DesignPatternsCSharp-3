using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactroryDesignPattern.Interfaces;

namespace AbstractFactroryDesignPattern.Classes
{
	public class MemoryA: IMemory<MemoryA>
	{
		public string Name { get; private set; }

		public MemoryA(string name)
		{
			Name = name;
		}

		public string GetName()
		{
			return Name;
		}

		public MemoryA GetMemory(string name)
		{
			return new MemoryA(name);
		}
	}
}
