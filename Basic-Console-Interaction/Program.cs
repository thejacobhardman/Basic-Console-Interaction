using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Console_Interaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean isRunning = true;

            while(isRunning)
            {
                Boolean userConfirm = false;
                string input = "";

                Console.WriteLine("Enter first integer: ");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second integer: ");
                int num2 = Int32.Parse(Console.ReadLine());

                int sum = num1 + num2;
                int product = num1 * num2;
                int difference = num1 - num2;
                int quotient = num1 / num2;

                Console.WriteLine("The sum of the two numbers is: " + sum);
                Console.WriteLine("The product of the two numbers is: " + product);
                Console.WriteLine("The difference of the two numbers is: " + difference);
                Console.WriteLine("The quotient of the two numbers is: " + quotient);

                while (userConfirm == false)
                {
                    Console.WriteLine("Would you like to run the program again? (Y/N)");
                    input = Console.ReadLine().ToUpper();

                    if (input == "Y")
                    {
                        userConfirm = true;
                        continue;
                    }
                    else if (input == "N")
                    {
                        userConfirm = true;
                        isRunning = false;
                        break;
                    } else
                    {
                        Console.WriteLine("I'm sorry, I don't understand.");
                    }
                }
            }
        }
    }
}
