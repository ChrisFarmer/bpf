using System;
using FileData.Constants;
using FileData.Enums;
using FileData.Logging;

namespace FileData.Services
{
    public class FileDetailsTypeService : IFileDetailsTypeService
    {
        private readonly ILogger _logger;

        public FileDetailsTypeService(ILogger logger)
        {
            _logger = logger;
        }

        public FileDetailsType GetTypeBySwitch(string commandLineSwitch)
        {
            if (CommandLineSwitches.FileVersionSwitches.Contains(commandLineSwitch))
            {
                return FileDetailsType.Version;
            }

            if (CommandLineSwitches.FileSizeSwitches.Contains(commandLineSwitch))
            {
                return FileDetailsType.Size;
            }

            var exception = new ArgumentException($"Invalid command line switch supplied: '{commandLineSwitch}'");
            _logger.LogException(exception);

            throw exception;
        }
    }
}