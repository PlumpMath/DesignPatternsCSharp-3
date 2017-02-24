using System;

namespace AdapterDesignPattern.Classes
{
	public class MemoryAAdapter : MemoryA
	{
		public MemoryB MemoryB { get; private set; }

		public MemoryAAdapter(MemoryB memoryB)
		{
			this.MemoryB = memoryB;
		}

		public override void SaveValueAtAddress(int address, int value)
		{
			Console.WriteLine("Using memoryB.");
			MemoryB.Address = address;
			MemoryB.Value = value;
		}
	}
}
