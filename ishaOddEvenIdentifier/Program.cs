using System;
using System.Collections.Generic;
namespace OddEven
{
    class oddEven
    {
        public static void Main(String[] args)
        {
            string aName; int aAge;

            //Console.WriteLine("How many numbers do you want to enter?");
            //identify(int.Parse(Console.ReadLine

            Person a = new Person("andy", 18);
            Person b = new Person("Dysp", 19);
            Person c;

            c = Person.GetPerson("cryo");

            Console.WriteLine("Enter Name: ");
            aName = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            aAge = int.Parse(Console.ReadLine());
            Person d = Person.GetPerson(aName, aAge);


            a.IntroduceSelf();
            b.IntroduceSelf();
            c.IntroduceSelf();
            d.IntroduceSelf();
                       
        }
        static int identify(int num)
        {
            int[] numberArr = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                numberArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The following numbers are:");

            foreach (var n in numberArr)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"{n} is an even number");
                }
                else
                {
                    Console.WriteLine($"{n} is an odd number");
                }
            
            } return num;
        }
    }

}