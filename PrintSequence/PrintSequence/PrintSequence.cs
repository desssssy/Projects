using System;

class Sequence
{
	public static void Main ()
	{
		//2, -3, 4, -5, 6, -7, ...

		for (int i = 2; i < 12; i++) 
		
		{
			if (i % 2 == 0) 
			
			{
				Console.WriteLine (i);
			} 

			else 
			
			{

				Console.WriteLine (-i);
			}
		}
	}
}