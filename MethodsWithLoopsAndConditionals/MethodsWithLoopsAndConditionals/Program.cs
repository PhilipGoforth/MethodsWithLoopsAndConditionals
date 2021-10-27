using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //LukeWarm 1
            PrintThousand();
            //LukeWarm 2
            PrintThrees();
            //LukeWarm 3
            Console.WriteLine("Enter a number:");
            var userIntA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            var userIntB = int.Parse(Console.ReadLine());
            EqualOrNot(userIntA, userIntB);
            //LukeWarm 4
            Console.WriteLine("Enter a number:");
            var userInt = int.Parse(Console.ReadLine());
            EvenOrOdd(userInt);
            //LukeWarm 5
            Console.WriteLine("Enter a number:");
            userInt = int.Parse(Console.ReadLine());
            PosOrNeg(userInt);
            //LukeWarm 6
            Console.WriteLine("Enter your age:");
            userInt = int.Parse(Console.ReadLine());
            CanVote(userInt);
        }
        public static void PrintThousand()
        {
            for(int i = 1000; i > -1001; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintThrees()
        {
            for(int i = 3; i <= 999; i++)
            {
                if(i%3 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
            
        }
        public static void EqualOrNot(int userIntA, int userIntB)
        {
            if(userIntA == userIntB)
            {
                Console.WriteLine("These are equal!");
            }
            else
            {
                Console.WriteLine("These are not equal!");
            }
        }
        public static void EvenOrOdd(int userInt)
        {
            if(userInt%2 == 0)
            {
                Console.WriteLine("This number is even!");
            }
            else
            {
                Console.WriteLine("This number is Odd!");
            }
        }
        public static void PosOrNeg(int userInt)
        {
            if (userInt >= 0)
            {
                Console.WriteLine("This number is Positive!");
            }
            else
            {
                Console.WriteLine("This number is Negative!");
            }
        }
        public static void CanVote(int userInt)
        {
            if(userInt >= 18)
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else
            {
                Console.WriteLine("You can't vote yet!");
            }
        }
    }   
}
