//Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
	public static void Main ()
	{
		int nullInt = new int();
		double nullDouble = new double();
		char nullChar = new char();

		Console.WriteLine (nullInt);
		Console.WriteLine (nullDouble);


		Console.WriteLine (nullInt + 5);
		Console.WriteLine (nullInt + nullChar);
		Console.WriteLine (nullDouble + 5);
		Console.WriteLine (nullDouble + nullChar);
		
	}
}