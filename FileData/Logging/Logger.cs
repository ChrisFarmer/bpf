using System;
using FileData.UI;

namespace FileData.Logging
{
    public class Logger : ILogger
    {
        public void LogException(Exception exception)
        {
            UserInterface.Output(exception.Message);
        }
    }
}