using System;

namespace GuessANumber
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number between 1 and 10: ");
            int userValue = int.Parse(Console.ReadLine());


            string message = ( userValue == 8) ? "You Win!" : "You Lose.";
            Console.WriteLine(message);
            Console.ReadLine();
            
            //if (!userValue == 8)

            //{
            //    Console.WriteLine("You Lose.");
            //    Console.ReadLine();
            //}

            //else if (userValue == 8)
            //{
            //}
            //Console.WriteLine("You Win!");
            //Console.ReadLine();

            // If they enter 8, output “You Win!”. Otherwise, output “You Lose.”. Do this using an inline if statement.

            Console.ReadLine();
        }
    }
}
