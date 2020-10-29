using System;

namespace Lesson_DotNet_Polymorphism
{
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Miado.. miau!");
        }

        public override void Type()
        {
            Console.WriteLine("Mamifero");
        }
    }
}