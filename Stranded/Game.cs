using Stranded.Creatures;
using Stranded.Locations;
using System.Drawing;

namespace Stranded
{
    public static class Game
    {
        public static void Main(string[] args)
        {
            startGame();
        }
        public static void startGame()
        {
           

            Instance gameInstance = new Instance();

            Console.WriteLine("Welcome. Type help for available commands.");

            while (true)
            {
                Console.Write("Type a command or type \"exit\" or \"x\" to exit: ");
                string input = Console.ReadLine().ToLower();
                if (input.Equals("exit") || input.Equals("x"))
                {
                    endGame();
                }
                gameInstance.handleInput(input);
                gameInstance.Time += 1;
                Console.Write(gameInstance.Time.ToString() + input);
            }
            //map = new Map();
            //map.createFromImage("../Img/map.png");
        }

        public static void endGame()
        {
            Environment.Exit(0);
        }
    }
}