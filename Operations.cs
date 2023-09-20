using System;
namespace Hello
{
	public class AllOperations
	{
        public static void Operations()
        {
            /* Operators in C#
             1. Arithmetic operators
             2. Assignment Operators
             3. Logical Operators
             4. Comparison Operators
            */
            Console.WriteLine("Arithmetic operators");
            int a = 4;
            int b = 2;
            Console.WriteLine("The value of a + b is: " + (a + b));
            Console.WriteLine("The value of a - b is: " + (a - b));
            Console.WriteLine("The value of a*b is: " + (a * b));
            Console.WriteLine("The value of a / b is: " + (a / b));
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Assignment operators");
            int b1 = 4;
            int b2 = 4;
            int b3 = 4;
            int b4 = 4;
            b1 += 4;
            b2 -= 4;
            b3 *= 4;
            b4 /= 4;
            Console.WriteLine($"b1(4) += 4 -->{b1}");
            Console.WriteLine($"b2(4) -= 4 -->{b2}");
            Console.WriteLine($"b3(4) *= 4 -->{b3}");
            Console.WriteLine($"b4(4) /= 4 -->{b4}");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Logical operators");
            Console.WriteLine($"t and f {true && false}");
            Console.WriteLine($"t and t {true && true}");
            Console.WriteLine($"f and f {false && false}");
            Console.WriteLine($"t or f {true || false}");
            Console.WriteLine($"t or t {true || true}");
            Console.WriteLine($"f or f {false || false}");
            Console.WriteLine($"-ve f {!false}");
            Console.WriteLine($"-ve t {!true}");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Comparison Operators");
            Console.WriteLine(324 > 555);
            Console.WriteLine(324 <= 555);
            Console.WriteLine(324 >= 555);
            Console.WriteLine(324 != 555);
            Console.WriteLine(324 != 555);
            Console.WriteLine(5 == 5);
        }
    }
}

