using System;
using System.Collections.Generic;
using System.Globalization;

namespace Solution3
{
    public struct BankAccount
    {
        public string number;
        public float amount;
        public string type;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] accountTypes = { "Savings", "Current account", "Giro account" };

            var bankAccounts = new BankAccount[5];

            int numberOfAccounts = 0;

            while (true)
            {
                Console.WriteLine("Enter 1 to register a new account, 2 to list all accounts and Exit to leave!");
                string userInput = Console.ReadLine().ToLower();

                if (userInput.Equals("1"))
                {
                    EnterAccount(bankAccounts, numberOfAccounts, accountTypes);
                    numberOfAccounts++;
                }
                else if (userInput.Equals("2"))
                {
                    PrintAccounts(bankAccounts);
                }
                else if (userInput.Equals("exit"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input entered!");
                }
            }
        }

        private static void EnterAccount(BankAccount[] bankAccounts, int accountIndex, string[] accountTypes)
        {
            Console.WriteLine("Enter the account number:");
            bankAccounts[accountIndex].number = Console.ReadLine();

            Console.WriteLine("Enter the account amount:");
            string amountInput = Console.ReadLine();
            bankAccounts[accountIndex].amount = float.Parse(amountInput, CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the account type:");
            Console.WriteLine("(0 for "+ accountTypes[0] + ", 1 for "+ accountTypes[1] + " and 2 for "+ accountTypes[2] + ")");
            ReadIntegerFromConsole(out int accountTypeNumber, new List<int> { 0, 1, 2 });
            bankAccounts[accountIndex].type = accountTypes[accountTypeNumber];
        }

        private static void PrintAccounts(BankAccount[] bankAccounts)
        {
            foreach (var bankAccount in bankAccounts)
            {
                if (!string.IsNullOrEmpty(bankAccount.number))
                    Console.WriteLine("Account number: " + bankAccount.number + " Account amount: " + bankAccount.amount + " Account type: " + bankAccount.type);
            }
        }

        private static void ReadIntegerFromConsole(out int number, List<int> acceptedValues)
        {
            string numberFromConsole = Console.ReadLine();

            if (int.TryParse(numberFromConsole, out number) && acceptedValues.Contains(number))
                return;                
            
            Console.WriteLine("Wrong input value");
            ReadIntegerFromConsole(out number, acceptedValues);
        }

    }
}
