//Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//Use descriptive names. Print the data at the console.//

using System;

class EmployeeData
{
	public static void Main ()
	{
		string firstName;
		string lastName;
		byte age;
		bool isFeemail;
		long PersonalIDNumber;
		int EmployeeIDNumber;

		firstName = "Dessyslava";
		lastName = "Wasseva";
		age = 33;
		isFeemail = true;
		PersonalIDNumber = 8306112507;
		EmployeeIDNumber = 27560000;

		Console.WriteLine ("First Name: {0} \nLast Name: {1}\nAge: {2}",firstName,lastName,age);

		if (isFeemail == true) {
			Console.WriteLine ("Gender: f");
		} 

		else {

			Console.WriteLine ("Gender: m");

		}

		Console.WriteLine ("Personal ID Number: {0}\nEmployee ID Number: {1}",PersonalIDNumber,EmployeeIDNumber);
	
	}
}