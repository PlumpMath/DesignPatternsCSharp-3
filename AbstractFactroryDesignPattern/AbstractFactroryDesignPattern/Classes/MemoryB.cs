using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactroryDesignPattern.Interfaces;

namespace AbstractFactroryDesignPattern.Classes
{
	public class MemoryB: IMemory<MemoryB>
	{
		public string Name { get; private set; }

		public MemoryB(string name)
		{
			Name = name;
		}

		public string GetName()
		{
			return Name;
		}

		public MemoryB GetMemory(string name)
		{
			return new MemoryB(name);
		}
	}
}
