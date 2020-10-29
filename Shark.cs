using System;

// ReSharper disable All

namespace Lesson_DotNet_Polymorphism
{
    public class Shark : Animal
    {
        public override void Habitat()
        {
            Console.WriteLine("Oceanos");
        }

        public override void Type()
        {
            Console.WriteLine("Peixe");
        }
    }
}