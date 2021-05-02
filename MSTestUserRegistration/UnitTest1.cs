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
        /// Validate first name
        /// </summary>
        [TestMethod]
        [DataRow("Singh")]
        [DataRow("Khawshi")]
        [DataRow("Kholia")]
        [DataRow("Kumbhare")]
        [DataRow("Singh")]
        [DataRow("Patil")]

        public void Given_FirstName_StartsWithCapital_MinThreeCharacter_ShouldReturnTrue(string name)
        {
            try
            {
                string result = userDetailsPattern.ValidateLastName(name);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Valid Last Name", e.Message);
            }
        }

        ///// <summary>
        ///// Test Method to Invalidate first name
        ///// </summary>
        [TestMethod]
        [DataRow("sHARMA")]
        [DataRow("uPDHAYAY")]
        [DataRow("yADAV")]


        public void GivenFirstName_IfAll_LettersAreCapital_AndMinThreeCharacters_ShouldReturnFalse(string invalidFirstName)
        {
            try
            {
                string result = userDetailsPattern.ValidateLastName(invalidFirstName);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }
    }
}
