using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (args.Length > 0)
            //{
            //    Console.WriteLine($"Hello, {args[0]!}");
            //}
            //else
            //{
            //    Console.WriteLine("Hello!");
            //}

            //var x = 34.1;
            //var y = 10.3;
            // Implicity-typed variables must be initialized.
            //var result = x + y;
            // Result: 44.400000000000006
            // TODO: Rounding to 44.4 ?
            //Console.WriteLine(result);
            Console.WriteLine(34.1 + 10.3);

            Console.WriteLine("----------");

            double doubleOne = 34.1;
            double doubleTwo = 10.3;
            double doubleResult = doubleOne + doubleTwo;
            Console.WriteLine(doubleResult);

            Console.WriteLine("----------");

            //double[] numbers = new double[3];
            //double[] numbers = new double[] { 12.7, 10.3, 6.11 };
            double[] numbers = new[] { 12.7, 10.3, 6.11, 4.1 };

            //numbers[0] = 12.7;
            //numbers[1] = 10.3;
            //numbers[2] = 6.11;

            //var result = numbers[0];
            //result += numbers[1];
            //result += numbers[2];
            //result = result + numbers[1];
            //result = result + numbers[2];

            double result = 0.0;
            foreach (double number in numbers)
            {
                result += number;
            }
            Console.WriteLine(result);

            double x = 0;
            x = x + 3.1;

            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            //Console.WriteLine(grades[0]);
            foreach (var number in grades)
            {
                result += number;
            }
            //result = result / grades.Count;
            result /= grades.Count;
            Console.WriteLine(result); //89.31 //17.862
            Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}

// using System.Collections.Generic;
