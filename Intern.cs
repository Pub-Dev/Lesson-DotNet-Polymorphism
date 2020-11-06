using System;

namespace Lesson_DotNet_Polymorphism
{
    public class Intern : Employee
    {
        public override void CalculatePayment(decimal grossSalary)
        {
            Console.WriteLine($"Salário {grossSalary}");
        }
    }
}