using System;
using System.Collections.Generic;

namespace LineComparision
{
    class Comparision
    {
        public static void Main(string[] args)
        {
            Comparision.getCartesian();
        }
        static void getCartesian()
        {
            double x1, x2, y1, y2;
            double length = 0;
            Console.WriteLine("Enter the point 1 (x1, y1) : ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the point 2 (x2, y2) : ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            length = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            Console.WriteLine(" The Distance between the two Points are : " + length);
        }
    }
}
