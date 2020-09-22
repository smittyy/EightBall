using System;

namespace EightBall
{
    class Program
    {
        public static Random randomObject = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QuestionLoop();
        }

        static string GetQuestionFromUser()
        {
            Console.WriteLine("What question do you wish to ask the all mighty.");
            string questionString = Console.ReadLine();
            return questionString;
        }

        static void QuestionLoop()
        {
            while (true)
            {
                string questionString = GetQuestionFromUser();
                int randomNumber = randomObject.Next(6);
                switch (randomNumber)
                {
                    case 0:
                        Console.WriteLine("No");
                        break;
                    case 4:
                        Console.WriteLine("Yes");
                        break;
                    case 2:
                        Console.WriteLine("Mayhaps");
                        break;
                    case 5:
                        Console.WriteLine("Ask again later");
                        break;
                    case 3:
                        Console.WriteLine("Please try again");
                        break;
                    case 1:
                        Console.WriteLine("I Come");
                        break;
                    default:
                        Console.WriteLine("That doesn't make any sense");
                        break;
                }

            }
        }
    }
}
