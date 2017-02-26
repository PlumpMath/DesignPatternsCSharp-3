using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyweightPattern.Interfaces;

namespace FlyweightPattern.Classes.Persons
{
	public class Person
	{
		public string Name { get; private set; }
		public IEthnicity Ethnicity { get; private set; }

		public Person (string name, IEthnicity ethnicity)
		{
			Name = name;
			Ethnicity = ethnicity;
		}

		public string GetSymptoms()
		{
			StringBuilder symptoms = new StringBuilder();
			foreach(IDisease disease in Ethnicity.Diseases())
			{
				symptoms.Append(disease.Symptoms());
			}
			 
			return symptoms.ToString();
		}

		public string GetDiseases()
		{
			StringBuilder diseases = new StringBuilder();
			foreach (IDisease disease in Ethnicity.Diseases())
			{
				diseases.Append(disease.Name());
			}

			return diseases.ToString();
		}
	}
}
