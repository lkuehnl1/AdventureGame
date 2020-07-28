// Decompiled with JetBrains decompiler
// Type: AdventureGameLibrary.Game
// Assembly: AdventureGameLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AACB473-DBE5-4A83-BCB6-AC1AE04C7FC9
// Assembly location: C:\Users\generalrenz\source\repos\AdventureGame\AdventureGame\bin\Debug\AdventureGameLibrary.dll

using System;

namespace AdventureGameLibrary
{
  public static class Game
  {
    private static string CharacterName = "John Doe";

    public static void StartGame()
    {
      Console.WriteLine("Encounter with Destiny!");
      Console.WriteLine("This will be an amazing adventure that will \nchallenge you to the core of your being");
      Game.NameCharacter();
    }

    private static void NameCharacter()
    {
      Game.Dialog("Please enter your character name:");
      Console.WriteLine("Your character's name is " + Console.ReadLine().ToUpper() + ". Phenomenal!");
      Console.ReadKey();
    }

    public static void TitleScreen()
    {
      Console.BackgroundColor = ConsoleColor.DarkGreen;
      Console.ForegroundColor = ConsoleColor.White;
      Console.Clear();
      Console.WriteLine("\r\n                           ___________.__            \r\n                           \\__    ___/|  |__   ____  \r\n                             |    |   |  |  \\_/ __ \\ \r\n                             |    |   |   Y  \\  ___/ \r\n                             |____|   |___|  /\\___  >\r\n                                           \\/     \\/ \r\n          _____       .___                    __                        \r\n         /  _  \\    __| _/__  __ ____   _____/  |_ __ _________   ____  \r\n        /  /_\\  \\  / __ |\\  \\/ // __ \\ /    \\   __\\  |  \\_  __ \\_/ __ \\ \r\n       /    |    \\/ /_/ | \\   /\\  ___/|   |  \\  | |  |  /|  | \\/\\  ___/ \r\n       \\____|__  /\\____ |  \\_/  \\___  >___|  /__| |____/ |__|    \\___  >\r\n               \\/      \\/           \\/     \\/                        \\/ \r\n           _____           .____    .__  _____       __  .__              ._.\r\n     _____/ ____\\ _____    |    |   |__|/ ____\\_____/  |_|__| _____   ____| |\r\n    /  _ \\   __\\  \\__  \\   |    |   |  \\   __\\/ __ \\   __\\  |/     \\_/ __ \\ |\r\n   (  <_> )  |     / __ \\_ |    |___|  ||  | \\  ___/|  | |  |  Y Y  \\  ___/\\|\r\n    \\____/|__|    (____  / |_______ \\__||__|  \\___  >__| |__|__|_|  /\\___  >_\r\n                       \\/          \\/             \\/              \\/     \\/\\/\r\n                              \r\n                            [Press Enter to Play]");
      Console.ReadKey();
      Console.Clear();
    }

    private static void Dialog(string message)
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine(message);
      Console.ResetColor();
    }

    private static void Dialog(string message, string color)
    {
      if (color == "red")
        Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(message);
      Console.ResetColor();
    }
  }
}
