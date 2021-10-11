using System;
using System.Collections.Generic;
using System.Text;

namespace User_Regi_Reflection
{
    class UserRegi_Exception : Exception
    {
        public enum ExceptionsMessage
        {
            INVALID_INPUT
        }

        private readonly ExceptionsMessage customMessage;
        //parameterize constructor
        public UserRegi_Exception(ExceptionsMessage customMessage, string message) : base(message)
        {
            this.customMessage = customMessage;
        }
    }
}
