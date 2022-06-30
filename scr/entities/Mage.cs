namespace OOP_JOGOSHARP.scr.entities
{
    public class Mage : Hero
    {
        public Mage(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack(int power)
        {
            int forcaAttack = power * 4;
            return this.Name + $"Atacou com sua magia... e retirou {forcaAttack} de dano.";
        }
    }
}