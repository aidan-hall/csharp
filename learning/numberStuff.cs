using System;

class Numbering
{
	static void Main()
	{
		double d = 1.5;
		double million = 1E06;		// Exponential numbers may be given in this format.
		int thousand = 1_000;		// This is a valid format in C# but Vim doesn't like it.

		var b = 0b1010_1011_1110_1111;	// Numbers can be specified in binary using the '0b' prefix.

		Console.WriteLine(d);
		Console.WriteLine(million);
		Console.WriteLine(thousand);
		Console.WriteLine(b);
		Console.WriteLine(1.0.GetType());	// This will be a double.
			
		thousand++;
		Console.WriteLine(thousand--);		// This outputs the value first, then subtracts 1.
		Console.WriteLine(thousand);
		
		
		Console.WriteLine();			// This can be used to output a blank line.
		

		// Overflow:
		int a = int.MinValue;
		Console.WriteLine(a);
		a--;
		Console.WriteLine( a == int.MaxValue );
		Console.WriteLine(a);


		Console.WriteLine();

		// Special float and double values:

		Console.WriteLine(double.NegativeInfinity);
		Console.WriteLine(double.NaN);
		Console.WriteLine(-0.0f);

		// decimal should only be used over double when high precision is needed.
		// decimal has a greater number of significant figures but double can
		// store larger numbers and is faster.
	}
}
