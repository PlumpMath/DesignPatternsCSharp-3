Adapter Pattern:
Consider a scenario where you have two classes MemoryA and MemoryB who have functions that do almost same task but have differnt signatures. lets say MemoryA has function named
SaveValueToAddress() that takes in Address and value and saves them. Note that they do not have a public accessor. MemoryB does the same thing except through public mutators
Also consider that you have a Computer class that uses has a function SaveData() that saves the address and value in memoryA. Now if the same method needs to use MemoryB instead of MemoryA
then SaveData() function will require changing. To avoid this we can use Adapter pattern. We create an Adapter class that implements MemoryA and overrides SaveValueToAddress. 
It also aggregates MemoryB. Overriden SaveValueToAddress function uses MemoryB object to save value at address.
It generally uses aggregation to solve this problem in C#.