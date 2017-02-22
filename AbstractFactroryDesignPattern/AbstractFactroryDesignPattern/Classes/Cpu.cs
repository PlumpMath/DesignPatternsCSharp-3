using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactroryDesignPattern.Classes
{
	public class Cpu
	{
		public string Name
		{
			get; private set; 
		}

		public Cpu(string name)
		{
			Name = name;
		}
	}
}
