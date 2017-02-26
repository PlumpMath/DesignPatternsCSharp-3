using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyweightPattern.Interfaces;

namespace FlyweightPattern.Classes.Ethnicities
{
	public class Ethnicity3 : IEthnicity
	{
		private string _name;
		private List<IDisease> _diseases;

		private static Ethnicity3 instance;

		public List<IDisease> Diseases() { return _diseases; }
		public string Name() { return _name; }

		private Ethnicity3(string name, List<IDisease> diseases)
		{
			_name = name;
			_diseases = diseases;
		}

		public static Ethnicity3 Instance(string name, List<IDisease> diseases)
		{
			if(instance == null )
			{
				instance = new Ethnicity3(name, diseases);
			}
			return instance;
		}
	}
}
