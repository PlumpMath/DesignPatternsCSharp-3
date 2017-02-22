Consider a scenario where you have a class ComputerA that aggregates objects of RamA, CpuA, etc. 
Also consider a ComputerA BuildComputer(ComputerA compA) and then access compA to get CPU, Ram and create a new ComputerA object and return the same. 
Now say a new Computer class say ComputerB comes along and you want to use the same BuildComputer(). You cannot do so without modifying BuildComputer(). 
This violated Open Closed Principle. Abstract Factory Pattern tries to address this problem by suggesting that instead of BuildComputer being dependent on concrete class, 
it should instead depend on an abstraction such that these concrete classes implement this abstraction.