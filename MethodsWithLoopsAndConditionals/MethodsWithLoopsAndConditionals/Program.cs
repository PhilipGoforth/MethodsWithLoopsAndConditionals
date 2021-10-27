﻿using System;

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

            //HeatingUp 1
            Console.WriteLine("Enter a number:");
            userInt = int.Parse(Console.ReadLine());
            InRange(userInt);
            //HeatingUp 2
            Console.WriteLine("Enter a number to multiply:");
            userInt = int.Parse(Console.ReadLine());
            MultTable(userInt);
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
        public static void EqualOrNot(int userIntA, int userIntB)
        {
            var answer = (userIntA == userIntB) ? "These are equal!" : "These are not equal!";
            Console.WriteLine(answer);
        }
        public static void EvenOrOdd(int userInt)
        {
            var answer = (userInt % 2 == 0) ?  "This number is even!" :  "This number is Odd!";
            Console.WriteLine(answer);
        }
        public static void PosOrNeg(int userInt)
        {
            var answer = (userInt >= 0) ? "This number is Positive!" : "This number is Negative!";
            Console.WriteLine(answer);
        }
        public static void CanVote(int userInt)
        {
            var answer = (userInt >= 18) ? "You are old enough to vote!" : "You can't vote yet!";
            Console.WriteLine(answer);
        }
        //HeatingUp 
        public static void InRange(int userInt)
        { 
            var answer = (userInt <= 10 && userInt >= -10) ? "This number is in range!" : "This number is NOT in range!";
            Console.WriteLine(answer);
        }
        public static void MultTable(int userInt)
        {
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
