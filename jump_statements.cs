using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jumping {
	// This program will demonstrate jumping.
	class program {
		static void Main(string[] args) {
			// The break statement:
			
			int i = 0;

			for (i = 0; i < 5; i++) {
				Console.WriteLine("i = {0}", i);
				if (i == 2)
					break;
			}
			
			// The continue statement:

			for (i = 0; i < 5; i++) {
				Console.WriteLine("i = {0}", i);
				if (i == 2)
					continue;
				Console.WriteLine("I will not be printed if i=2.\n");
			}

		}
	}
}

