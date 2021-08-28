using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    public static class UI
    {
        public static void InvalidInputScreen(string wrongUserInput, int guessesLeft)
        {
            Console.WriteLine($"You wrote {wrongUserInput} which is not a number. Please enter a number");
            Console.WriteLine($"You have {guessesLeft} guesses left");
            Console.WriteLine();
            Console.WriteLine("Please Press any Key to continue and Try Again");
            Console.ReadKey();
            Console.Clear();
        }

        public static string GetUserGuess()
        {
            Console.WriteLine("Can you guess How many days we have left before the world ends?");
            string UserGuess = Console.ReadLine();
            return UserGuess;

        }

        public static void YouWin(int RandomNumberOut)
        {
            Console.WriteLine("Congratulations! /n You Win!");
            Console.WriteLine($"The world is ending in {RandomNumberOut} days!");
            Console.WriteLine("If it's any consolation you guessed correctly!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
