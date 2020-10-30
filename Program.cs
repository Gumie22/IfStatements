//This is a C# program exploring if statements and booleans

using System;

namespace program_2.cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            {
                Console.WriteLine("Your are neither male nor tall");
            }
        }
    }
}