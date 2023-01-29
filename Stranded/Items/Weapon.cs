namespace Stranded.Items
{
    public class Weapon : Item
    {
        private float damage;
        private float combo;
        private float multiplier;

        public float Damage { get => damage; set => damage = value; }
        public float Combo { get => combo; set => combo = value; }
        public float Multiplier { get => multiplier; set => multiplier = value; }

        public Weapon(string name, float weight, ConsoleColor color, float damage, float combo, int multiplier) : base(name, weight, color)
        {
            this.damage = damage;
            this.combo = combo;
            this.multiplier = multiplier;
        }
    }
}