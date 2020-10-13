using System;
using System.Collections.Generic;
using System.Text;

namespace User_Registration
{
    public class UserRegistrationCustomException:Exception
    {
        public string message;
        public UserRegistrationCustomException(string message)
        {
            this.message = message;
        }
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD=12,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE
        }
        private readonly ExceptionType type;
        public UserRegistrationCustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
