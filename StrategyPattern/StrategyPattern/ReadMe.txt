Consider a scenario where you have a function string ReplaceString(string input, string replace, string replaceWith). 
This function internally uses ReplaceStringUsingStrReplace() to do some replacement. Now a new
algorithm say ReplaceStringUsingStrBuilder() comes along that does the same replace faster but at
cost of memory. So you want to implement ReplaceString() such that it incorporates this
new algorithm but also use the existing one because of the memory concerns. This
change will again violate Open Closed Principle. So Strategy Pattern tries to address this
by suggesting that instead of ReplaceString() deciding which algorithm to use, let the
strategy be decided by the caller of the function. For C# ReplaceStringUsingStrReplace() and ReplaceStringUsingStrBuilder()
could be delegates; say delegate string ReplaceStringDelegate(string input, string replace, string replaceWith); 
and ReplaceString() take in the delegate and run the computations. This pattern relies on Liskov’s Substitution principle.

Consequence:
COnsequence of this pattern is that any new Algorithm that comes along has to stick to the delegate signature.
If not, then the ReplaceString() will not be able to accomodate it.