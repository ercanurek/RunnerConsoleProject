using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SumOfMultiple;
using SequenceAnalysis;

namespace Runner_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            do
            {
                userInput = DisplayMenu();
                if (userInput == 1)
                {
                    SumOfMultiple();
                }
                else if (userInput == 2)
                {
                    SequenceAnalysis();
                }
            } while (userInput != 3);
        }

        // Find the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input.
        static private void SumOfMultiple()
        {
            int divisor1 = 3;
            int divisor2 = 5;
            // least common multiple of divisors
            // !!! - it will be used for subtracting at the end- !!!
            int lcm_divisor = divisor1 * divisor2;
            double d_input;
            int output;
            Console.WriteLine("Enter a number to find sum of all natural numbers that are a multiple of 3 or 5 below: ");
            if (double.TryParse(Console.ReadLine(), out d_input))
            {
                Console.WriteLine("Input value is: " + d_input);
                // Evaluates sum of div1 and div2 and subtract LCM of div1 and div2 !!! since it says that "3 or 5" <- important point...
                int input = (int)(Math.Ceiling(d_input));
                output = Sum.evalSum(input, divisor1) +
                    Sum.evalSum(input, divisor2) -
                    Sum.evalSum(input, lcm_divisor); // <- important point...
                Console.WriteLine("Output: " + output);
            }
            else
            {
                Console.WriteLine("It should be a natural number!");
            }
        }

        //Find the uppercase words in a string, provided as input, and order all characters in these words alphabetically.
        static private void SequenceAnalysis()
        {
            string str;
            Console.WriteLine("Enter a sentence/word to get all uppercase letters in order: ");
            str = Console.ReadLine();
            str = Uppercase.findUppers(str); // first find uppercase chars
            str = Uppercase.Alphabetize(str); // then sort it in a char array
            Console.WriteLine("Output: " + str);
        }

        static private int DisplayMenu()
        {
            // It will ask the user which of the problems below to solve.
            // 1: SumOfMultiple
            // 2: SequenceAnalysis
            Console.WriteLine("Which of the problems below do you want to solve?");
            Console.WriteLine();
            Console.WriteLine("1. SumOfMultiple");
            Console.WriteLine("2. SequenceAnalysis");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Please enter a valid choice!");
                return 0;
            }
        }
    }
}
