﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationMSTest;

namespace MSTestUserRegistration
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Given Valid First Name should return true
        /// </summary>
        [TestMethod]
        public void GivenFirstNameShouldReturnHappy()
        {
            //Arrange

            bool expected = true;
            //Act
            bool output = UserDetail.validateFirstName("Vishal");
            //Assert
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Given Valid Last Name should return true
        /// </summary>
        [TestMethod]
        public void GivenLastNameShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserDetail.validateLastName("Singh");
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Given Valid Email should return true
        /// </summary>
        [TestMethod]
        public void GivenValidEmailIdShouldReturnHappy()
        {
            //Arrange
            bool expected = true;
            //Act
            bool output = UserDetail.validateEmail("abc@gmail.com");
            // Assert
            Assert.AreEqual(expected, output);
        }


        /// <summary>
        /// Given Valid Mobile No should return true
        /// </summary>
        [TestMethod]
        public void GivenValidMobileShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserDetail.validateMobileNo("91 9930315160");
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Given Valid Password should return true
        /// </summary>
        [TestMethod]
        public void GivenValidPasswordShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserDetail.validatePassword("Vishu@123");
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Test case for all valid and invalid emails
        /// </summary>
        /// <param name="email></param>
        [DataTestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenValidEmailListShouldReturnsTrue(string email)
        {
            bool expected = true;
            var result = UserDetail.validateEmailList(email);
            Assert.AreEqual(expected, result);
        }
    }
}
   