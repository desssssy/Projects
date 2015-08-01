//Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types 
//and descriptive names.


using System;

class BankAccountData
{
	public static void Main ()
	{
		string firstName;
		string middleName;
		string lastName;
		decimal balance;
		string bankName;
		string IBAN;
		long firstCreditCardNumber;
		long secondCreditCardNumber;
		long thirdCreditCardNumber;


		firstName = "Dessyslava";
		middleName = "Slavtcheva";
		lastName = "Wasseva";
		balance = 3456.56M;
		bankName = "DSK BANK";
		IBAN = "123hfkhhgsakjoj";
		firstCreditCardNumber = 1475388844440000;
		secondCreditCardNumber = 3333999944441111;
		thirdCreditCardNumber = 1111222233334444;

		Console.WriteLine ("First Name: {0}\nMiddle Name: {1}\nLast Name: {2}\nBalance: {3}\nBank Name: {4}\nIBAN: {5}\nCredit Card 1: {6}\nCredit Card 2: {7}\nCredit Card 3: {8}",firstName,middleName,lastName,balance,bankName,IBAN,firstCreditCardNumber,secondCreditCardNumber,thirdCreditCardNumber);
	}
}