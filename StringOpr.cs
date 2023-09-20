using System;
namespace Hello
{
	public class StringOpr
	{
        public static void String_Opr()
        {
            string strtxt = "Hello world";
            Console.WriteLine(strtxt.Length);
            Console.WriteLine(strtxt.ToUpper());
            Console.WriteLine(strtxt.ToLower());
            Console.WriteLine(strtxt + " This is C#");
            Console.WriteLine(string.Concat(strtxt, "This is C#")); // Concatenate two strings 
            Console.WriteLine(string.Equals(strtxt, "is it same"));
            Console.WriteLine(strtxt[0]);
            Console.WriteLine(strtxt.IndexOf('w'));
            Console.WriteLine(strtxt.IndexOf("world")); // Ans = 6 ; it takes index of first letter, in this case 'w'
            Console.WriteLine(strtxt.Substring(2)); //will give output as a string from the given index to end
            Console.WriteLine("this is how you can print \" ");

        }
    }
}

