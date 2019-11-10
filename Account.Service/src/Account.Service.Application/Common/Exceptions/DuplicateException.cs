using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Service.Application.Common.Exceptions
{
    public class DuplicateException : Exception
    {

        public DuplicateException(string name, object key)
            : base($"Entity \"{name}\" ({key}) already exists.")
        {
        }

        public DuplicateException() : base()
        {
        }

        public DuplicateException(string message) : base(message)
        {
        }

        public DuplicateException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
