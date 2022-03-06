using poo_exercicio_lol.src.enums;

namespace poo_exercicio_lol.src.models
{
    public class Champion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FunctionId { get; set; }
        public virtual Function Function { get; set; }
        public int DifficultyId { get; set; }
        public virtual Difficulty Difficulty { get; set; }
        public Skills Skills { get; set; }

        public string PrintChampion(Champion champion)
        {
            return (
                "Nome: " + champion.Name +
                "\nFunção: " + champion.Function.Name +
                "\nDificuldade: " + champion.Difficulty.Name +
                "\nSkills: \n  Passiva: " + champion.Skills.Passive +
                "\n  Skill Q: " + champion.Skills.SkillQ +
                "\n  Skill W: " + champion.Skills.SkillW +
                "\n  Skill E: " + champion.Skills.SkillE +
                "\n  Skill R: " + champion.Skills.SkillR
                );
        }
    }
}