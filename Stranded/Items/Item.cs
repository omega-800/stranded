namespace Stranded.Items
{
    public class Item
    {
        private string name = "";
        private float weight;
        private ConsoleColor color;

        public string Name { get => name; set => name = value; }
        public float Weight { get => weight; set => weight = value; }
        public ConsoleColor ConsoleColor { get => color; set => color = value; }

        public Item(string name, float weight, ConsoleColor color)
        {
            this.name = name;
            this.weight = weight;
            this.color = color;
        }
    }
}