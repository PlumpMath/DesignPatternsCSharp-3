using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactroryDesignPattern.Interfaces
{
	public interface IComputer<T, M, C>
	{
		//IMemory<T> GetMemory();
		//ICpu<T> GetCpu();

		T GetComputer(IMemory<M> memory, ICpu<C> cpu);
	}
}
