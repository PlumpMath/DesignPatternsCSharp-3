Decorator Pattern:
Consider that you have a Application that needs to be evaluated. Say you need to evaluate GPA, GRE, TSE TOEFL 
and any combination of these. You can either create classes to evaluate each of the combination. This violates DRY 
principle. Instead using Decorator patterns we can create individual classes for each evaluator and chain them so that 
what evaluation need to be performed can be decided at run time.