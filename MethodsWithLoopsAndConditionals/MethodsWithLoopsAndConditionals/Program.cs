using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //lukewarm 1
            PrintThousand();
            //lukewarm 2
            PrintThrees();
            //lukewarm 3
            EqualOrNot();
            //lukewarm 4
            EvenOrOdd();
            //lukewarm 5
            PosOrNeg();
            //lukewarm 6
            CanVote();

            //heatingup 1
            InRange();
            //heatingup 2
            MultTable();
        }
        //LukeWarm 1-6
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
        public static void EqualOrNot()
        {
            Console.WriteLine("enter a number:");
            var userIntA = int.Parse(Console.ReadLine());
            Console.WriteLine("enter another number:");
            var userIntB = int.Parse(Console.ReadLine());
            Console.WriteLine((userIntA == userIntB) ? "These are equal!" : "These are not equal!");
        }
        public static void EvenOrOdd()
        {
            Console.WriteLine("enter a number:");
            var userInt = int.Parse(Console.ReadLine());
            Console.WriteLine((userInt % 2 == 0) ? "This number is even!" : "This number is Odd!");
        }
        public static void PosOrNeg()
        {
            Console.WriteLine("enter a number:");
            var userInt = int.Parse(Console.ReadLine());
            Console.WriteLine((userInt >= 0) ? "This number is Positive!" : "This number is Negative!");
        }
        public static void CanVote()
        {
            Console.WriteLine("enter your age:");
            var userInt = int.Parse(Console.ReadLine());
            Console.WriteLine((userInt >= 18) ? "You are old enough to vote!" : "You can't vote yet!");
        }
        //HeatingUp 
        public static void InRange()
        {
            Console.WriteLine("enter a number:");
            var userInt = int.Parse(Console.ReadLine());
            Console.WriteLine((userInt <= 10 && userInt >= -10) ? "This number is in range!" : "This number is NOT in range!");
        }
        public static void MultTable()
        {
            Console.WriteLine("Enter a number to multiply:");
            var userInt = int.Parse(Console.ReadLine());
            for (int i = userInt; i <= 12; i++)
            {
                Console.Write(i + "\t");
                for (int j = 1; j <= 12; j++)
                {
                    if (i > 0) Console.Write(i * j + "\t");
                    else Console.Write(j + "\t");
                }
                Console.Write("\n");
            }
        }
    }   
}
