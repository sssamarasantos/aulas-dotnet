using System;
using poo_example_rpg.src.models;

namespace poo_example_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 23, "Knight");
            Wizard whiteWizard = new Wizard("Jenica", 23, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 23, "Ninja");
            Wizard blackWizard = new Wizard("Jenica", 23, "Black Wizard");

            Console.WriteLine(ninja.ToString());
            Console.WriteLine(knight.Attack());
            Console.WriteLine(blackWizard.Attack(2));
            Console.WriteLine(whiteWizard.Attack(8));
        }
    }
}
