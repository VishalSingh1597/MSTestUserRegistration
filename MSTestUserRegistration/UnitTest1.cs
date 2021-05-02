using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationMSTest;

namespace MSTestUserRegistration
{
    [TestClass]
    public class Test
    {
        private readonly UserDetail userDetailsPattern;
        //private readonly object DataRow;

        //parameterless constructor
        public Test()
        {
            userDetailsPattern = new UserDetail(); //object of UserDetail and store the userDetailsPattern variable
        }

        /// <summary>
        /// Validate Email Id
        /// </summary>
        [TestMethod]
        [DataRow("abc.xyz@bl.co.in")]
        [DataRow("anki.abc@bl.cp.in")]
        [DataRow("sach.dcd@bl.cp.in")]

        public void Given__Valid_Email_ShouldReturnTrue(string emailInvalid)
        {
            try
            {
                string result = userDetailsPattern.ValidateEmail(emailInvalid);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Valid Email", e.Message);
            }
        }

        /// <summary>
        /// Test Method to pass invalid email id.
        /// </summary>
        [TestMethod]
        [DataRow("vishal@gmail")]
        [DataRow("vishal@gmail.comm")]
        [DataRow("vishal@gmail.com.ind.us")]
        [DataRow("vishal.#100@gmail")]
        [DataRow("vishal11@gmail.com.a12")]
        [DataRow("vishal@gmail.com.12sa")]
        [DataRow("_vishal@gmail.com")]
        public void GivenEmailId_WhenIsNotProper_ShouldReturnFalse(string emailInvalid)
        {
            try
            {
                string result = userDetailsPattern.ValidateEmail(emailInvalid);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid email id", e.Message);
            }
        }
    }
}