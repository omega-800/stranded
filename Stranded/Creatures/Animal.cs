using Stranded.Items;
using Stranded.Locations;

namespace Stranded.Creatures
{
    public class Animal : Creature
    {
        private Item fur;
        private Item teeth;
        private Consumable meat;

        public Item Fur { get => fur; set => fur = value; }
        public Item Teeth { get => teeth; set => teeth = value; }
        public Consumable Meat { get => meat; set => meat = value; }

        public Animal(string name, ConsoleColor color, string scream, int health, int damage, int recovery, int recoveryPoints, int speed, Position positionMap, Position positionTile, Item fur, Item teeth, Consumable meat)
            : base(name, color, scream, health, damage, recovery, recoveryPoints, speed, positionMap, positionTile)
        {
            this.fur = fur;
            this.teeth = teeth;
            this.meat = meat;
        }
    }
}