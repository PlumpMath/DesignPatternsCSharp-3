using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactroryDesignPattern.Interfaces
{
	public interface IComputer
	{
		//IMemory<T> GetMemory();
		//ICpu<T> GetCpu();

		IMemory GetMemory();
		ICpu GetCpu();
	}
}
