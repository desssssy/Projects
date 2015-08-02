//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInACircle
{
	public static void Main ()
	{

		double xMax = 2;
		double xMin = -2;
		double yMax = 2;
		double yMin = -2;

		Console.WriteLine ("Please enter x:");
		double x = double.Parse (Console.ReadLine ());

		Console.WriteLine ("Plese enter y:");
		double y = double.Parse (Console.ReadLine ());

		bool dotInCircle = ((x <= xMax && x >= xMin) && (y <= yMax && y >= yMin));

		Console.WriteLine (dotInCircle);
		
	}
}