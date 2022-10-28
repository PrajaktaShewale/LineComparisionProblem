using System;
namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparision problem statement");
            CalculateLength calculate = new CalculateLength(1, 2, 3, 4);
            calculate.Calculate();
        }
    }
}
