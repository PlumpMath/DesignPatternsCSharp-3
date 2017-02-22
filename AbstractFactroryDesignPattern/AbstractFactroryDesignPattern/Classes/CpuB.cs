using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactroryDesignPattern.Interfaces;

namespace AbstractFactroryDesignPattern.Classes
{
	public class CpuB: ICpu<CpuB>
	{
		public string Name { get; private set; }

		public CpuB(string name)
		{
			Name = name;
		}

		public string GetName()
		{
			return Name;
		}

		public CpuB GetCpu(string name)
		{
			return new CpuB(name);
		}
	}
}
