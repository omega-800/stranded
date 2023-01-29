namespace Stranded
{
    public class Effect
    {
        private int health;
        private int recovery;
        private int recoveryPoints;
        private int speed;
        private int damage;

        public int Health { get => health; set => health = value; }
        public int Recovery { get => recovery; set => recovery = value; }
        public int RecoveryPoints { get => recoveryPoints; set => recoveryPoints = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Damage { get => damage; set => damage = value; }

        public Effect(int health, int recovery, int recoveryPoints, int speed, int damage)
        {
            this.health = health;
            this.recovery = recovery;
            this.recoveryPoints = recoveryPoints;
            this.speed = speed;
            this.damage = damage;
        }
    }
}