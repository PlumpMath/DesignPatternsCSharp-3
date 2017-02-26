using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyweightPattern.Interfaces;

namespace FlyweightPattern.Classes.Diseases
{
	public class Diabetes : IDisease
	{
		private string _name;
		private string _symptoms;

		private static Diabetes instance;

		public string Symptoms() { return _symptoms; }
		public string Name() { return _name; }

		private Diabetes (string name, string symptoms)
		{
			_name = name;
			_symptoms = symptoms;
		}

		public static Diabetes Instance(string name, string symptoms)
		{
			if(instance == null )
			{
				instance = new Diabetes(name, symptoms);
			}
			return instance;
		}
	}
}
