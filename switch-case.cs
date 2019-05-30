using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase {
	// A C# file wherein I will use to use the switch statement.
	class program {
		static void Main(string[] args) {
			// Example 1:

			Console.Write("Enter your grade: ");
			string grade = Console.ReadLine();
			
			switch (grade) {
				case "A+":
				case "A":
					Console.WriteLine("Distinction.");
					break;
				case "B":
					Console.WriteLine("Good.");
					break;
				case "C":
					Console.WriteLine("Not great...");
					break;
				default:
					Console.WriteLine("Failure!");
					break;
			}
			

		}
	}
}

