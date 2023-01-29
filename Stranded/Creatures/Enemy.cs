using Stranded.Items;
using Stranded.Locations;

namespace Stranded.Creatures
{
    public class Enemy : Creature
    {
        private Weapon weapon;

        public Weapon Weapon { get => weapon; set => weapon = value; }

        public Enemy(string name, ConsoleColor color, string scream, int health, int damage, int recovery, int recoveryPoints, int speed, Position positionMap, Position positionTile, Weapon weapon)
            : base(name, color, scream, health, damage, recovery, recoveryPoints, speed, positionMap, positionTile)
        {
            this.weapon = weapon;
        }
    }
}