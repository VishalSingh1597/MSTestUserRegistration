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
        [DataRow("Ankita")]
        [DataRow("Rani")]
        [DataRow("Bajaj")]
        [DataRow("Sachin")]
        [DataRow("Raj")]
        [DataRow("Ashwin")]

        public void Given_FirstName_StartsWithCapital_MinThreeCharacter_ShouldReturnTrue(string name)
        {
            try
            {
                string result = userDetailsPattern.ValidateFirstName(name);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Valid First Name", e.Message);
            }
        }

        ///// <summary>
        ///// Test Method to Invalidate first name
        ///// </summary>
        [TestMethod]
        [DataRow("pRIYANSHU")]
        [DataRow("sHIVAM")]
        [DataRow("aNSHU")]


        public void GivenFirstName_IfAll_LettersAreCapital_AndMinThreeCharacters_ShouldReturnFalse(string invalidFirstName)
        {
            try
            {
                string result = userDetailsPattern.ValidateFirstName(invalidFirstName);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }
    }
}