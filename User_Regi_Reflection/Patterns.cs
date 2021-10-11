using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Regi_Reflection
{
    class Patterns
    {
        const string REGEX_NAME = "^[A-Z]{1}[A-Za-z]{1,}";
        const string REGEX_EMAIL_ID = @"^[A-Za-z0-9]+([\.+\-_][A-Za-z0-9]+)*@[a-zA-Z0-9]+\.?[A-Za-z]+\.?[A-Za-z]{2,}$";
        const string REGEX_MOBILE_NUMBER = "^[1-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
        const string REGEX_PASSWORD = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[~`!@#$%^&*_+=,./?]).{8,}$";
        /// <summary>
        /// method to validate first name
        /// </summary>
        /// <param name="first_name"></param>
        public void FirstName(string first_name)
        {
            if (Regex.IsMatch(first_name, REGEX_NAME) == false)
                throw new UserRegi_Exception(UserRegi_Exception.ExceptionsMessage.INVALID_INPUT, " : Start with Capital letter ");
        }

        /// <summary>
        /// method to validate last name
        /// </summary>
        /// <param name="last_name"></param>
        public void LastName(string last_name)
        {
            if (Regex.IsMatch(last_name, REGEX_NAME) == false)
                throw new UserRegi_Exception(UserRegi_Exception.ExceptionsMessage.INVALID_INPUT, " : Start with Capital letter");
        }

        /// <summary>
        /// method to validate email id
        /// </summary>
        /// <param name="email"></param>

        public void Email(string email)
        {
            if (Regex.IsMatch(email, REGEX_EMAIL_ID) == false)
                throw new UserRegi_Exception(UserRegi_Exception.ExceptionsMessage.INVALID_INPUT, " : Invalid Email-ID");
        }

        /// <summary>
        /// method to validate mobile number
        /// </summary>
        /// <param name="mobile_no"></param>
        public void Mobile(string mobile_no)
        {
            if (Regex.IsMatch(mobile_no, REGEX_MOBILE_NUMBER) == false)
                throw new UserRegi_Exception(UserRegi_Exception.ExceptionsMessage.INVALID_INPUT, " : Invalid Mobile Number");
        }

        /// <summary>
        /// method to validate password
        /// </summary>
        /// <param name="password"></param>
        public void Password(string password)
        {
            if (Regex.IsMatch(password, REGEX_PASSWORD) == false)
                throw new UserRegi_Exception(UserRegi_Exception.ExceptionsMessage.INVALID_INPUT, " : Invalid Password");
        }
    }
}
