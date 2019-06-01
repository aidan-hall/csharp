using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listsPractice {
	// A C# file for me to practice using lists.
	class program {
		static void Main(string[] args) {
			Console.WriteLine("Hello world.");

			// Lists:
			List<int> ageList = new List<int> {11, 21, 31, 41};
			ageList.Add(51);
			Console.WriteLine(ageList.Count);

			
			ageList.Insert(2, 25);
			Console.WriteLine(ageList[2]);

			ageList.Remove(31);
			Console.WriteLine(ageList[3]);
			
			ageList.RemoveAt(0);
			Console.WriteLine(ageList[0]);

			if (ageList.Contains(51)) {
				Console.WriteLine("That worked!");
			}
			
			ageList.Clear();
			Console.WriteLine(ageList.Count);


		}
	}
}

