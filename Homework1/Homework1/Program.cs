using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            var banks = new Service();
            banks.Bank.Add(new Person() { Name = "Dima", Balance = 190});
            banks.Bank.Add(new Person() { Name = "Oli", Balance = 210 });

            Console.WriteLine("Result : " + banks.GetMoney("Dima",  180));

        }
    }
}
