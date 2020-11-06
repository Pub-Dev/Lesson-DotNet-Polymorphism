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

            ////Por Herança (Sobrescrita / Override)
            var intern = new Intern();
            intern.CalculatePayment(750);

            ////Por Herança (Sobrescrita / Override)
            Employee analyst = new Analyst();
            analyst.CalculatePayment(1500);

            //Sobrecarga / Overload
            var person = new Person();
            person.Start("Humberto");
            person.Start("Humberto", 26);

            Console.ReadLine();
        }
    }
}