using System;

// ReSharper disable All

namespace Lesson_DotNet_Polymorphism
{
    public class Person
    {
        public void Start(string name)
        {
            Console.WriteLine($"Olá {name}");
        }

        public void Start(string name, int age)
        {
            Console.WriteLine($"Olá {name}, você tem {age} anos");
        }
    }
}