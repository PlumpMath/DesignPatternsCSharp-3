using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Classes
{
	public class TSEEvaluator : EvaluatorChain
	{
		public TSEEvaluator(Evaluator next)
			: base(next)
		{ }

		public override bool EvaluateApplication(Application application)
		{
			Console.WriteLine("Evaluating TSA...");
			return application.TSE > 50;
		}
	}
}
