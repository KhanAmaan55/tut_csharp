using System;
namespace Hello
{
	public class TypeCasting
	{
		public static void Type_Casting()
        {
            /* Implicit Type-casting */

            // C# by default typecast some datatype into other (down is the order that can be typecasted to other datatypes)
            // char > int > long > float > double

            int x = 3;
            double y = x; // this will successfully run as from above order int can be typecasted to double
            float z = 'y'; // this will run as well but and it will give output as the ASCII value of the charecter
            //long w = 3.55; // this will be an error as double cannot be typecasted to long

            Console.WriteLine($"int {x}\ndouble {y} typecasted from int {x}\nfloat {z} typecasted from char 'y'");
            Console.WriteLine("-----------------------------------------");
            /* ------------------- */


            /* Explicit Type-casting */

            /*
              string s = "210";
              int i = (int) s; // we can't convert string to int using this method
            */
            double num = 13.90;

            int intNum = (int)num;
            float floatnum = (float)intNum;
            float floatnum2 = (float)num;
            long longNum = (long)num;
            long longNum2 = (long)intNum;
            long longNum3 = (long)floatnum;
            Console.WriteLine($"double {num} typecasted to int {intNum}");
            Console.WriteLine($"double {num} typecasted to float {floatnum2}");
            Console.WriteLine($"int {intNum} typecasted to float {floatnum:F2}"); // F2 is used to display float with 2 decimals
            Console.WriteLine($"double {num} typecasted to long {longNum}");
            Console.WriteLine($"int {intNum} typecasted to long {longNum2}");
            Console.WriteLine($"float {floatnum:F2} typecasted to long {longNum3}");
            Console.WriteLine("-----------------------------------------");

            int var = Convert.ToInt32(num); // [Convert.ToInt32] converts decimal to round of interger eg. 2.9 ≈ 3
            int var2 = Convert.ToInt32("123");  // can be used to convert string to int
            decimal var3 = Convert.ToDecimal(num);
            char var4 = Convert.ToChar(65); //converts integer ASCII value to charecter
            string var5 = Convert.ToString(num);

            Console.WriteLine($"double {num} converted to int {var}");
            Console.WriteLine($"string '123' converted toint {var2}");
            Console.WriteLine($"double {num} converted to decimal {var3}");
            Console.WriteLine($"int 65 converted to char {var4}");
            Console.WriteLine($"double {num} converted to string {var5}");
        }
    }
}

