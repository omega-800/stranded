using Stranded.Items;
using Stranded.Locations;

namespace Stranded.Creatures
{
    public class Player : Creature
    {
        private Bag inventory;   
        private Weapon weapon;
        private int maxWeight;
        private List<Effect> activeEffects;

        public Bag Inventory { get => inventory; set => inventory = value; }
        public Weapon Weapon { get => weapon; set => weapon = value; }
        public int MaxWeight { get => maxWeight; set => maxWeight = value; }
        public List<Effect> ActiveEffects { get => activeEffects; set => activeEffects = value; }

        public Player(string name, ConsoleColor color, string scream, int health, int damage, int recovery, int recoveryPoints, int speed, Position positionMap, Position positionTile, int maxWeight) 
            : base(name, color, scream, health, damage, recovery, recoveryPoints, speed, positionMap, positionTile)
        {
            this.maxWeight = maxWeight;
            inventory = new Bag(new List<Item>());
            activeEffects = new List<Effect>();
            weapon = new Weapon("fists", 0, ConsoleColor.DarkYellow, 1, 5, 2);
        }

        public void pickUp(Item item)
        {
            inventory.addItem(item);
        }

        public bool canPickUp(Item item)
        {
            if(inventory.getWeight() + item.Weight > MaxWeight)
            {
                return false;
            } 
            else
            {
                return true;
            }
        }

        public void craft(Item item)
        {

        }

        public bool canCraft(Item item)
        {
            return false;
        }

        public void consume(Consumable consumable)
        {
            
        }
    }
}