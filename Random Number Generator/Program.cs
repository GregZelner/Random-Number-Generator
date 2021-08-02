using System;

namespace Random_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {


            Random RandomNumber = new Random();
            int x = RandomNumber.Next(0, 100);

            Console.WriteLine("Can you guess How many days we have left?");
            String UserInput = Console.ReadLine();

            //The code below will test UserInput to see if what was typed can be converted to an integer
            //First the Bool and Int variables have to be created, so I create a variable name result and a variable named InputsNumericValue
            //TryParse has two outputs a boolean value ie T/F and a numeric value.
            bool Result;
            int InputsNumericValue;

            Result = int.TryParse(UserInput, out InputsNumericValue);
            Console.WriteLine("String is a numeric representation: " + Result);

            //Code below will be for what I want to tell the user if they are correct
            if (InputsNumericValue == x)
            {
                Console.WriteLine($"The world is ending in {x} days!");
                Console.WriteLine("If it's any consolation you guessed correctly!");

            }

            Console.WriteLine("We have only {0} days left to Armegeddon", x);
            Console.WriteLine($"ONLY {x} days and you guessed {UserInput} which is wrong");
            Console.WriteLine("Quit Wasting time and Guess Again!");

            //Code below will be for what I want to tell the user if they are wrong

            bool Result2;
            int InputsNumericValue2 = 0;
            int Counter = 0;
            while (InputsNumericValue2 != x && Counter < 5)
            {

                String UserInput2 = Console.ReadLine();
                //Code below trys to convert users 2nd guess to an integer                
                Result2 = int.TryParse(UserInput2, out InputsNumericValue2);
                Console.WriteLine("String is a numeric representation: " + Result2);
                Console.WriteLine("We have only {0} days left to Armegeddon", x);
                Console.WriteLine($"ONLY {x} days and you guessed {UserInput2} which is wrong");
                Console.WriteLine("Quit Wasting time and Guess Again!");
                Counter++;
            }

            if (InputsNumericValue2 == x)
            {
                int variablefornumberoftimesloopran = Counter + 1;
                Console.WriteLine("You finally guessed correctly");
                Console.WriteLine($"It only took you {variablefornumberoftimesloopran} tries");
                Console.WriteLine("Congratulations!, you're not a complete moron");
            }
            if (Counter == 5)
            {
                Console.WriteLine("I regret to inform you but you have failed");
                Console.WriteLine("Fortunately, the world does not depend on you");
                Console.WriteLine("Because YOU are an idiot!!!!");

            }

            // Project completed but can be improved...
            // with condition statement if(guess<random#x) do... if(guess>random#x) do...
            // I would also like to add space between lines for better User Experience.


            //Random stuff below/
            //Console.WriteLine("Hello World".Length);
            //string UserInput2= Console.ReadLine();
            //Console.WriteLine(UserInput.Length);

        }
    }
}
