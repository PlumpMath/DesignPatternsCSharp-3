Consider a scenario where you have a class ComputerA that aggregates objects of RamA, CpuA, etc. 
Also consider a function string GiveDetails(ComputerA compA) and then accesses compA to get CPU, Ram and displays the name of memory and RAM. 
Now say a new computer class say ComputerB comes along and you want to use the same GiveDetails(). You cannot do so without modifying GiveDetails(). 
This violated Open Closed Principle. Abstract Factory Pattern tries to address this problem by suggesting that instead of BuildComputer being dependent on concrete class, 
it should instead depend on an abstraction such that these concrete classes implement this abstraction.

Consequence:
In order to achieve OCP, in C#, any new computer class will have to implement and stick to what the interface defines. So if a new Computer class comes along that needs 
something more than what is implemented in the interface, then GiveDetails() will be needed to be modified to accomodate that change.