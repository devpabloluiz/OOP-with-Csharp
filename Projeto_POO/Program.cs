using System;
using Projeto_POO.src.Entities;

namespace Hero
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Hero"); 
            Wizard Josi = new Wizard("Josi", 26, "Wizard");
            Ninja lass = new Ninja("Lass", 24, "Ninja");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(Josi.Attack());
            Console.WriteLine(lass.Attack());
        }
    }
}