using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactroryDesignPattern.Interfaces
{
	public interface ICpu<T>
	{
		T GetCpu(string name);
		string GetName();
	}
}
