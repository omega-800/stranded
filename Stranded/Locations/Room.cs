using System.Drawing;

namespace Stranded.Locations
{
    public class Room
    {
        private string name = "";
        private ConsoleColor consoleColor;
        private Color color;
        private int width = 3;
        private int height = 3;
        private Position position;

        public string Name { get => name; set => name = value; }
        public ConsoleColor ConsoleColor { get => consoleColor; set => consoleColor = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public Color Color { get => color; set => color = value; }
        public Position Position { get => position; set => position = value; }
        public Room(string name, ConsoleColor consoleColor, Color color)
        {
            this.name = name;
            this.consoleColor = consoleColor;
            this.color = color;
        }

        public Room(string name, ConsoleColor consoleColor, Color color, Position position)
        {
            this.name = name;
            this.consoleColor = consoleColor;
            this.color = color;
            this.position = position;
        }
        
        public void display()
        {
            Dictionary<int, string> roomString = new Dictionary<int, string>();
            for (int i = 1; i <= height; i++)
            {
                string line = "";
                for (int j = 1; j <= width; j++)
                {
                    line += "|_";
                }
                roomString.Add(i, line);
            }
            string output = "";
            for(int i = roomString.Count; i <= 1; i--)
            {
                output += roomString.ElementAt(i).Key;
                output += "\n";
            }
            Console.WriteLine(output);
        }
    }
}