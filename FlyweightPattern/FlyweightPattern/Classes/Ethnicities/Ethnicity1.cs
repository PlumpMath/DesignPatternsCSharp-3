using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyweightPattern.Interfaces;

namespace FlyweightPattern.Classes.Ethnicities
{
	public class Ethnicity1 : IEthnicity
	{
		private string _name;
		private List<IDisease> _diseases;

		private static Ethnicity1 instance;

		public List<IDisease> Diseases() { return _diseases; }
		public string Name() { return _name; }

		private Ethnicity1(string name, List<IDisease> diseases)
		{
			_name = name;
			diseases = _diseases;
		}

		public static Ethnicity1 Instance(string name, List<IDisease> diseases)
		{
			if(instance == null )
			{
				instance = new Ethnicity1(name, diseases);
			}
			return instance;
		}
	}
}
