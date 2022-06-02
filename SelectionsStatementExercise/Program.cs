using System;

namespace SelectionsStatementExercise
{
    class Program
    {
        static void Main(string[] args)
        { //Number Guessing Game

            { //Number Guessing Game
                //{ //Number Guessing Game

                //    var r = new Random();
                //    var favNumber = r.Next(1, 10);


                //    Console.WriteLine("Pick a number from 1 - 1000");
                //    var userInput = int.Parse(Console.ReadLine());

                //    if (userInput < favNumber)
                //    {
                //        Console.WriteLine($"{userInput} is too low");
                //    }
                //    else if (userInput > favNumber)
                //    {
                //        Console.WriteLine($"{userInput} is to high");
                //    }
                //    else
                //    {
                //        Console.WriteLine("You guessed it");
                //    }

                Console.WriteLine("What is your favorite subject?");

                string subject = Console.ReadLine();

                switch (subject.ToLower())
                {
                    case "math":
                        Console.WriteLine("I hate Math!");
                        break;

                    case "science":
                    case "physics":
                    case "astronomy":
                        Console.WriteLine("I love science");
                        break;

                    case "pe":
                        Console.WriteLine("ps is the best");
                        break;
                    case "history":
                        Console.WriteLine("History is fun");
                        break;
                    case "english":
                        Console.WriteLine("english is boring");
                        break;
                    default:
                        Console.WriteLine("I don't know that subject");
                        break;

                }
                

                
              
                
            }
        }
    }
}