using System;

// ReSharper disable All

namespace Lesson_DotNet_Polymorphism
{
    public class Animal
    {
        public virtual void Habitat()
        {
            Console.WriteLine("Terra 🌍");
        }

        public virtual void Type()
        {
            Console.WriteLine("Ser Vivo 🧬");
        }
    }
}