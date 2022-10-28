using System;

namespace LineComparison
{
    public class CalculateLength
    {
        double x1, x2, y1, y2;
        public CalculateLength(double x1, double x2, double y1, double y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public void Calculate()
        {
            double length = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            Console.WriteLine("Length:-" + length);
        }
    }
}
