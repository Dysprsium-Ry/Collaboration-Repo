using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshaOOPclasses
{
    public class Catto
    {
        public string name;
        string choice;

        public void Behaviour()
        {
            Console.WriteLine("\nCongratulations, you named your new kitty!\n" + name + " likes the name you gave her.");
            Console.WriteLine(name + " now wants to play with you!");
        }

        public void Play()
        {
            Console.WriteLine($"\n{name} wants to play with you.\nA. Play with {name}\nB. Nah uh");
            choice = Console.ReadLine();

            if (choice.ToUpper() == "A")
            {
                Console.WriteLine($"You played with {name}! Plus 100 affection points!");
            }
            else
            {
                Console.WriteLine($"{name} went to take a nap");
            }
        }
    }
}
