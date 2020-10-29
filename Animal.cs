using System;

namespace Lesson_DotNet_Polymorphism
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Fala padrão");
        }

        public virtual void Type()
        {
            Console.WriteLine("Tipo padrão");
        }
    }
}