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
        }
    }

}