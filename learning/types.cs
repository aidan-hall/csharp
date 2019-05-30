using System;

class Cool
{
    static void Main(string[] args)
    {
        // Here we can recap type basics very briefly.
        string message = "Hello world!";
        string upperMessage = message.ToUpper();
        Console.WriteLine(upperMessage);

        int age = 16;

        string newmessage = message + " " + age.ToString();
        Console.WriteLine(newmessage);

        bool legal = false;

        if (age >= 16)
            legal = true;

        if (legal)
            Console.WriteLine("Go ahead, Mr Joestar.");
        else
            Console.WriteLine("Oh no!");



    }
}
