
using System;

namespace TutorApplication
{
    class Launcher
    {
        static void Main()
        {
            Console.SetWindowSize(100, 50);
            Console.WriteLine("Press any key to start the fight.");
            Console.ReadKey();
            var game = new Game();
            game.Start();
            Console.ReadLine();
        }
    }
}
