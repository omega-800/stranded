using Stranded.Locations;
using Stranded.Creatures;
using System.Drawing;

namespace Stranded
{
    public class Instance
    {
        private Map map;
        private Player player;
        private List<Enemy> enemyList = new List<Enemy>();
        private List<Animal> animalList = new List<Animal>();
        private List<Command> commands = new List<Command>();
        private int time;
        private Output output;

        public Map Map { get => map; set => map = value; }
        public Player Player { get => player; set => player = value; }
        public List<Enemy> EnemyList { get => enemyList; set => enemyList = value; }
        public List<Animal> AnimalList { get => animalList; set => animalList = value; }
        public List<Command> Commands { get => commands; set => commands = value; }
        public int Time { get => time; set => time = value; }

        public Instance()
        {
            time = 0;
            output = new Output();

            List<Room> rooms = new List<Room>();
            rooms.Add(new Room("water", ConsoleColor.DarkBlue, Color.Blue));
            rooms.Add(new Room("shallowWater", ConsoleColor.Blue, Color.Aqua));
            rooms.Add(new Room("sand", ConsoleColor.Yellow, Color.Yellow));
            rooms.Add(new Room("spawn", ConsoleColor.Magenta, Color.Purple));
            rooms.Add(new Room("woods", ConsoleColor.Green, Color.Green));
            rooms.Add(new Room("dirt", ConsoleColor.DarkYellow, Color.Brown));
            rooms.Add(new Room("mine", ConsoleColor.DarkRed, Color.White));
            rooms.Add(new Room("rock", ConsoleColor.Gray, Color.Gray));
            rooms.Add(new Room("mountain", ConsoleColor.DarkGray, Color.DarkSlateGray));

            map = new Map("C:\\Users\\anon\\Documents\\Code\\C#\\Stranded\\Stranded\\Stranded\\Img\\map.png", rooms);
            player = new Player("me", ConsoleColor.Magenta, "aargh", 10, 1, 10, 1, 1, new Position(5, 5), new Position(2, 2), 10);
            enemyList = new List<Enemy>();
            animalList = new List<Animal>();

            commands = new List<Command>();
            commands.Add(new Command(new List<string>() { "map", "m" }, false, () => map.display(this)));
            commands.Add(new Command(new List<string>() { "walk" }, true, () => player.walk("")));
        }

        public void handleInput (string input)
        {
            string[] inputs = input.Split(" ");

            switch (inputs[0])
            {
                case "walk":
                    player.walk(inputs[1]);
                    break;
                case "map" or "m":
                    map.display(this);
                    break;
                case "whereami":
                    for (int i = map.MapRows.Count -1; i > 0 ; i--)
                    {
                        for (int j = map.MapRows[i].Count -1; j > 0; j--)
                        {
                            
                            if (player.PositionMap.X == j && player.PositionMap.Y == i)
                            {
                                Console.Write(map.MapRows[i][j].Name+i.ToString()+j.ToString());
                            }
                        }
                    }
                    break;
                default:
                    break;
            }

            /*foreach (Command command in commands)
            {
                foreach (string argument in command.Arguments)
                {
                    if (inputs[0].Equals(argument))
                    {
                        if (command.Separator.Equals(""))
                        {
                            if (command.HasVariable)
                            {
                                command.runVar(command.Action, inputs[0]);
                            }
                            else
                            {
                                command.run();
                                break;
                            }
                        }
                        else
                        {
                            string[] separatedInputs = input.Split(command.Separator);

                        }
                    }
                }
            }*/
        }
    }
}