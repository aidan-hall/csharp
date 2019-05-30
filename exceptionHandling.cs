using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions {
	// Things that can be done to prevent the program from crashing.
	class program {
		static void Main(string[] args) {
			// The try-catch-finally statement:

			double numerator, denominator;

			Console.Write("Please enter the numerator: ");
			numerator = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Please enter the denominator: ");
			denominator = Convert.ToInt32(Console.ReadLine());

			try {
				Console.WriteLine("The result is {0}.", numerator/denominator);
			}
			catch (Exception e) {
				Console.WriteLine(e.Message);
			}
			finally {
				Console.WriteLine("--End of Error Handling Example--");
			}

			// Specific errors:

			int choice = 0;

			int [] numbers = {10, 11, 12, 13, 14, 15 };
			Console.Write("Please enter the index of the array: ");
			
			try {
				choice = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("numbers[{0}] = {1}", choice , numbers[choice]);
			}
			catch (IndexOutOfRangeException) {
				Console.WriteLine("Error: Index should be from 0 to 5.");
			}
			catch (FormatException) {
				Console.WriteLine("Error: You didn't enter an integer.");
			}
			catch (Exception e) {
				Console.WriteLine(e.Message);
			}
		}
	}
}

