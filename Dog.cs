using System;

namespace Lesson_DotNet_Polymorphism
{
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Latido.. au au!");
        }

        public override void Type()
        {
            Console.WriteLine("Mamífero");
        }
    }
}