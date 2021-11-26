using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("jelszo123", false),
            TestCase("bence@gmail", false),
            TestCase("bencegmail.com", false),
            TestCase("email@gmail.com", true),
        ]
        public void TestValidateEamil(string email, bool expectedResult)
        {
            //Arrange
            var accountController = new AccountController();
            //Act
            var actualResult = accountController.ValidateEmail(email);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [
            Test,
            TestCase("ezegyjelszo", false),
            TestCase("EZEGYJELSZO123", false),
            TestCase("ezegyjelszo123", false),
            TestCase("jelszo", false),
            TestCase("Jelszo1234", true),
        ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            //Arrange
            var accountController = new AccountController();
            //Act
            var actualResult = accountController.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
