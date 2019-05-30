using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping {
	// Swapping the values of two variables.
	class program {
		static void Main(string[] args) {
			// This will be useful for bubble sort and other things.
			
			int a = 0;
			int b = 1;

			(a,b) = (b,a);
			Console.WriteLine(a);
			Console.WriteLine(b);
		}
	}
}

