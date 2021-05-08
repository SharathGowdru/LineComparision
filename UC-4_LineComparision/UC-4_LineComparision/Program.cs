using System;

namespace UC2_LineComparison
{
    class LineComparison
    {
        static void Main(string[] args)
        {
            LineComparison l = new LineComparison();
            double line1 = l.getLength(3, 6, 10, 21);
            double line2 = l.getLength(3, 6, 10, 20);
            Console.WriteLine("============================Executing compareTo method===================================");
            l.checkComparision(line1, line2);
            Console.WriteLine("============================End of compareTo method===================================");
            Console.WriteLine("============================Executing Equals method===================================");
            l.checkEquality(line1, line2);
            Console.WriteLine("============================End of Equals method===================================");
        }

        double getLength(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        }
        void checkComparision(double line1, double line2)
        {
            if (0 == line1.CompareTo(line2))
            {
                Console.WriteLine("The Two Lines are equal:");
            }
            else if (1 == line1.CompareTo(line2))
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else
            {
                Console.WriteLine("Two Line 1 is lesser than Line 2");
            }
        }
        void checkEquality(double line1, double line2)
        {
            if (line1.ToString().Equals(line2.ToString()))
            {
                Console.WriteLine("Two lines are equal");
            }
            else
            {
                Console.WriteLine("Two Lines are not Equal");
            }
            
        }

    }

}