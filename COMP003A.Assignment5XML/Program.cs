/*
 * Author: Isaac Cruz
 * Course: COMP003A 
 * Purpose: Methods and XML comments
 */
namespace COMP003A.Assignment5XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator();
            Console.WriteLine("Insert a single character input: ");
            string input = Console.ReadLine();
            int userInput = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Insert a positive whole number: ");
            string output = Console.ReadLine();
            int Numberinput = Convert.ToInt32(Console.ReadLine());
            PrintSeparator();

            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("Favorite Characters Section");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("\n");

            Console.WriteLine("Michael J. Fox turns 63 this year!");
            Console.WriteLine("Dom Torreto turns 48 this year!");
            Console.WriteLine("Adam Sandler turns 58 this year!");
            Console.WriteLine("Jack Black turns 55 this year!");
            Console.WriteLine("Chris Bumstead turned 29 this year!");

        }

        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("".PadRight(50, '*'));
        }
        static void PrintSeparator(string parameter)
        {
            PrintSeparator();
            Console.WriteLine(parameter);
            PrintSeparator();
            /// output string parameter
        }
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            int x = 1;
            while (size < 1)
            {
                Console.WriteLine(size);
                x++;
            }
            Console.WriteLine($"{size}");

            int y = -1;
            while (size < 1)
            {
                Console.WriteLine(size);
                x--;
            }
            Console.WriteLine($"{size}");
            /// trying to do step 5 as best as i can
        }
        static void AgeCalculator(int year)
        {
            for (int current = 2023; current < year; current--)
            {
                Console.WriteLine(current);
            }
        }
    }
}
