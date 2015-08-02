//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.



using System;

class GravitationOnTheMoon
{
	public static void Main ()
	{
		Console.WriteLine ("Please Enter your weight:");
		double weight = double.Parse (Console.ReadLine ());

		double weightOnMoon = (weight / 100.00) * 17;

		Console.WriteLine ("Your weight on the Moon will be {0}kg.", weightOnMoon);
		
	}
}