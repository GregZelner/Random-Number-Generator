using System;

namespace Random_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Wr
            int TestInt = 5;

            Console.WriteLine("Hello we have {0} days to Armegeddon",TestInt);
            Random RandomNumber=new Random();
            RandomNumber.Next(0,100);

            Console.WriteLine(RandomNumber);

            Console.WriteLine("Hello World".Length);
            string UserInput= Console.ReadLine();
            Console.WriteLine(UserInput.Length);

        }
    }
}
