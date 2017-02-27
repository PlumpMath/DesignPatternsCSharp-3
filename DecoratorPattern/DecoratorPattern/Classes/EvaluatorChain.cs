using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Classes
{
	public abstract class EvaluatorChain : Evaluator
	{
		public Evaluator Next{get; private set;}

		public EvaluatorChain(Evaluator next)
		{
			Next = next;
		}

		public override bool Evaluate(Application application)
		{
			if (Next.Evaluate(application))
				return EvaluateApplication(application);

			return false;
		}

		public abstract bool EvaluateApplication(Application application);
	}
}
