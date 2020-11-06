using System;

namespace Lesson_DotNet_Polymorphism
{
    public class Employee
    {
        public virtual void CalculatePayment(decimal grossSalary)
        {
            Console.WriteLine($"Salário {grossSalary - (grossSalary * 0.1M)}");
        }
    }
}