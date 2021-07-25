using System;

namespace Random_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           //int TestInt = 5;

            
            Random RandomNumber=new Random();
            int x = RandomNumber.Next(0,100);

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
            if (InputsNumericValue == x);
                {
                Console.WriteLine($"The world is ending in {x} days!");
                Console.WriteLine("If it's any consolation you guessed correctly!");

            }

            //Code below will be for what I want to tell the user if they are wrong
            while (InputsNumericValue != x);
                {
                Console.WriteLine("We have only {0} days left to Armegeddon", x);
                Console.WriteLine($"ONLY {x} days and you guessed {UserInput} which is wrong");
                Console.WriteLine("Quit Wasting time and Guess Again!");
                String UserInput2 = Console.ReadLine();

                bool Result2;
                int InputsNumericValue2;

                Result2 = int.TryParse(UserInput, out InputsNumericValue2);
                Console.WriteLine("String is a numeric representation: " + Result2);
            }
            int variablefornumberoftimesloopran= 5;
            Console.WriteLine("You finally guessed correctly");
            Console.WriteLine($"It only took you {variablefornumberoftimesloopran} tries so I guess you're not that dumb");

            //Random stuff below/
            //Console.WriteLine("Hello World".Length);
            //string UserInput2= Console.ReadLine();
            //Console.WriteLine(UserInput.Length);

        }
    }
}
