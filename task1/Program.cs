using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(0, AccountType.Deposit);
            BankAccount account1 = new BankAccount(90000);
            Console.WriteLine(account);
            Console.WriteLine("Кладем на счет 50000");
            account.IncreaseBalance(50000);
            Console.WriteLine(account);
            Console.WriteLine("Снимаем 10000");
            account.GetMoney(10000);
            Console.WriteLine(account);
            Console.WriteLine("Снимаем 50000");
            account.GetMoney(50000);
            Console.WriteLine(account);
            Console.WriteLine(account1);
            Console.WriteLine("Переводим 40000 с account1 на account");
            account.TransferMoney(account1, 40000);
            Console.WriteLine(account);
            Console.WriteLine(account1);
        }
    }
}
