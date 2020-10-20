using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);
            //Console.WriteLine("This is a sentence");
            if (args.Length > 0)
            {
                System.Console.WriteLine("if");
                Console.WriteLine($"Sentence with {args[0]} in the string");
            }
            else
            {
                System.Console.WriteLine("else");
            }
        }
    }
}

// dotnet run
// dotnet run -- ArgumentOne ArgumentTwo
// launch.json
