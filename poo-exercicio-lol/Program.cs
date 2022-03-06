using System;
using System.Collections.Generic;
using static System.Console;
using poo_exercicio_lol.src.models;
using poo_exercicio_lol.src.enums;
using System.Linq;

namespace poo_exercicio_lol
{
    class Program
    {
        static void Main(string[] args)
        {
            var functions = ListFunctions();

            Clear();

            WriteLine("Bem-vindo ao cadastro de campeões! \n");
            WriteLine("Funções: ");

            foreach (var item in functions)
                WriteLine(item.Id + " - " + item.Name);

            WriteLine("\nEscolha uma função: ");
            SetCursorPosition(20, 9);
            int functionId = int.Parse(ReadLine());
            var function = functions.FirstOrDefault(x => x.Id == functionId);

            WriteLine("Digite um nome: ");
            SetCursorPosition(16, 10);
            string name = ReadLine();

            WriteLine("\nNíveis de dificuldade: ");

            var difficultyLevels = ListDifficultyLevels();

            foreach (var item in difficultyLevels)
                WriteLine(item.Id + " - " + item.Name);

            WriteLine("\nEscolha um nível de dificuldade: ");
            SetCursorPosition(33, 18);
            int difficultyId = int.Parse(ReadLine());
            var difficulty = difficultyLevels.FirstOrDefault(x => x.Id == difficultyId);

            WriteLine("Defina a passiva do campeão: ");
            SetCursorPosition(29, 19);
            string passive = ReadLine();

            WriteLine("Defina a habilidade Q do campeão: ");
            SetCursorPosition(34, 20);
            string skillQ = ReadLine();

            WriteLine("Defina a habilidade W do campeão: ");
            SetCursorPosition(34, 21);
            string skillW = ReadLine();

            WriteLine("Defina a habilidade E do campeão: ");
            SetCursorPosition(34, 22);
            string skillE = ReadLine();

            WriteLine("Defina a habilidade R do campeão: ");
            SetCursorPosition(34, 23);
            string skillR = ReadLine();

            Skills skills = new Skills
            {
                Passive = passive,
                SkillQ = skillQ,
                SkillW = skillW,
                SkillE = skillE,
                SkillR = skillR
            };

            Champion champion = new Champion
            {
                Id = 1,
                FunctionId = functionId,
                Function = function,
                Name = name,
                DifficultyId = difficultyId,
                Difficulty = difficulty,
                Skills = skills
            };
            WriteLine("--------------------------------------------");
            WriteLine("Champion: \n \n" + champion.PrintChampion(champion));
        }

        static List<Function> ListFunctions()
        {
            List<Function> functions = new List<Function>();
            Function function = new Function();

            functions.Add(function.AddFunction(1, "Lutador"));
            functions.Add(function.AddFunction(2, "Mago"));
            functions.Add(function.AddFunction(3, "Atirador"));
            functions.Add(function.AddFunction(4, "Suporte"));
            functions.Add(function.AddFunction(5, "Tanque"));

            return functions;
        }

        static List<Difficulty> ListDifficultyLevels()
        {
            List<Difficulty> difficulties = new List<Difficulty>();
            Difficulty difficulty = new Difficulty();

            difficulties.Add(difficulty.AddDifficulty(1, DifficultyEnum.Easy.ToString()));
            difficulties.Add(difficulty.AddDifficulty(2, DifficultyEnum.Medium.ToString()));
            difficulties.Add(difficulty.AddDifficulty(3, DifficultyEnum.Hard.ToString()));
            difficulties.Add(difficulty.AddDifficulty(4, DifficultyEnum.VeryHard.ToString()));

            return difficulties;
        }
    }
}
