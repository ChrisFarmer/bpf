using System;
using FileData.Enums;
using FileData.Logging;
using ThirdPartyTools;

namespace FileData.Services
{
    public class FileDetailsAdapterFactory : IFileDetailsAdapterFactory
    {
        public IFileDetailsTarget GetDetailsTargetByType(FileDetailsType fileDetailsType)
        {
            var fileDetails = new FileDetails();

            switch (fileDetailsType)
            {
                case FileDetailsType.Version:
                    return new FileVersionDetailsAdapter(fileDetails);

                case FileDetailsType.Size:
                    return new FileSizeDetailsAdapter(fileDetails);

                default:
                    var exception = new ArgumentException($"Invalid FileDetailsType supplied: '{fileDetailsType}'");
                    var logger = DependencyInjectionConfiguration.Container.GetInstance<ILogger>();
                    logger.LogException(exception);

                    throw exception;
            }
        }
    }
}