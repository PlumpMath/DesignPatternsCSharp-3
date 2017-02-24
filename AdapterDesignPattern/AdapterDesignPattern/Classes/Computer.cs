

namespace AdapterDesignPattern.Classes
{
	public class Computer
	{
		public MemoryA MemoryA { get; private set; }

		public Computer(MemoryA memoryA)
		{
			MemoryA = memoryA;
		}

		public void SaveData(int address, int value)
		{
			MemoryA.SaveValueAtAddress(address, value);
		}
	}
}
