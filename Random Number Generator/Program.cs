using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rng = new Random();
            int RandomNumber = Rng.Next(0, 100);


            //The code below will test UserInput to see if what was typed can be converted to an integer
            //First the Bool and Int variables have to be created, so I create a variable name result and a variable named InputsNumericValue
            //TryParse has two outputs a boolean value ie T/F and a numeric value.

            bool Result;
            int InputsNumericValue = -1;
            int Counter = 10;

            //Console.WriteLine("String is a numeric representation: " + Result);
            while (InputsNumericValue != RandomNumber && Counter > 0)
            {
                Console.WriteLine("Can you guess How many days we have left?");
                String UserInput = Console.ReadLine();
                Result = int.TryParse(UserInput, out InputsNumericValue);

                if (Result == false)
                {
                    Console.WriteLine($"You wrote {UserInput} which is not a number.");
                    Console.WriteLine($"You have {Counter} guesses left");
                    Console.WriteLine("Please Try Again");
                    Counter--;

                }


                if (Result == true && InputsNumericValue == RandomNumber)
                {
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine($"The world is ending in {RandomNumber} days!");
                    Console.WriteLine("If it's any consolation you guessed correctly!");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    break;
                }

                //Right here I'd like to add a guess too low/ too high check but else statements dont have this option...                 //Right here I'd like to add a guess too low/ too high check but else statements dont have this option...
                //I'm thinking to make an if statement inside the else where instead of it saying which is wrong,
                // it'll say "is too low" or "is too high"
                if (Result == true && InputsNumericValue != RandomNumber)
                {
                    Console.WriteLine($"We have only {RandomNumber} days left to Armegeddon");
                    Console.WriteLine($"ONLY {RandomNumber} days and you guessed {UserInput} which is wrong");
                    Console.WriteLine($"You have {Counter} guesses left");
                    Console.WriteLine("Quit Wasting time and Guess Again!");
                    Counter--;
                }

            }
            //I want it to clear all text and say Thanks for playing.. Play again? (Y/N)
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine();
            Console.WriteLine("Do you want to play again?");
            Console.WriteLine("Y/N");
            Console.ReadLine();
            //if ("Y" == start over )
            //        {
            //}

            //        else
            //{
            //    end game
            //        }

        }


        //OLD CODE BELOW:
        //
        //                   else
        //                        Console.WriteLine($"We have only {RandomNumber} days left to Armegeddon");
        //                    Console.WriteLine($"We have only {RandomNumber} days left to Armegeddon");
        //                    Console.WriteLine($"ONLY {RandomNumber} days and you guessed {UserInput} which is wrong");
        //                    Console.WriteLine("Quit Wasting time and Guess Again!");
        //                    Console.ReadKey();

        //                }


        //            }

        //        }
        //            //Code below will be for what I want to tell the user if they are correct
        //            if (InputsNumericValue == RandomNumber)
        //            {
        //                Console.WriteLine($"The world is ending in {RandomNumber} days!");
        //                Console.WriteLine("If it's any consolation you guessed correctly!");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"We have only {RandomNumber} days left to Armegeddon");
        //                Console.WriteLine($"ONLY {RandomNumber} days and you guessed {UserInput} which is wrong");
        //                Console.WriteLine("Quit Wasting time and Guess Again!");
        //                Console.ReadKey();
        //            }

        ////Code below will be for what I want to tell the user if they are wrong

        //bool Result2;
        //int InputsNumericValue2 = 0;
        //int Counter = 0;
        //while (InputsNumericValue2 != RandomNumber && Counter < 5)  //remove the win check from here
        //{
        //    String UserInput2 = Console.ReadLine();
        //    //Code below trys to convert users 2nd guess to an integer                
        //    Result2 = int.TryParse(UserInput2, out InputsNumericValue2);
        //    Console.WriteLine("String is a numeric representation: " + Result2);
        //    Console.WriteLine("We have only {0} days left to Armegeddon", RandomNumber);
        //    //if correct guess, congratulate and break loop

        //    //if too high, else if too low

        //    Console.WriteLine($"ONLY {RandomNumber} days and you guessed {UserInput2} which is wrong");
        //    Console.WriteLine("Quit Wasting time and Guess Again!");

        //    Counter++;
        //}

        //if (InputsNumericValue2 == RandomNumber)
        //{
        //    int variablefornumberoftimesloopran = Counter + 1;
        //    Console.WriteLine("You finally guessed correctly");
        //    Console.WriteLine($"It only took you {variablefornumberoftimesloopran} tries");
        //    Console.WriteLine("Congratulations!, you're not a complete moron");
        //}
        //if (Counter == 5)
        //{
        //    Console.WriteLine("I regret to inform you but you have failed");
        //    Console.WriteLine("Fortunately, the world does not depend on you");
        //    Console.WriteLine("Because YOU are an idiot!!!!");

        //}

        // Project completed but can be improved...
        // with condition statement if(guess<random#x) do... if(guess>random#x) do...
        // I would also like to add space between lines for better User Experience.


        //Random stuff below/
        //Console.WriteLine("Hello World".Length);
        //string UserInput2= Console.ReadLine();
        //Console.WriteLine(UserInput.Length);

    }
}

