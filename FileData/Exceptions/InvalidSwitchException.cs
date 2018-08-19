using System;

namespace FileData.Exceptions
{
    public class InvalidSwitchException : Exception
    {
        public InvalidSwitchException(string message) : base(message)
        {
        }
    }
}