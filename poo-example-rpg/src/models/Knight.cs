namespace poo_example_rpg.src.models
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
    }
}