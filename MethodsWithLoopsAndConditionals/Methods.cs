using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        public static void Spacing()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------- Next Exercise -----------------------");
            Console.WriteLine();
            
        }

        //Write a method that will print to the console all numbers 1000 through -1000
        public static void AllNumbers1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Print3()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not
        public static void EqualOrNot()
        {
            Console.Write("Please enter a number:");
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter another number:");
            var num2 = int.Parse(Console.ReadLine());


            if (num1 == num2)
            {
                Console.WriteLine("The numbers you entered are equal to each other.");
            }
            else
            {
                Console.WriteLine("The numbers you entered are NOT equal to each other.");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd()
        {
                Console.Write("Please enter a number:");
                var userInput = int.Parse(Console.ReadLine());

            if (userInput%2 == 0)
            {
                Console.WriteLine("You entered an even number.");
            }
            else
            {
                Console.WriteLine("You entered an odd number.");
            }
        }
        //Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative()
        {
            Console.Write("Please enter a number:");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput>=0)
            {
                Console.WriteLine("You have entered a positive number.");
            }
            else
            {
                Console.WriteLine("You have entered a negative number.");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void Vote()
        {
            Console.Write("Please enter your age:");
            var age = int.Parse(Console.ReadLine());

            if (age<18)
            {
                Console.WriteLine("Sorry, you are too young to vote.  Maybe next year.");
            }
            else
            {
                Console.WriteLine("Yeah!  You are old enough to vote.  See you at the polls.");
            }
        }
        //Write a method to check if an integer (from the user) is in the range -10 to 10

        public static void Range()
        {
            Console.Write("Please enter a number:");
            var num = int.Parse(Console.ReadLine());

            if (num <= 10 && num >= -10)
            {
                Console.WriteLine("The number you entered is in the range between -10 to 10.");
            }
            else
            {
                Console.WriteLine("The number you entered is outside of the range -10 to 10.");
            }
        }

        public static void MultiplicationTable()
        {
            Console.Write("Please enter a number to see the multiplication table of that number:");
            int userInput = int.Parse(Console.ReadLine());
            int x = 1;
            while (x<=12)
            {
                Console.WriteLine($"{userInput} * {x} = {userInput*x}");
                x++;
            }
        }
            


    }

}
