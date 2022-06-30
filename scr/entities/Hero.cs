namespace OOP_JOGOSHARP.scr.entities
{

    public class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }


        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public override string ToString()
        {
            return $"Nome: {Name} \nLevel: {Level} \nHeroType: {HeroType}";
        }

        public virtual string Attack(int power)
        {
            int forcaAttack = power * 2;
            return this.Name + $"Atacou com sua espada... e retirou {forcaAttack} de dano.";
        }
    }

}