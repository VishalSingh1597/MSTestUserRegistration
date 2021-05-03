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
        //Regular expression patterns for mobile number
        public static string mobileNumberPattern = "^91\\s[1-9]{1}[0-9]{9}$";

        //Validation of  all the details
        public Func<string, string> ValidateMobileNumber = x => Regex.IsMatch(x, mobileNumberPattern) ? "Valid mobile number" :
           throw new UserException(UserException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid mobile number");


    }
}
