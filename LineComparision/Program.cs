using System;
namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparision problem statement");
            CalculateLength calculate1 = new CalculateLength(1, 2, 3, 4);
            double length1 = calculate1.Calculate();
            Console.WriteLine(length1);
            CalculateLength calculate2 = new CalculateLength(1, 2, 3, 4);
            double length2 = calculate2.Calculate();
            Console.WriteLine(length2);
            if (length1.Equals(length2))//length1 ==length2
                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("Both lines are not equal");
            if (length1.CompareTo(length2)==0)
                Console.WriteLine("line1 and line2 both are equal");          
            if(length1.CompareTo(length2)>0)
                Console.WriteLine("Line 1 is greater than line2");
            else 
                Console.WriteLine("Line 2 is greter than line1");    
        }
    }
}
