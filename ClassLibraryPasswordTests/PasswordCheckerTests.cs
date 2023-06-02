using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnTrue()
        {
            //Arrange.
            string password = "ASqw12$$";
            bool expected = true;
            
            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Check_4Symbols_ReturnFalse()
        {
            //Arrange.
            string password = "Aq1$";

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_30Symbols_ReturnTrue()
        {
            //Arrange.
            string password = "ADSqwe123$ADSqwe123$";
            bool expected = true;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithDigits_ReturnTrue()
        {
            //Arrange.
            string password = "ADSqwe1$";
            bool expected = true;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutDigits_ReturnFalse()
        {
            //Arrange.
            string password = "ADSqweADS";
            bool expected = false;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithSpecSymbols_ReturnTrue()
        {
            //Arrange.
            string password = "Aqwe123$";
            bool expected = true;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutSpecSymbols_ReturnFalse()
        {
            //Arrange.
            string password = "ADSqwe123";
            bool expected = false;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithCapsSymbols_ReturnTrue()
        {
            //Arrange.
            string password = "Aqwe123$";
            bool expected = true;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Check_PasswordWithoutCapsSymbols_ReturnFalse()
        {
            //Arrange.
            string password = "asdqwe123$";
            bool expected = false;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithLowerSymbols_ReturnTrue()
        {
            //Arrange.
            string password = "ASDq123$";
            bool expected = true;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutLowerSymbols_ReturnFalse()
        {
            //Arrange.
            string password = "ASDQWE123$";
            bool expected = false;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}