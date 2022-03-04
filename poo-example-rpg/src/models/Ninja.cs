namespace poo_example_rpg.src.models
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        public override string Attack()
        {
            return this.Name + " lançou suas estrelas ninja.";
        }
    }
}