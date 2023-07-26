// See https://aka.ms/new-console-template for more information

using System;

namespace BankApp {
    class Program { 
        static void Main(string[] args)
        {
            int accNumber;
            Console.WriteLine("What is your Account Number?");
            accNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Account Number is {accNumber}");

            //there should be a BankAccount class that hosts members fName, lName, accountNum, balance, credit, & debits. Setters and getters should be setup for each

            //Section asking for username and password, correct username and password should be private variables in a class

            //If username and password is correct. Permits access to debits and credits

            //In the future add a function for applying for credit card, based on certain questions should results in either approval or disapproval for credit card.
        }
    }

}