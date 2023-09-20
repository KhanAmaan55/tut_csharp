using System;
namespace Hello
{
	public class MathsOp
	{
        public static void maths()
        {
            int a = Math.Max(32, 222);
            int b = Math.Min(32, 222);
            double c = Math.MaxMagnitude(5.6, -8.9); // the absolute value of 8.9 is greater than the absolute value of 5.6. therefore ans = -8.9
            double d = Math.MinMagnitude(5.6, -8.9); //ans = 5.6
            double e = Math.PI;
            double f = Math.Sqrt(36);
            double g = Math.Round(20.99);
            double h = Math.Abs(-39.22);
            Console.WriteLine("Max of 32 and 222: " + a);
            Console.WriteLine("Min of 32 and 222: " + b);
            Console.WriteLine("Max Magnitude of 5.6 and -8.9: " + c);
            Console.WriteLine("Min Magnitude of 5.6 and -8.9: " + d);
            Console.WriteLine("Pi: " + e);
            Console.WriteLine("Square Root of 36: " + f);
            Console.WriteLine("RoundOf 20.99 (decimal): " + g);
            Console.WriteLine("Absolute of -39.22 : " + h);
        }
    }
}

