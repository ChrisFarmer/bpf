using System;

namespace FileData.Logging
{
    public interface ILogger
    {
        void LogException(Exception exception);
    }
}