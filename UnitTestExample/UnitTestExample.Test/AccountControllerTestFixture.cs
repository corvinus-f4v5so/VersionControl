using Moq;
using NUnit.Framework;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnitTestExample.Abstractions;
using UnitTestExample.Controllers;
using UnitTestExample.Entities;

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
            var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict);
            accountServiceMock
                .Setup(m => m.CreateAccount(It.IsAny<Account>()))
                .Returns<Account>(a => a);

            var accountController = new AccountController();
            accountController.AccountManager = accountServiceMock.Object;
            //Act
            var actualResult = accountController.Register(email, password);
            //Assert
            Assert.AreEqual(email, actualResult.Email);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreNotEqual(actualResult.ID, Guid.Empty);
            accountServiceMock.Verify(m => m.CreateAccount(actualResult), Times.Once);
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

        [
    Test,
    TestCase("irf@uni-corvinus.hu", "Abcd1234")
]
        public void TestRegisterApplicationException(string newEmail, string newPassword)
        {
            // Arrange
            var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict);
            accountServiceMock
                .Setup(m => m.CreateAccount(It.IsAny<Account>()))
                .Throws<ApplicationException>();
            var accountController = new AccountController();
            accountController.AccountManager = accountServiceMock.Object;

            // Act
            try
            {
                var actualResult = accountController.Register(newEmail, newPassword);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ApplicationException>(ex);
            }

            // Assert
        }
    }
}
