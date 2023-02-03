using System;
using System.Diagnostics.Metrics;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        
        {
            // Random Number guessing  
            var r = new Random();
            int userInput;
            var counter = 1;
            string s1 = "N";
            string s2;
            do
            {
                var favNumber = r.Next(1, 10);
                Console.WriteLine("Pick the number I am thinking of between 1 and 10 to escape this Groundhog's Day loop");
                do
                {

                    userInput = int.Parse(Console.ReadLine());

                    if (userInput < favNumber)
                    {
                        Console.WriteLine($"{userInput} is too low");
                        Console.WriteLine($"You have guessed {counter} times. Try again!");
                    }
                    else if (userInput > favNumber)
                    {
                        Console.WriteLine($"{userInput} is too high");
                        Console.WriteLine($"You have guessed {counter} times.  Try again!");
                    }

                    counter++;


                } while (userInput != favNumber);

                Console.WriteLine("You WIN!!");
                Console.WriteLine("Play again? Y/N?");
                s2 = (Console.ReadLine());

                 if (s2 == "y")
                {
                    Console.WriteLine("Alright I am picking another number");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine();
                }
                else 
                {
                  s2 = s1;
                }
                     
                        

            } while (!s1.Equals(s2));

            Console.WriteLine("Have a Great Day");

                
        
            }


    }
}
