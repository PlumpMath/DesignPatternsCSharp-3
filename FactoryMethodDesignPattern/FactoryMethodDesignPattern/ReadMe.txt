In Fatcory Method Design pattern an object delegates the responsibility of creating objects it needs to the derived classes.
FOr this lets us the Travelling Employee example. If the employee is an executive then he gets to rent a luxury vehicle and stay in 5-star hotel.
If the employee is a regular employee then he gets to rent Economy vehicle and stary in a motel.
Now when we create seperate employee classes and each one creates its own tickets, car rental etc. will result in duplication. This is clear
violation of DRY prnciple. So Factory Method DP says that instead of having such implementation, have a abstarct base class that delegates
creation of objects in the classes using abstract functions that are implemented in the child classes.