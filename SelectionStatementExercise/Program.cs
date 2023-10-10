﻿namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game();
        }

        static void Game() {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber) Console.WriteLine("too low!");
            else if (userInput > favNumber) Console.WriteLine("too high!");
            else Console.WriteLine("You guessed it!");
        }
    }
}
