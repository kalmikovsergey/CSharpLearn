
using System;
using Xunit;
using Homework1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var testBankAccont = new Service();          
            var testValue = new Person() { Name = "Any", Balance = 200 };
            var expectedValue = 190;
            testBankAccont.Bank.Add(new Person() { Name = "Dima", Balance = 190 });

            var actual = testBankAccont.GetMoney("Dima",190);

            Assert.Equal(expectedValue, actual);
        }
    }
}
