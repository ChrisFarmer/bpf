using System;

namespace FileData.Exceptions
{
    public class ArgumentsLengthException : Exception
    {
        public ArgumentsLengthException(string message) : base(message)
        {
        }
    }
}