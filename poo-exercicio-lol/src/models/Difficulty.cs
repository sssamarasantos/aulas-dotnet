namespace poo_exercicio_lol.src.models
{
    public class Difficulty
    {
        public Difficulty()
        {

        }
        public Difficulty(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public Difficulty AddDifficulty(int id, string name)
        {
            return new Difficulty(
                Id = id,
                Name = name
            );
        }
    }
}