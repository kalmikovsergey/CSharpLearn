
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

        [Fact]
        public void Test2()
        {
            var testBankAccont = new Service();
            var expectedValue = 0;
            var actual = testBankAccont.GetMoney("Dima", 190);

            Assert.NotNull(testBankAccont);
            Assert.Equal(expectedValue, actual);
        }

        [Theory]
        [InlineData(50 , 51)]
        [InlineData(0,49)]
        [InlineData(0, 0)]
        public void Test3(decimal expectedValue, decimal inActual)
        {
            var testBankAccont = new Service();
            var testValue = new Person() { Name = "Any", Balance = 50 };
            var actual = testBankAccont.GetMoney("Any", inActual);

            Assert.Equal(expectedValue, actual);
        }

        [Fact]
        public void Test4()
        {
            var testBankAccont = new Service();
            var testValue = new Person() { Name = "Any", Balance = 200 };
            var expectedValue = 1;
            testBankAccont.Bank.Add(new Person() { Name = "Dima", Balance = 190 });
            var actual = testBankAccont.GetPersonID("Dima");

            Assert.Equal(expectedValue, actual);
        }
    }

    }
}
