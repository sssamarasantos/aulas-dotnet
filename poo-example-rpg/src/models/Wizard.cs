namespace poo_example_rpg.src.models
{
    //herança: herda as propriedade e métodos da classe
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return this.Name + " lançou magia.";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
                return this.Name + " lançou uma super magia com bônus de ataque de " + bonus;
            else
                return this.Name + " lançou magia fraca com bônus de ataque de " + bonus;
        }
    }
}