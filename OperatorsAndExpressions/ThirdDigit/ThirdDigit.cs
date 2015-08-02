//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigit
{
	public static void Main ()
	{

		string input = Console.ReadLine ();

		input = input.PadLeft (3, '0');

		int maxLenght = input.Length;


		bool isSeven = (input [maxLenght - 3] == '7');

		Console.WriteLine (isSeven);
		
	}
}