using Stranded.Locations;

namespace Stranded.Creatures
{
    public class Creature
    {
        private string name = "";
        private ConsoleColor color;
        private string scream = "";
        private int health;
        private int damage;
        private int recovery;
        private int recoveryPoints;
        private int speed;
        private Position positionMap;
        private Position positionTile;
        private Output output;

        public string Name { get => name; set => name = value; }
        public ConsoleColor ConsoleColor { get => color; set => color = value; }
        public string Scream { get => scream; set => scream = value; }
        public int Health { get => health; set => health = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Recovery { get => recovery; set => recovery = value; }
        public int RecoveryPoints { get => recoveryPoints; set => recoveryPoints = value; }
        public int Speed { get => speed; set => speed = value; }
        internal Position PositionMap { get => positionMap; set => positionMap = value; }
        internal Position PositionTile { get => positionTile; set => positionTile = value; }

        public Creature(string name, ConsoleColor color, string scream, int health, int damage, int recovery, int recoveryPoints, int speed, Position positionMap, Position positionTile)
        {
            this.name = name;
            this.color = color;
            this.scream = scream;
            this.health = health;
            this.damage = damage;
            this.recovery = recovery;
            this.recoveryPoints = recoveryPoints;
            this.speed = speed;
            this.positionMap = positionMap;
            this.positionTile = positionTile;
            output = new Output();
        }

        public void walk(string direction) 
        {
            switch (direction)
            {
                case "n":
                    positionMap.north();
                    output.notification("You went north.\n");
                    break;
                case "e":
                    positionMap.east();
                    output.notification("You went east.\n");
                    break;
                case "s":
                    positionMap.south();
                    output.notification("You went south.\n");
                    break;
                case "w":
                    positionMap.west();
                    output.notification("You went west.\n");
                    break;
                default:
                    output.error("Invalid Argument. Possible Arguments: north, n, east, e, south, s, west, w\n");
                    break;
            }
        }

        public string shout() 
        {
            return name + " " + scream;
        }

        public int attack() 
        {
            return damage;
        }
    }
}