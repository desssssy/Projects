﻿//Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange 
//their values by using some programming logic.
//Print the variable values before and after the exchange.


using System;

	class ExchangeVariableValues
	{
		public static void Main ()
		{
		
		int a = 5;
		int b = 10;
		int c;

		Console.WriteLine ("{0} and {1}", a,b);

		c = a;
		a = b;
		b = c;

		Console.WriteLine ("{0} and {1}", a,b);

		}
	}