using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactroryDesignPattern.Interfaces;

namespace AbstractFactroryDesignPattern.Classes
{
	public class CpuA: ICpu
	{
		public string Name { get; private set; }

		public CpuA(string name)
		{
			Name = name;
		}

		public string GetName()
		{
			return Name;
		}

		//public CpuA GetCpu(string name)
		//{
		//	return new CpuA(name);
		//}
	}
}
