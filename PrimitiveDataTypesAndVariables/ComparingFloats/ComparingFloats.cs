//Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the 
//floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than 
//a fixed constant eps.



using System;

class ComparingFloats
{
	public static void Main ()
	{

		float eps = 0.000001f;

		double a;
		double b;


		a = 5.3;
		b = 6.01;

		if (Math.Max (a, b) - Math.Min (a, b) < eps) 
		
		{
			Console.WriteLine (true);
		} 

		else 
		
		{
			Console.WriteLine (false);
		}

		a = 5.00000001;
		b = 5.00000003;

		if (Math.Max (a, b) - Math.Min (a, b) < eps) 

		{
			Console.WriteLine (true);
		} 

		else 

		{
			Console.WriteLine (false);
		}

		a = 5.00000005;
		b = 5.00000001;

		if (Math.Max (a, b) - Math.Min (a, b) < eps) 

		{
			Console.WriteLine (true);
		} 

		else 

		{
			Console.WriteLine (false);
		}

		a = -0.0000007;
		b = 0.00000007;

		if (Math.Max (a, b) - Math.Min (a, b) < eps) 

		{
			Console.WriteLine (true);
		} 

		else 

		{
			Console.WriteLine (false);
		}

		a = -4.999999;
		b = -4.999998;

		if (Math.Max (a, b) - Math.Min (a, b) < eps) 

		{
			Console.WriteLine (true);
		} 

		else 

		{
			Console.WriteLine (false);
		}

		a = 4.999999;
		b = 4.999998;

		if (Math.Max (a, b) - Math.Min (a, b) < eps) 

		{
			Console.WriteLine (true);
		} 

		else 

		{
			Console.WriteLine (false);
		}
			
	}
}