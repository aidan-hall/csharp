using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoops {
	// Demonstration of for loops.
	class Program {
		static void Main(string[] args) {
			// This is a for loop:
			
			for (int i = 0; i < 5; i++) {
				Console.WriteLine(i);
			}


			int [] numbers = {10,20,30,40,50};

			/* A for loop iterating through an array: */
			
			Console.WriteLine("Iterating through an array:");
			for (int i = 0; i < numbers.Length; i++) {
				Console.WriteLine(numbers[i]);
			}
			
			// The foreach loop:

			char [] message = {'H','e','l','l','o'};
			Console.WriteLine("foreach:");

			foreach (char i in message)
				Console.WriteLine(i);

			// The while loop:

			int counter = 5;


			while (counter > 0) {
				Console.WriteLine("Counter: {0}", counter);
				counter -= 1;
			}
			
			// The do while loop:

			Console.WriteLine("\nThis is now the do while loop: ");
			counter = 100;

			do {
				Console.WriteLine("Counter {0}", counter);
				counter++;
			} while (counter < 0);
		}
	}
}


