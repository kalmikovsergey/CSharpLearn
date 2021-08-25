using System;

namespace Homework1
{
    class Program
    {
         static void Main(string[] args)
        {
            var bankAccount = new Service();
            bankAccount.Bank.Add(new Person() { Name = "Dima", Balance = 190 });
            bankAccount.Bank.Add(new Person() { Name = "Oli", Balance = 210 });

            Console.WriteLine("Result : " + bankAccount.GetMoney("Dima",  180));

            Console.ReadKey();
        }
    }
}
