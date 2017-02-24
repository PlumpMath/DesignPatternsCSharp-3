using System;

namespace AdapterDesignPattern.Classes
{
	public class MemoryA
	{
		public int Address { get; private set; }
		public int Value { get; private set; }

		public virtual void SaveValueAtAddress(int address, int value)
		{
			Console.WriteLine("Using memoryA.");
			Address = address;
			Value = value;
		}
	}
}
