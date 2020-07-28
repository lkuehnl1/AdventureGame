
using System;

namespace AdventureGameLibrary
{
    public static class Game
    {
        static string CharacterName;

        public static void ScreenSetup()
        {
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;
        }

        public static void StartGame()
        {
            
            TitleScreen();
            NameCharacter();
            Choice();
        }

        static void NameCharacter()
        {
            Console.WriteLine("What would you like to name your character?");
            CharacterName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Your character will be called " + CharacterName + ". Buckle up!\nPRESS ENTER TO CONTINUE.");
            Console.ReadKey();
            Console.Clear();
        }

        static void TitleScreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("\r\n                           ___________.__            \r\n                           \\__    ___/|  |__   ____  \r\n                             |    |   |  |  \\_/ __ \\ \r\n                             |    |   |   Y  \\  ___/ \r\n                             |____|   |___|  /\\___  >\r\n                                           \\/     \\/ \r\n          _____       .___                    __                        \r\n         /  _  \\    __| _/__  __ ____   _____/  |_ __ _________   ____  \r\n        /  /_\\  \\  / __ |\\  \\/ // __ \\ /    \\   __\\  |  \\_  __ \\_/ __ \\ \r\n       /    |    \\/ /_/ | \\   /\\  ___/|   |  \\  | |  |  /|  | \\/\\  ___/ \r\n       \\____|__  /\\____ |  \\_/  \\___  >___|  /__| |____/ |__|    \\___  >\r\n               \\/      \\/           \\/     \\/                        \\/ \r\n           _____           .____    .__  _____       __  .__              ._.\r\n     _____/ ____\\ _____    |    |   |__|/ ____\\_____/  |_|__| _____   ____| |\r\n    /  _ \\   __\\  \\__  \\   |    |   |  \\   __\\/ __ \\   __\\  |/     \\_/ __ \\ |\r\n   (  <_> )  |     / __ \\_ |    |___|  ||  | \\  ___/|  | |  |  Y Y  \\  ___/\\|\r\n    \\____/|__|    (____  / |_______ \\__||__|  \\___  >__| |__|__|_|  /\\___  >_\r\n                       \\/          \\/             \\/              \\/     \\/\\/\r\n                              \r\n                            [Press Enter to Play]");
            Console.ReadKey();
            Console.Clear();
        }

        static void Choice()
        {
            string input = "";
            Console.WriteLine( CharacterName + @", your blurred vision begins to focus and you realize you have become conscious of your surroundings. This is not a dream. Looking down you confirm that you are sitting in large chair, similar to a dentists chair. Your wrists are bound to the armrests of the chair and your feet are bound. The room you are in is dark, 
with only a single dim light hanging from the cobweb-laden ceiling. To your right is a small table with a rusted metal tray on it.
The tray contains a selection of surgical implements.The Tray is close enough that you may be able to grab one of the knives with your teeth." 
+ "\n" + @"Do you A) attempt escape or B) call for help ?");

            input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                Console.WriteLine("You've chosen path A!");
                Console.ReadLine();
            }
            if (input == "B")
            {
                Console.WriteLine("You've chosen path B!"); 
            }
            else
            {
                Console.WriteLine("Please enter a valid choice (A or B.)");
                Choice();
            }
            Console.ReadLine();
        }


    }
    class Item
    {

    }

}
    
  

