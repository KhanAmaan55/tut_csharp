using System;
namespace Hello
{
	public class InputOutput
	{
		public static void Input_output()
        {

            /* Input Output in C#
             * 
             * Console.WriteLine("Hello"); --> prints hello and a new line --> Hello\n
             * Console.Write("Hi "); --> Prints Hi but no new line ----------------------------⬇ 
             * Console.Write("World");  -->  same will not print new line so output will --> Hi World
             * Console.ReadLine();  --> Used to stop program and read the execution/ waits to read
             * string str = Console.ReadLine();  --> Also used to take input from user but will always takes string
             */

            /* ------------------- */

            // input string

            Console.Write("Enter Your String: ");
            string Str = Console.ReadLine();

            /*
                Console.WriteLine("Your String is" , Str);  ✘
                Console.WriteLine("Your String is" + Str);  ✔
                Console.WriteLine($"Your String is {Str}"); ✔
            */
            Console.WriteLine("Your String is " + Str);

            /* ------------------- */

            // input int, float, double, long 

            Console.Write("Enter Your Integer: ");
            string intInput = Console.ReadLine();
            int stringtoint = int.Parse(intInput);        // parse in C#
            Console.WriteLine($"As the typecast was successfull you are seeing your integer i.e {stringtoint} \nOtherwise it would be an error");

            //similarly you can do this for long, float and double

            /* ------------------- */

            // if want to make sure the value is int, float, double,long

            Console.Write("Enter Your number: ");
            string Input = Console.ReadLine();

            if (int.TryParse(Input, out int IntVariable))   // to check if it is integer or not
            {
                Console.WriteLine($"Your Integer Variabe is {IntVariable}");
            }
            else
            {
                Console.WriteLine("Not a Integer");
            }
            if (long.TryParse(Input, out long LongVariable))    // to check if it is long or not
            {
                Console.WriteLine($"Your Long Variabe is {LongVariable}");
            }
            else
            {
                Console.WriteLine("Not a Long");
            }
            if (float.TryParse(Input, out float FloatVariable))    // to check if it is float or not
            {
                Console.WriteLine($"Your Float Variabe is {FloatVariable}");
            }
            else
            {
                Console.WriteLine("Not a Float");
            }
            if (double.TryParse(Input, out double DoubleVariable))    // to check if it is double or not
            {
                Console.WriteLine($"Your Double Variabe is {DoubleVariable}");
            }
            else
            {
                Console.WriteLine("Not a Double");
            }

            /* ------------------- */


        }
    }
}

