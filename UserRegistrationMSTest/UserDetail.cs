using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationMSTest
{
    public class UserDetail
    {
        //Regular expression patterns for Password
        public static string passwordPattern = "^[A-Za-z]{8,}$";

        //Validation of  all the details
        public Func<string, string> ValidatePassword = x => Regex.IsMatch(x, passwordPattern) ? "Valid password" :
           throw new UserException(UserException.ExceptionType.INVALID_PASSWORD, "Invalid password");


    }
}
