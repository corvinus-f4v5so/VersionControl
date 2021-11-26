using NUnit.Framework;
using System;
using System.Activities;
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

        [
            Test,
            TestCase("bence@gmail.com", "Ezegyjelszo1234"),
            TestCase("benceemail@gmail.com", "Ezegymasik9876"),
        ]
        public void TestRegisterHappyPath(string email, string password)
        {
            //Arrange
            var accountController = new AccountController();
            //Act
            var actualResult = accountController.Register(email, password);
            //Assert
            Assert.AreEqual(email, actualResult.Email);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreNotEqual(actualResult.ID, Guid.Empty);
        }

        [
            Test,
            TestCase("bencegmail.com", "Ezegyjelszo1234"),
            TestCase("benceemail@gmail", "Ezegymasik9876"),
            TestCase("benceemail@gmail.com", "ezegymasik9876"),
            TestCase("benceemail@gmail.com", "EZEGEMYASIK9876"),
            TestCase("benceemail@gmail.com", "EZegymasik"),
            TestCase("benceemail@gmail.com", "Jelsz0"),
        ]
        public void TestRegisterValidateException(string email, string password)
        {
            //Arrange
            var accountController = new AccountController();
            //Act
            try
            {
                var actualResult = accountController.Register(email, password);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ValidationException>(ex);
            }
        }
    }
}
