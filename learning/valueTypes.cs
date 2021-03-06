using System;

public struct Point { public int X; public int Y; }	// Value type.

class Test
{
	static void Main()
	{
		// Value types.
		Point p1 = new Point();
		p1.X = 7;

		Point p2 = p1;				// Assignment causes a copy to be generated.

		Console.WriteLine(p1.X);
		Console.WriteLine(p2.X);

		p1.X = 9;				// The value of p1.X changes but not that of p2.X;

		Console.WriteLine(p1.X);		// 9.
		Console.WriteLine(p2.X);		// 7.
	}
}

