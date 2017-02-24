using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterDesignPattern.Classes;

namespace AdapterDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Computer computerMemoryA = new Computer(new MemoryA());

			//Save method using MemoryA.
			computerMemoryA.SaveData(10, 10);

			Console.WriteLine("Value {0} stored at address {1} ", computerMemoryA.MemoryA.Value, computerMemoryA.MemoryA.Address);

			Computer computerMemoryB =  new Computer(new MemoryAAdapter(new MemoryB()));

			//same Save method using MemoryB without any changing it.
			computerMemoryB.SaveData(15, 15);

			MemoryB memoryB = (computerMemoryB.MemoryA as MemoryAAdapter).MemoryB;
			Console.WriteLine("Value {0} stored at address {1} ", memoryB.Value, memoryB.Address);

			Console.ReadKey();
		}
	}
}
