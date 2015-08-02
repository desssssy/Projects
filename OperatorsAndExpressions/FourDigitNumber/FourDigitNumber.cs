//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
	public static void Main ()
	{
		int input = int.Parse (Console.ReadLine ());

		while (((input == 0) || (input > 9999) || (input < 1000))) 
		
		{

			Console.WriteLine ("Please enter a digit different from 0 and containing exactly 4 digits!");

			input = int.Parse (Console.ReadLine ());
		}

			int a = input / 1000;
			int b = (input / 100) % 10;
			int c = ((input / 10) % 10) % 10;
			int d = (((input / 1) % 10) % 10) % 10;

			int sum = a + b + c + d;

			Console.WriteLine (sum);

			Console.WriteLine ("{0}{1}{2}{3}", d, c, b, a);
			Console.WriteLine ("{0}{1}{2}{3}", d, a, b, c);
			Console.WriteLine ("{0}{1}{2}{3}", a, c, b, d);
	}
}