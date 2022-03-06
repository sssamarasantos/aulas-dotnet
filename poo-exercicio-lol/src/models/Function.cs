using System.Collections.Generic;

namespace poo_exercicio_lol.src.models
{
    public class Function
    {
        public Function()
        {
        }
        public Function(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public Function AddFunction(int id, string name)
        {
            return new Function(
                Id = id,
                Name = name
            );
        }
    }
}