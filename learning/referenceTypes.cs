using System;

public class Point { public int X, Y; }		// Reference type.

class Referencing
{
	static void Main()
	{
		Point p1 = new Point();
		p1.X = 7;

		Point p2 = p1;			// Copies p1 reference.

		Console.WriteLine(p1.X);
		Console.WriteLine(p2.X);

		p1.X = 9;			// Change p1.X;

		Console.WriteLine(p1.X);	// 9.
		Console.WriteLine(p2.X);	// 9.

	}
}
