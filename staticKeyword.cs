using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesWithStaticMethods {
	// Here we can see how a class with a static method would work.
	class Program {
		static void Main(string[] args) {
			// This will execute when the exe is run.
			Console.WriteLine("Hello world.");
		}
	}

	class MyClass {
		// Non-static members:

		public string message = "Hello World.";
		public string Name { get; set; }

		public void DisplayName() {
			Console.WriteLine("Name = {0}", Name);
		}
		

		// Static members:

		public static string greetings = "Good morning.";
		public static int Age { get; set; }

		public static void DisplayAge() {
			Console.WriteLine("Age = {0}", Age);
		}
	}
}

