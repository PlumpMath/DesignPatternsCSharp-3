using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StrategyPattern
{
	class Program
	{
		delegate string ReplaceStringDelegate(string inputStr, string patternToReplace, string patternToReplaceWith);

		static void Main(string[] args)
		{
			Console.WriteLine("Enter input string:");
			string inputStr = Console.ReadLine();

			Console.WriteLine("Enter which pattern to replace:");
			string patternToReplace = Console.ReadLine();

			Console.WriteLine("Enter which pattern to replace with:");
			string patternToReplaceWith = Console.ReadLine();

			string afterReplacement = PerformReplacementViolatesOSP(inputStr, patternToReplace, patternToReplaceWith);

			ReplaceStringDelegate usingStringReplace = new ReplaceStringDelegate(ReplaceUsingStringRepalce);
			ReplaceStringDelegate usingStringBuilder = new ReplaceStringDelegate(ReplaceUsingStringBuilderRepalce);

			string afterReplacementStrReplace = PerformReplacement(usingStringReplace, inputStr, patternToReplace, patternToReplaceWith);
	
			string afterReplacementStrBuilder = PerformReplacement(usingStringBuilder, inputStr, patternToReplace, patternToReplaceWith);

			Console.WriteLine("After replace using PerformReplacementViolatesOSP: {0}", afterReplacement);
			Console.WriteLine("After replace using ReplaceUsingStringRepalce: {0} ", afterReplacementStrReplace);
			Console.WriteLine("After replace using ReplaceUsingStringBuilderRepalce: {0} ", afterReplacementStrBuilder);

			Console.ReadKey();

		}

		/// <summary>
		/// As long as new algorithms implment the delegate, this function can be reused by all algorithms.
		/// Which algorithm to use is decided before this function is called.
		/// </summary>
		/// <param name="usingStringReplace"></param>
		/// <param name="inputStr"></param>
		/// <param name="patternToReplace"></param>
		/// <param name="patternToReplaceWith"></param>
		/// <returns></returns>
		private static string PerformReplacement(ReplaceStringDelegate usingStringReplace, string inputStr, string patternToReplace, string patternToReplaceWith)
		{
			return usingStringReplace(inputStr, patternToReplace, patternToReplaceWith);
		}

		/// <summary>
		/// This function violates OSP. as everytime a new algorithm is to be used, this function requires changing.
		/// </summary>
		/// <param name="inputStr"></param>
		/// <param name="patternToReplace"></param>
		/// <param name="patternToReplaceWith"></param>
		/// <returns></returns>
		private static string PerformReplacementViolatesOSP(string inputStr, string patternToReplace, string patternToReplaceWith)
		{
			return ReplaceUsingStringRepalce(inputStr, patternToReplace, patternToReplaceWith);
		}

		/// <summary>
		/// Replace string using string.Replace
		/// </summary>
		/// <param name="inputStr"></param>
		/// <param name="patternToReplace"></param>
		/// <param name="patternToReplaceWith"></param>
		/// <returns></returns>
		private static string ReplaceUsingStringRepalce(string inputStr, string patternToReplace, string patternToReplaceWith)
		{
			return inputStr.Replace(patternToReplace, patternToReplaceWith);
		}

		/// <summary>
		/// Replace string using StringBuilder.Replace
		/// </summary>
		/// <param name="inputStr"></param>
		/// <param name="patternToReplace"></param>
		/// <param name="patternToReplaceWith"></param>
		/// <returns></returns>
		private static string ReplaceUsingStringBuilderRepalce(string inputStr, string patternToReplace, string patternToReplaceWith)
		{
			StringBuilder builder = new StringBuilder(inputStr);
			builder.Replace(patternToReplace, patternToReplaceWith);

			return builder.ToString();
		}
	}
}
