using FileData.Logging;
using FileData.Services;
using FileData.Validators;
using SimpleInjector;

namespace FileData
{
    internal static class DependencyInjectionConfiguration
    {
        internal static Container Container { get; private set; }

        internal static void RegisterTypes()
        {
            Container = new Container();

            Container.Register<ILogger, Logger>();
            Container.Register<IArgumentsValidator, ArgumentsValidator>();
            Container.Register<IFileDetailsTypeService, FileDetailsTypeService>();
            Container.Register<IFileDetailsService, FileDetailsService>();
            Container.Register<IFileDetailsAdapterFactory, FileDetailsAdapterFactory>();

            Container.Verify();
        }
    }
}