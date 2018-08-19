﻿using System;
using FileData.Enums;
using FileData.Logging;

namespace FileData.Services
{
    internal static class FileDetailsFactory
    {
        internal static IFileDetails GetDetailsByType(FileDetailsType fileDetailsType)
        {
            switch (fileDetailsType)
            {
                case FileDetailsType.Version:
                    return new FileVersionDetails();

                case FileDetailsType.Size:
                    return new FileSizeDetails();

                default:
                    var exception = new ArgumentException($"Invalid FileDetailServiceType supplied: '{fileDetailsType}'");
                    var logger = DependencyInjectionConfiguration.Container.GetInstance<ILogger>();
                    logger.LogException(exception);

                    throw exception;
            }
        }
    }
}