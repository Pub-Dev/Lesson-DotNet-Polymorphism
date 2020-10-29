﻿using System;

// ReSharper disable All

namespace Lesson_DotNet_Polymorphism
{
    public class Cat : Animal
    {
        public override void Habitat()
        {
            Console.WriteLine("Doméstico");
        }

        public override void Type()
        {
            Console.WriteLine("Mamífero");
        }
    }
}