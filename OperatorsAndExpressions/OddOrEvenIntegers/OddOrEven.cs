using System;

class OddOrEvenIntegers
{
	public static void Main ()
	{

		int input = int.Parse (Console.ReadLine ());

		int check = input & 1;

		if (check == 1) 
		
		{
			Console.WriteLine ("Odd");

		}

		else 
		
		{
			Console.WriteLine ("Even");

		}


		int input2 = int.Parse (Console.ReadLine ());

		if (input2 % 2 == 0) 
		
		{
			Console.WriteLine ("Even");
		} 

		else 
		
		{

			Console.WriteLine ("Odd");
		}

	}
}
