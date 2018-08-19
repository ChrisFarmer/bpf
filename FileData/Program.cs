using System;
using FileData.Logging;
using FileData.Services;
using FileData.UI;
using FileData.UI.Constants;
using FileData.Validators;
using SimpleInjector;

namespace FileData
{
    public static class Program
    {
        private const int ApplicationErrorCode = -1;

        private static Container _dependencyInjectionContainer;

        public static void Main(string[] args)
        {
            DependencyInjectionConfiguration.RegisterTypes();
            _dependencyInjectionContainer = DependencyInjectionConfiguration.Container;

            ManageUnhandledExceptions();

            try
            {
                var argumentsValidator = _dependencyInjectionContainer.GetInstance<IArgumentsValidator>();
                var fileDetailsService = _dependencyInjectionContainer.GetInstance<IFileDetailsService>();

                argumentsValidator.Validate(args);
                var fileDetails = fileDetailsService.GetFileDetails(args);

                UserInterface.Output(fileDetails);
            }
            catch (Exception)
            {
                Environment.ExitCode = ApplicationErrorCode;
            }

            UserInterface.Output(UserInterfaceMessages.ApplicationClosing);
        }

        private static void ManageUnhandledExceptions()
        {
            AppDomain.CurrentDomain.UnhandledException += (sender, eventArgs) =>
            {
                if (eventArgs.ExceptionObject is Exception exception)
                {
                    var logger = _dependencyInjectionContainer.GetInstance<ILogger>();
                    logger.LogException(exception);
                }

                Environment.Exit(ApplicationErrorCode);
            };
        }
    }
}
