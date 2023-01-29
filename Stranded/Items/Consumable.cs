namespace Stranded.Items
{
    public class Consumable : Item
    {
        private Effect effect;

        protected Effect Effect { get => effect; set => effect = value; }

        public Consumable(string name, float weight, ConsoleColor color, Effect effect) : base(name, weight, color)
        {
            this.effect = effect;
        }
    }
}