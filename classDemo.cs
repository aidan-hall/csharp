using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demonstrationOfClasses {
	// I will finally get to use the thing
	// that makes C# C#.
	class Program {
		static void Main(string[] args) {
			// This is the main class which executes when the program is run.
			Console.WriteLine("Hello world!");

			// Instantiating an object.
			
			int pay;

			Staff staff1 = new Staff("Peter");
			staff1.HoursWorked = 160;
			pay = staff1.CalculatePay(1000, 400);
			Console.WriteLine("Pay = {0:C}", pay);
			Staff staff2 = new Staff("Jane", "Lee");
			staff2.HoursWorked = 160;

			int pay2;
			pay2 = staff2.CalculatePay();
			Console.WriteLine("Pay = {0:C}", pay2);

			// Validation of inputs (pay < 0).
			int pay3;

			Staff staff3 = new Staff("Carol");
			staff3.HoursWorked = -10;
			pay3 = staff3.CalculatePay();
			Console.WriteLine("Pay = {0:C}", pay3);
			
		}
	}
	
	class Staff {
		private string nameOfStaff;
		private const int hourlyRate = 30;
		private int hWorked;
		
		// Public property:
		public int HoursWorked {
			get {
				return hWorked;
			}
			set {
				if (value > 0 )
					hWorked = value;
				else
					hWorked = 0;
			}
		}

		// Methods:
		

		public void PrintMessage() {
			Console.WriteLine("Calculating Pay...");
		}
		

		public int CalculatePay() {
			PrintMessage();

			int staffPay;
			staffPay = hWorked * hourlyRate;
			
			if (hWorked > 0)
				return staffPay;
			else
				return 0;
		}
		
		/* You can have two methods with the same name
		 * provided they have different signatures.
		 */
		public int CalculatePay(int bonus, int allowance) {
			PrintMessage();

			if (hWorked > 0) {
				return hWorked * hourlyRate + bonus + allowance;
			}
			else
				return 0;
		}


		// Overwriting the default ToString(); method:
		
		public override string ToString() {
			return "Name of Staff = " + nameOfStaff + ", hourlyRate = " + hourlyRate + ", hWorked = " + hWorked;
		}
		

		/* A constructor method is run whenever an object of a class is run.
		 * It has the same name as the class.
		 * It has no return value. */

		public Staff(string name) {
			nameOfStaff = name;
			Console.WriteLine("\n" + nameOfStaff);
			Console.WriteLine("-----------------------------");
		}
		
		
		// There can be more than one constructor method
		// as long as they have different signatures:

		public Staff(string firstName, string lastName) {
			nameOfStaff = firstName + " " + lastName; Console.WriteLine("\n" + nameOfStaff);
			Console.WriteLine("-----------------------------");
		}
		
		// There is a default constructor which
		// initialises all fields to default values.
	}
	
}
