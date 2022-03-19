using BankyStuffLibrary;
using System;
using Xunit;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            var account = new BankAccount("Kendra", 10000);

            //Test for a negative balance:

            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(5000, DateTime.Now, "Attempt to overdraw")
                );
        }

        [Fact]
        public void Test3()
        {
            
            Assert.Throws<ArgumentOutOfRangeException>(
                ()=> new BankAccount("invalid", -55)
                );
        }
    }
}
