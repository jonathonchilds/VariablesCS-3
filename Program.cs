using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 3;
            var fullName = "Jonathon Kieran Childs";
            var todaysDate = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine($"{fullName} enjoyed {numberOfCupsOfCoffee} cups of coffee on {todaysDate}");
            Console.WriteLine();

            Console.Write("What is your name? ");
            var userName = Console.ReadLine();

            if (userName == "Alice")
            {
                Console.WriteLine($"WeLc0mE to tHE RabBit h0le, ALICE.");
            }
            else
            {
                Console.WriteLine($"Hey, {userName}!");
            }

            Console.WriteLine();

            Console.Write("Please enter a number: ");
            var firstNumberAsString = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please enter another number: ");
            var secondNumberAsString = Console.ReadLine();
            Console.WriteLine();

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            Console.WriteLine($"Your lil' numbers have a sum of {sum}, a difference of {difference}, a product of { product}, a quotient of { quotient}, and a remainder of { remainder}.");



        }
    }
}
