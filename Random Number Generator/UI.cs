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

        public static void GuessAgain(int RandomNumber, int UserInput, int Counter)
        {
            Console.WriteLine($"We have only {RandomNumber} days left to Armegeddon");
            Console.WriteLine($"ONLY {RandomNumber} days and you guessed {UserInput} which is wrong");
            Console.WriteLine($"You have {Counter} guesses left");
            Console.WriteLine("");
            Console.WriteLine("Quit Wasting time and Guess Again!");
            Console.WriteLine("Please Press any Key to continue and Try Again");
            Console.ReadKey();
            Console.Clear();
        }

        public static string PlayAgain()
        {
            Console.WriteLine("Game Over");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Play Again?");
            Console.WriteLine("Type Y/N to continue");
            string UserAnswer = Console.ReadLine();
            return UserAnswer;
            Console.Clear();
        }

        public static void EndGame()
        {
            Console.WriteLine("Thanks for Playing!");
            Console.WriteLine("If you liked my game please donate to my programmers education fund!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

    }
}
