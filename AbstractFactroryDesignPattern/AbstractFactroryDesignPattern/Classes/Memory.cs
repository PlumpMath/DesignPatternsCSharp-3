using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactroryDesignPattern.Classes
{
	public class Memory
	{
		public string Name { get; private set; }

		public Memory(string name)
		{
			Name = name;
		}
	}
}
