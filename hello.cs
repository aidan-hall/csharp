using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld {
	// A simple program to display the words 'Hello World'.
	/* This is a multi-line comment.
	 * It goes over multiple lines.
	 * The comment continues until it is terminated by this: */
	class program
	{
		static void Main(string[] args)
		{
			// Here are some data types for numbers:
			string hello = "Hello World!";
			Console.WriteLine(hello);

			int age = 15, eyes = 2;
			Console.WriteLine(age);
			Console.WriteLine(eyes);
			
			/* Byte only has a range of 0 - 255 (it is stored in a single byte)
			 * but is good to use for efficiency. */
			byte byteAge;
			byteAge = 20;
			Console.WriteLine(byteAge);

			// Floating point numbers are different to integers: 20 and 20.0 will behave differently.
			float speed = 56.23f;
			Console.WriteLine(speed);
			
			// Double has the widest range so it is the default data type for numbers with a decimal place.
			double preciseSpeed = 56.233234234234334534;
			Console.WriteLine(preciseSpeed);
			
			decimal hyperPreciseAge = 56.233234234234433453324234234324123453234565432m;
			Console.WriteLine(hyperPreciseAge);

			float castedSpeed = (float) hyperPreciseAge;
			Console.WriteLine(castedSpeed);
			// Now we have some other data types the use of which should be evident from context and their names:

			string coolio = "Gangster's Paradise.";
			Console.WriteLine(coolio);
			string blankString = "";
			blankString = "Hidden.";
			Console.WriteLine(blankString.Length);

			string example = "Hello World!";
			string newMessage = example.Substring(2,5);
			Console.WriteLine(newMessage);
			bool test = example.Equals(hello);
			Console.WriteLine(test);

			// Split()

			string names = "Peter, John; Andy, , David";
			string [] separator = {", ", "; "};
			string [] substrings = names.Split(separator, StringSplitOptions.None);
			Console.WriteLine(substrings[3]);


			// Whilst string uses quotation marks, char uses apostrophes.
			char grade = 'A';
			Console.WriteLine(grade);

			bool complete = false;
			Console.WriteLine(complete);

			// Now I will do some stuff to demonstrate how actual coding with C# might work:

			int x = 5, y = 10;
			x += y;
			Console.WriteLine(x);
			
			// If both numbers are integers, the result will be an integer:
			int a = 7, b = 2;
			Console.WriteLine(a / b);
			// The result is truncated.
			
			/* However, if one of the numbers is a floating point number of any type,
			 * the result will also be a floating point: */
			double c = 2.0;
			Console.WriteLine(a / c);

			// You can do this to add one to a number:
			Console.WriteLine(a);
			a++;
			Console.WriteLine(a);

			// Type casting:

			int d = (int) hyperPreciseAge;
			Console.WriteLine(d);

			// Arrays:

			int[] numbers = {21, 22, 23, 24, 25};
			Console.WriteLine(numbers[2]);

			int[] array2;
			array2 = new [] {4,13,6,12};
			Console.WriteLine(array2[1]);
			
			Console.WriteLine(Array.IndexOf(array2, 13));
			Console.WriteLine(Array.IndexOf(array2, 20));

			// An array can be initialised with default values (of 0):
			int[] blankArray = new int[5];
			Console.WriteLine(blankArray[3]);
			Console.WriteLine(blankArray.Length);

			// Copy the first certain number of terms into the front of the array:

			int [] source = {1,87,96,4,5,6,7,8,9,0};
			int [] dest = {5,4,3,2};

			Array.Copy(source, dest, 3);
			Console.WriteLine(dest[0]);
			
			Array.Sort(dest);
			Console.WriteLine(dest[dest.Length-1]);

			Console.Read();
			Console.WriteLine("That was nice!");
		}
	}
}
