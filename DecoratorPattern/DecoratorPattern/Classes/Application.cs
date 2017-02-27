using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Classes
{
	public class Application
	{
		public int GRE { get; private set; }
		public int TSE { get; private set; }
		public int TOEFL { get; private set; }
		public double GPA { get; private set; }

		public Application(int gre, int tse, int toefl, double gpa)
		{
			GRE = gre;
			TSE = tse;
			TOEFL = toefl;
			GPA = gpa;
		}
	}
}
