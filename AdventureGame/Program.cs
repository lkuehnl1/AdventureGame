using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Encounter with Destiny!");
            Console.WriteLine("This will be an amazing adventure " +
                "that will \nchallenge you to the core of your being");
            Console.WriteLine("Please enter your name");
            string CharacterName = Console.ReadLine();
            
            Console.WriteLine("Your name is " + CharacterName.ToUpper() + ". Phenomenal!");
            Console.ReadKey();

           
        }
    }
}
