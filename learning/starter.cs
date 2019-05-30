using System;	// Importing namespace.

class Test
{
    static void Main(string[] args)
    {
        int x = 12 * 30;
        Console.WriteLine(x);

        Console.WriteLine(FeetToInches(30));
        Console.WriteLine(FeetToInches(100));

        Console.Write("Enter a length in feet: ");
        int length = Console.Read();

        Console.WriteLine(FeetToInches(length));

        Console.WriteLine(Factorial(3));
    }


    static int FeetToInches(int feet)
    {
        // Converts feet to inches.
        int inches = feet * 12;
        return inches;
    }


    static int Factorial(int number)
    {
        // Calculates the factorial of a number.
        // This demonstrates recursion.
        if (number == 1)
            return (1);
        else
            return (number * Factorial(number - 1));
    }
}
