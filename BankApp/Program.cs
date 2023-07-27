// See https://aka.ms/new-console-template for more information

using System;

namespace BankApp {
    class Program {

        public class BankAccount
        {
            public int AccountNumber = 12345;
            public string FirstName = "Bob";
            public string LastName = "Smith";
            public double Credit = 100;
            public double Debit = 500;
            public double Balance;
            //variables are marked as public for now for convenience, will have to maket them private and use setters and getters later.

        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is your Account Number?");
            int accNumber = Convert.ToInt32(Console.ReadLine());
            BankAccount bankaccount = new BankAccount();

            string[] Commands = {"#1 - Check Debit Amount", "#2 - Check Credit Amount", "#3 - Check Balance", "#4 - Fun Fact?" };

            if (accNumber == bankaccount.AccountNumber)
            {
                Console.WriteLine("Account Number Correct");
                Thread.Sleep(500);
                string fullName = bankaccount.FirstName + " " + bankaccount.LastName;
                Console.WriteLine($"Hello, {fullName}");
                Thread.Sleep(500);
                Console.WriteLine("What would you like to do?");

                for (int i = 0; i < Commands.Length; i++)
                {
                    Console.WriteLine(Commands[i]);
                }
                int Answer = Convert.ToInt32(Console.ReadLine());
                --Answer;
                Thread.Sleep(500);
                Console.WriteLine("You have selected " + Commands[Answer]);


                //Insert a Switch case here for each of the 4 options.


            }
            else 
                Console.WriteLine("Invalid Account Number.");
            

            

            //there should be a BankAccount class that hosts members fName, lName, accountNum, balance, credit, & debits. Setters and getters should be setup for each

            //Section asking for username and password, correct username and password should be private variables in a class

            //If username and password is correct. Permits access to debits and credits

            //In the future add a function for applying for credit card, based on certain questions should results in either approval or disapproval for credit card.
        }
    }

}