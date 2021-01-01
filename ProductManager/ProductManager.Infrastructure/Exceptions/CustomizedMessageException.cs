using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager.Infrastructure.Exceptions
{
    public class CustomizedMessageException : Exception
    {
        public CustomizedMessageException(string message)
            :base(message)
        {

        }
    }
}
