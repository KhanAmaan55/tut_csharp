using System;
namespace Hello
{
	public class DataType
	{
        public static void Datatype()
        {
            /* Data types in C#:
            * 
            * Integer - int hello; --> 4 bytes
            * Long - long hello; --> 8 bytes
            * Floating point number - float value; --> 4 bytes
            * Decimal - deciaml value; --> 16 bytes
            * Double - double value; --> 8 bytes
            * Character - char a = 'A'; --> 2 bytes
            * Boolean - bool isGreat = true; --> 1 bit
            * String - string sx = "India"; --> 2 bytes per character
            *
            */
            int a = 23;
            float b = 23.3F; //Need a suffix F for float value
            decimal bx = 0.33333333m; //Need a suffix m for decimal values
            double c = 23.3;
            double c2 = 23.3D; // You can declare double with D suffix as well but its not nessasary
            char d = 'A';   // char is the single character
            bool e = true;
            string f = "Amaan"; // single inverted commans cannot be used for string ('' ✘, "" ✔)
            Console.WriteLine($"integer - {a}");
            Console.WriteLine($"float - {b}");
            Console.WriteLine($"decimal - {bx}");
            Console.WriteLine($"double - {c}");
            Console.WriteLine($"double with suffix D - {c2}");
            Console.WriteLine($"char - {d}");
            Console.WriteLine($"boolean - {e}");
            Console.WriteLine($"sting - {f}");


            /* Difference between decimal and float 
             * 
             * decimal is a HIGH-precision data type and float is a LOW-precision data type. 
             * decimal is used when you need exact decimal arithimetic as float may introduce rounding errors due to low precision
             * decimal consumes more memory than float because of its higher precision. It uses 128 bits (16 bytes) for storage, while float uses 32 bits (4 bytes).
             * 
             * In summary, choose decimal for scenarios where precision is critical,
             * and use float for scientific or engineering calculations where a wider range of values is more important than exact precision
             * 
             */

            decimal decimalResult = 1m / 3m;
            float floatResult = 1f / 3f;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Result of 1/3 as both float and decimal");
            Console.WriteLine("Decimal Result: " + decimalResult);
            Console.WriteLine("Float Result: " + floatResult);
        }
    }
}

