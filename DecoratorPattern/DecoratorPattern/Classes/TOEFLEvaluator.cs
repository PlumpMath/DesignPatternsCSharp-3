using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Classes
{
	public class TOEFLEvaluator : EvaluatorChain
	{
		public TOEFLEvaluator(Evaluator next)
			: base(next)
		{ }

		public override bool EvaluateApplication(Application application)
		{
			Console.WriteLine("Evaluating TOEFL...");
			return application.TOEFL > 90;
		}
	}
}
