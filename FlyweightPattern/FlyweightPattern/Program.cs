using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyweightPattern.Classes.Diseases;
using FlyweightPattern.Classes.Ethnicities;
using FlyweightPattern.Classes.Persons;
using FlyweightPattern.Interfaces;

namespace FlyweightPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Influenza influenza = Influenza.Instance("Influenza", "Cough, Cold");
			Diabetes diabetes = Diabetes.Instance("Diabetes", "Weight loss, Hunger, Fatigue");
			Malaria malaria = Malaria.Instance("Malaria", "Chills, Fever, Fatigue");

			Ethnicity1 ethnicity1 = Ethnicity1.Instance("Ethnicity1", new List<IDisease> { influenza, malaria });
			Ethnicity2 ethnicity2 = Ethnicity2.Instance("Ethnicity2", new List<IDisease> { diabetes, malaria });
			Ethnicity3 ethnicity3 = Ethnicity3.Instance("Ethnicity3", new List<IDisease> { influenza, diabetes });

			Person mikeSmith = new Person("Mike Smith", ethnicity1);
			Person johnSmith = new Person("John Smith", ethnicity2);
			Person jackSmith = new Person("Jack Smith", ethnicity2);
			Person nickSmith = new Person("Nick Smith", ethnicity3);
			Person rickSmith = new Person("Rick Smith", ethnicity1);

			Console.WriteLine("Name: {0}, Ethnicity {1}, Probable Diseases {2}, Possible symptoms {3}",
				mikeSmith.Name, mikeSmith.Ethnicity, mikeSmith.GetDiseases(), mikeSmith.GetSymptoms());

			Console.WriteLine("Name: {0}, Ethnicity {1}, Probable Diseases {2}, Possible symptoms {3}",
				johnSmith.Name, johnSmith.Ethnicity, johnSmith.GetDiseases(), johnSmith.GetSymptoms());

			Console.WriteLine("Name: {0}, Ethnicity {1}, Probable Diseases {2}, Possible symptoms {3}",
				jackSmith.Name, jackSmith.Ethnicity, jackSmith.GetDiseases(), jackSmith.GetSymptoms());

			Console.WriteLine("Name: {0}, Ethnicity {1}, Probable Diseases {2}, Possible symptoms {3}",
				nickSmith.Name, nickSmith.Ethnicity, nickSmith.GetDiseases(), nickSmith.GetSymptoms());

			Console.WriteLine("Name: {0}, Ethnicity {1}, Probable Diseases {2}, Possible symptoms {3}",
				rickSmith.Name, rickSmith.Ethnicity, rickSmith.GetDiseases(), rickSmith.GetSymptoms());



		}

	}
}
