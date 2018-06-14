using System;
using ConsoleCalculator.Math;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Console Calculator!\n");

            ConsoleKeyInfo problemTypeInput;
            ProblemType? problemType = null;

            do {
                Console.WriteLine("Please enter the number of your desired problem type.");
                Console.WriteLine("1) Multiplication");
                Console.WriteLine("2) Square\n");
                problemTypeInput = Console.ReadKey();

                if (problemTypeInput.Key == ConsoleKey.D1 || problemTypeInput.Key == ConsoleKey.NumPad1)
                    problemType = ProblemType.MULTIPLICATION;
                else if (problemTypeInput.Key == ConsoleKey.D2 || problemTypeInput.Key == ConsoleKey.NumPad2)
                    problemType = ProblemType.SQUARE;
                else
                {
                    problemType = null;
                    Console.WriteLine("\n\nAn invalid key was selected. Please try again.\n\n");
                }
            } while (problemType == null);

            MultiplicationProblem problem = new MultiplicationProblem();
            int num1, num2;
            string input1, input2, answer = "";

            switch (problemType)
            {
                case ProblemType.MULTIPLICATION:
                    do {
                        Console.WriteLine("\n\nWhat is the number that you would like to multiply?");
                        input1 = Console.ReadLine();
                    } while (!int.TryParse(input1, out num1));

                    do
                    {
                        Console.WriteLine("\n\nWhat would you like to multiply it by?");
                        input2 = Console.ReadLine();
                    } while (!int.TryParse(input2, out num2));

                    problem = new MultiplicationProblem(num1, num2);
                    answer = problem.Calculate().ToString();
                    break;
                case ProblemType.SQUARE:
                    do
                    {
                        Console.WriteLine("\n\nWhat is the number that you would like to square?");
                        input1 = Console.ReadLine();
                    } while (!int.TryParse(input1, out num1));

                    problem = new SquareProblem(num1);
                    answer = (problem as SquareProblem).Calculate().ToString();
                    break;
                default:
                    Console.WriteLine("\nYou never should have arrived here. Are you a wizard?\n");
                    break;
            }

            Console.WriteLine("\nThe result is: {0}", answer);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
