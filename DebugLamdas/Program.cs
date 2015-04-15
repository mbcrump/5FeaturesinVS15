using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugLamdas
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> elements = new List<int>() { 10, 20, 31, 40 };
			// ... Find index of first odd element.
			int oddIndex = elements.FindIndex(x => x % 2 != 0);
			Console.WriteLine(oddIndex);
			Console.ReadLine();
			// returns 2

			//Add Watch to the lambda breakpoint.
			//elements.Where(v => (int)v > 11).ToArray() 
		}
	}
}
