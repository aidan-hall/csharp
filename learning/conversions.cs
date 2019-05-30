using System;

class Conversions
{
	static void Main(string[] args)
	{
		int x = 12345;		// int is a 32-bit integer.
		long y = x;		// Implicit conversion to a 64-bit integer.
		short z = (short)x;	// Explicit conversion to a 16-bit integer.

		Console.WriteLine(x);
		Console.WriteLine(y);
		Console.WriteLine(z);
		Console.WriteLine("Hello there!");


	}
}
