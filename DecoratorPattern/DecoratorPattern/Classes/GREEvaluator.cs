using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Classes
{
	public class GREEvaluator : EvaluatorChain
	{
		public GREEvaluator(Evaluator next) : base(next)
		{ }
		
		public override bool EvaluateApplication(Application application)
		{
			Console.WriteLine("Evaluating GRE...");
			return application.GRE > 1000;
		}
	}
}
