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
        /// Validate MobileNumber
        /// </summary>
        [TestMethod]
        [DataRow("91 9930315160")]
        [DataRow("91 7304383177")]
        [DataRow("91 9869538974")]

        public void Given__Valid_MobileNumber_ShouldReturnTrue(string validMobile)
        {
            try
            {
                string result = userDetailsPattern.ValidateMobileNumber(validMobile);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Valid Mobile Number", e.Message);
            }
        }

        /// <summary>
        /// passing invalid mobile number patterns should return invalid mobile number
        /// </summary>
        [TestMethod]
        [DataRow("91 9967689")]
        [DataRow("91 775643")]
        [DataRow("91 9987654")]
        [DataRow("91 9875640")]
        [DataRow("91 98776655")]
        [DataRow("91 988774455")]
        public void GivenInvalidMobileNumber_ShouldReturnFalse(string invalidMobile)
        {
            try
            {
                string result = userDetailsPattern.ValidateMobileNumber(invalidMobile);

            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid mobile number", e.Message);
            }
        }
    }
}