﻿//Quotes in Strings

//Declare two string variables and assign them with following value: 
//The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

class QoutesInStrings
{
	public static void Main ()
	{
		string firstString = @"The ""use"" of qoutations causes difficulties.";
		string secondString = "The \"use\" of qoutations causes difficulties.";

		Console.WriteLine (firstString);
		Console.WriteLine (secondString);
	}
}