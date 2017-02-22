using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactroryDesignPattern.Interfaces
{
	public interface IMemory<T>
	{
		T GetMemory(string name);
		string GetName();
	}
}
