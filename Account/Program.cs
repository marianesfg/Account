using System;
using System.Globalization;

namespace Account
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter account data");

            try
            {
                Console.Write("Number: ");
                Console.ForegroundColor = ConsoleColor.Red;
                int number = int.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.Write("Holder: ");
                Console.ForegroundColor = ConsoleColor.Red;
                string holder = Console.ReadLine();
                Console.ResetColor();

                Console.Write("Initial balance: ");
                Console.ForegroundColor = ConsoleColor.Red;
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.ResetColor();

                Console.Write("Withdraw limit: ");
                Console.ForegroundColor = ConsoleColor.Red;
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.ResetColor();

                Entities.Account account = new Entities.Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                Console.ForegroundColor = ConsoleColor.Red;
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.ResetColor();
                account.withdraw(withdraw);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (Exception e)
            {
                Console.ResetColor();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }        
        }
    }
}
