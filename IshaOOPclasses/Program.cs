using System;
using System.Security.Cryptography.X509Certificates;

namespace IshaOOPclasses
{
    class mainClass
    {
        public static void Main(string[] args)
        {
            Catto cat01 = new Catto();

            Console.WriteLine("You got a new cat!\nWhat would you like to name it?: ");
            cat01.name = Console.ReadLine();

            cat01.Behaviour();
            cat01.Play();

        }
    }
}