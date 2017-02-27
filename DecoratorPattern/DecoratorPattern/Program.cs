using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Classes;

namespace DecoratorPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Application application = new Application(1200, 60, 100, 3.4);

			//Evaluate GPA only
			Evaluator gpaEval = new GPAEvaluator();
			DoEvaluation(application, gpaEval);
			Console.WriteLine("Continue evaluation...");
			Console.ReadKey();

			//Evaluate GRE and GPA
			Evaluator greEval = new GREEvaluator(gpaEval);
			DoEvaluation(application, greEval);
			Console.WriteLine("Continue evaluation...");
			Console.ReadKey();

			//Evaluate TOEFL and GPA
			Evaluator toeflEval = new TOEFLEvaluator(gpaEval);
			DoEvaluation(application, toeflEval);
			Console.WriteLine("Continue evaluation...");
			Console.ReadKey();

			//Evaluate TOEFL, GRE and GPA
			Evaluator toeflGreEval = new TOEFLEvaluator(new GREEvaluator(gpaEval));
			DoEvaluation(application, toeflGreEval);
			Console.WriteLine("Continue evaluation ...");
			Console.ReadKey();

			//Evaluate TSA, TOEFL, GRE and GPA
			Evaluator tsaToeflGreEval = new TSEEvaluator(new TOEFLEvaluator(new GREEvaluator(gpaEval)));
			DoEvaluation(application, tsaToeflGreEval);
			Console.ReadKey();
		}

		private static void DoEvaluation(Application application, Evaluator evaluator)
		{
			evaluator.Evaluate(application);
		}

	}
}
