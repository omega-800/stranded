namespace Stranded.Locations
{
    public class Position
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;   
        }

        public void north()
        {
            y += 1;
        }

        public void east()
        {
            x += 1;
        }

        public void south()
        {
            y -= 1;
        }

        public void west()
        {
            x -= 1;
        }
    }
}