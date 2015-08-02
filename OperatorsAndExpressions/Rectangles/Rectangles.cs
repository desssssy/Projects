//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.



using System;


class Rectangles
{
	public static void Main ()
	{
		double width;
		double height;

		double perimeter;
		double area;

		Console.WriteLine ("Enter Rectangle width:");

		width = double.Parse (Console.ReadLine ());

		Console.WriteLine ("Enter Rectangle height:");

		height = double.Parse (Console.ReadLine ());

		area = width * height;
		perimeter = (2 * width) + (2 * height);

		Console.WriteLine ("Rectangle Area is: {0}",area);
		Console.WriteLine ("Rectangle Perimeter is {0}", perimeter);

	}
}