using System;

// ReSharper disable All

namespace Lesson_DotNet_Polymorphism
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "PubDev - Polimorfismo";

            ////Por Herança (Sobrescrita / Override)
            Animal shark = new Shark();
            shark.Habitat();
            shark.Type();

            ////Por Herança (Sobrescrita / Override)
            var cat = new Cat();
            cat.Habitat();
            cat.Type();

            //Sobrecarga / Overload
            var person = new Person();
            person.Start("Humberto");
            person.Start("Humberto", 26);

            Console.ReadLine();
        }
    }
}