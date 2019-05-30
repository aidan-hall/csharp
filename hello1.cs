using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // A simple program to display the words 'Hello World'.
    /* This is a multi-line comment.
     * Vim is automatically adding the asterisks to show that it is still a comment. 
     * I don't know if Visual Studio Code has this;
     * I expect that it does but I would prefer not to use it.
     */
    class Program
    {
        static void Main(string[] args)
	{
            Console.WriteLine("Hello world!");
	    int x = 15;
	    int y = 20;
	    if (x < y) {
		    Console.WriteLine("Booyah!");
	    }
            int z = Console.Read();
	    Console.WriteLine(z);
	    Console.Read();
        }
    }
}
