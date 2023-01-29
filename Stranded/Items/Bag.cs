namespace Stranded.Items
{
    public class Bag
    {
        private List<Item> items = new List<Item>();

        protected List<Item> Items { get => items; set => items = value; }

        public Bag(List<Item> items)
        {
            this.items = items;
        }

        public void addItem(Item item)
        {
            items.Add(item);
        }

        public Item popItem(int pos)
        {
            Item item = items.ElementAt(pos);
            items.RemoveAt(pos);
            return item;
        }

        public float getWeight()
        {
            float weight = 0;
            foreach (Item item in items){
                weight += item.Weight;
            }
            return weight;
        }
    }
}