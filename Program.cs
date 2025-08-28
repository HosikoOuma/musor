// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hewwo! I am Hoshiko Ouma)");
using System;
using static System.Console;

namespace Name
{
    public class Program
    {
        public static void Main()
        {
            WriteLine("Hewwo! I am Hoshiko Ouma) What's your name?");
            string input = ReadLine();
            WriteLine("Hewwo, " + input + "!");
            WriteLine("What years old?");
            input = ReadLine();
            int yo = int.Parse(input);
            if (yo < 13)
            {
                WriteLine("You are too little, kiddo(");
            }
            else if (yo > 99)
            {
                WriteLine("You are... too old");
            }
            else
            {
                WriteLine("I love you");
            }
        }
    }
}
