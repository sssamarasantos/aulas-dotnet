namespace poo_example_rpg.src.models
{
     //abstract: classe que não pode ser instanciada e sim herdada para outra classe
    public abstract class Hero
    {
        public Hero()
        {

        }
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HealthPoint { get; set; }
        public int MagicPoint { get; set; }

        //override: método que subescreve outro método de uma classe pai
        public override string ToString()
        {
            return this.Name;
        }
        //virtual: permite que uma método seja subescrito(override )
        public virtual string Attack()
        {
            return this.Name + " atacou com a sua espada.";
        }
    }
}