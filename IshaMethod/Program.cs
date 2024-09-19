/* using System;
    
    namespace IshaMethod
{ 
    class Meth
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            testMethod(Console.ReadLine());

            Console.WriteLine("\nHow old are ya, rookie?");
            Age(Convert.ToInt32(Console.ReadLine()));

        }
        public static void testMethod(string fname)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Welcome to programming, {fname}!");
            }
            
        }
        public static void Age(int age)
        {
            if (age < 20)
            {
                Console.WriteLine("You're quite young, rookie.\nYou got a great future ahead of you!");
            }
            else
            {
                Console.WriteLine("Dang, you're old. Nothing wrong with that though haha!");
            }
        }
    }
} */