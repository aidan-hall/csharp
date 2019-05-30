using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic {
	// If, for and while loops.
	class program {
		static void Main(string[] args) {
			// If loops:

			int age;
			Console.Write("Enter your age: ");
			age = Convert.ToInt32(Console.ReadLine());

			if (age < 0 || age > 150) 
				Console.WriteLine("Invalid age.");

			else if (age == 69) 
				Console.WriteLine("Nice.");
			else if (age < 18)
				Console.WriteLine("Underage.");
			else if (age < 21)
				Console.WriteLine("You need parental consent");
			else {
				Console.WriteLine("Congratulations! You are the right age.");
				Console.WriteLine("Get ready to see some cute cats.");
				Console.WriteLine(age.ToString());
			}
			

			// Inline if:
			string approved;
			
			approved = age >= 18 ? "Yes." : "No.";
			Console.WriteLine(approved);
			
		}
	}
}

