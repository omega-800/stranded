using Stranded.Creatures;
using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Reflection;

namespace Stranded.Locations
{
    public class Map
    {
        private int width = 16;
        private int height = 16;
        private Dictionary<Position, Room> map = new Dictionary<Position, Room>();
        private List<List<Room>> mapRows = new List<List<Room>>();
        public Dictionary<Position, Room> Rooms { get => map; set => map = value; }
        public List<List<Room>> MapRows { get => mapRows; set => mapRows = value; }

        public Map(Dictionary<Position, Room> map)
        {
            this.map = map;
            generateRooms();
        }

        public Map(string path, List<Room> availableRooms)
        {
            createFromImage(path, availableRooms);
            generateRooms();
        }

        public void display(Instance gameInstance)
        {
            int pos = 0;
            for(int i = height; i >= 1; i--)
            {
                for(int j = 1; j <= width; j++)
                {
                    if(gameInstance.Player.PositionMap.X == j && gameInstance.Player.PositionMap.Y == i)
                    {
                        Console.ForegroundColor = map.ElementAt(pos).Value.ConsoleColor;
                        Console.Write("|");
                        Console.ForegroundColor = gameInstance.Player.ConsoleColor;
                        Console.Write("X");
                    } 
                    else
                    {
                        Console.ForegroundColor = map.ElementAt(pos).Value.ConsoleColor;
                        Console.Write("|"+i.ToString()+j.ToString()+map.ElementAt(pos).Value.Name+map.ElementAt(pos).Key.X.ToString()+ map.ElementAt(pos).Key.Y.ToString() );
                    }
                    pos+=1;
                }
                Console.Write("\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void createFromImage(string path, List<Room> availableRooms)
        {
            Bitmap img = new Bitmap(path);
            int pos = 0;
            for (int j = 0; j < img.Height; j++)
            {
                mapRows.Add(new List<Room>());
                for (int i = 0; i < img.Width; i++)
                {
                    Color pixel = img.GetPixel(i,j);
                    foreach (var room in availableRooms)
                    {
                        if (pixel.ToArgb() == room.Color.ToArgb())
                        {
                            map.Add(new Position(i+1, j+1), new Room(room.Name, room.ConsoleColor, room.Color, new Position(i+1,j+1)));
                            mapRows[pos].Add(new Room(room.Name, room.ConsoleColor, room.Color, new Position(i+1,j+1)));
                            break;
                        }
                    }
                }
                pos++;
            }
            Console.WriteLine(map.Count);
        }

        public void generateRooms()
        {
            /*foreach (KeyValuePair <Position, Room> tile in map)
            {
                string s = tile.Key.X.ToString();
                s += tile.Key.Y.ToString();
                tiles.Add(s, tile.Value);
            }*/
        }
    }
}