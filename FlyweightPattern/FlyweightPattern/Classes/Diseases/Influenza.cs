using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyweightPattern.Interfaces;

namespace FlyweightPattern.Classes.Diseases
{
	public class Influenza : IDisease
	{
		private string _name;
		private string _symptoms;

		private static Influenza instance;

		public string Symptoms() { return _symptoms; }
		public string Name() { return _name; }

		private Influenza (string name, string symptoms)
		{
			_name = name;
			_symptoms = symptoms;
		}

		public static Influenza Instance(string name, string symptoms)
		{
			if(instance == null )
			{
				instance = new Influenza(name, symptoms);
			}
			return instance;
		}
	}
}
