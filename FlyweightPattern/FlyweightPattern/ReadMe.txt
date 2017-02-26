Flyweight Pattern.
Consider that you have Class named Person which stores the information of his/her Enthnicity. Ethinicity is abstract class
such that you have several ethnicities inheriting this class. Each of the Ethnicity classes has a list of Disease class objects
such that we know if a person belongs to certain ethnicity then that person has probability of catching diseases assocaited
with that ethnicity. Now if we create object of Ethnicity for each person then we are creating copies of same objects 
several times. each ethnicity object inturn will create objects of all the diseases associated with it. This creates 
a very memory heavy application as number of persons could be several million even billions. So flyweight pattern suggests
that instead of creating individual objects of ethnicity and hence diseases, since they have the same information irrespective
of person, we can share these objects thus reducing number of Ethnicity objects = number of ethnicities than being equal to
number of person objects. Same is the case with the disease objects.