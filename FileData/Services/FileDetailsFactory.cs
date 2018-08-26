using System;
using FileData.Enums;
using FileData.Logging;

namespace FileData.Services
{
    public class FileDetailsFactory : IFileDetailsFactory
    {
        public IFileDetails GetDetailsByType(FileDetailsType fileDetailsType)
        {
            switch (fileDetailsType)
            {
                case FileDetailsType.Version:
                    return new FileVersionDetails();

                case FileDetailsType.Size:
                    return new FileSizeDetails();

                default:
                    var exception = new ArgumentException($"Invalid FileDetailType supplied: '{fileDetailsType}'");
                    var logger = DependencyInjectionConfiguration.Container.GetInstance<ILogger>();
                    logger.LogException(exception);

                    throw exception;
            }
        }
    }
}