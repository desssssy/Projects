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
		char gender;
		long PersonalIDNumber;
		int EmployeeIDNumber;

		firstName = "Dessyslava";
		lastName = "Wasseva";
		age = 33;
		gender = 'f';
		PersonalIDNumber = 8306112507;
		EmployeeIDNumber = 27560000;

		Console.WriteLine ("First Name: {0} \nLast Name: {1}\nAge: {2}\nGender: {3}\nPersonal ID Number: {4}\nEmployee ID Number: {5}",firstName,lastName,age,gender,PersonalIDNumber,EmployeeIDNumber);
	
	}
}