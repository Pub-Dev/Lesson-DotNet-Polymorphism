using System;

namespace Lesson_DotNet_Polymorphism
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Por Herança (Sobre escrita / Override)
            var dog = new Dog();
            dog.Speak();
            dog.Type();

            var cat = new Cat();
            cat.Speak();
            cat.Type();

            //Sobrecarga / Overload
            var pessoa = new Person();
            pessoa.Start("Humberto");
            pessoa.Start("Humberto", 26);

            Console.ReadLine();
        }
    }
}