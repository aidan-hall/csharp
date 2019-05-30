using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interaction {
	// This file will be used to practice with interactive C# elements.
	class program {
		static void Main(string[] args) {
			Console.Write("Hello world.");
			Console.WriteLine(" How are you?");
			Console.WriteLine("Strings can be " + "concatenated.");
			int score = 20;
			Console.WriteLine("You can even concatenate variables such as " + score + " with strings.");
			
			// Placeholders:
			Console.WriteLine("{0}! You scored {1} marks for your test.", "Good morning", score);
			
			// Formatting with placeholders:
			Console.WriteLine("The number {0} to 3 decimal places is {0:F3}.", 123.456778);
			// Currency placeholder:
			Console.WriteLine("Deposit = {0:C}.", 2125);
			
			// Escape sequences:
			Console.WriteLine("Hello\tWorld\nHow goes it?");
			Console.WriteLine("\\");
			Console.WriteLine("The old man said, \"This is bananas!\"");
			
			// Taking inputs:
			Console.Write("Enter your name: ");
			string userInput = Console.ReadLine();
			Console.WriteLine("Hello, "+ userInput + ", I hope you are doing well.");
			
			// Casting a string to a number:
			Console.Write("Enter your age: ");
			string stringUserAge = Console.ReadLine();
			int intUserAge = Convert.ToInt32(stringUserAge);
			decimal decimalUserAge = Convert.ToDecimal(stringUserAge);
			double doubleUserAge = Convert.ToDouble(stringUserAge);
			float floatUserAge = Convert.ToSingle(stringUserAge);
			Console.WriteLine(intUserAge +" "+decimalUserAge+" "+doubleUserAge+" "+floatUserAge);

			Console.Write("Enter the current year: ");
			int year = Convert.ToInt32(Console.ReadLine());
			Console.Write("That means you were probably born in {0}.", year - intUserAge);
			

			Console.Read();
			}
		}
	}
