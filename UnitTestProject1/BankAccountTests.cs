using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        /// <summary>
        /// Creating the Test Method to Check whether Debit Method is Working Fine
        /// </summary>
        [TestMethod]
        public void Debit_WithValidAmmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
             
            //Act
            account.Debit(debitAmount);

            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        /// <summary>
        /// Using The test Method to Check whether credit method is working fine
        /// </summary> 
        [TestMethod]
        public void Credit_WithValidAmmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = 4.00;
            double expected = 15.99;
            BankAccount account = new BankAccount("Mr Jatinder", beginningBalance);

            // Act
            account.Credit(creditAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
        }
        
        /// <summary>
        /// Creating the test method to check when amount is less than zero
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = 50.00;
            BankAccount account = new BankAccount("Mr Jatinder", beginningBalance);

            // Act
            account.Debit(creditAmount);

            // Assert
            
        }
        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = 50.00;
            BankAccount account = new BankAccount("Mr Jatinder", beginningBalance);

            // Act
            account.Debit(creditAmount);

            // Assert
        }
    }
}
