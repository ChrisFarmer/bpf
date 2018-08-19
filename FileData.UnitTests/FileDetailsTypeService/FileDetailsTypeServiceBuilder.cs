using FileData.Logging;
using FileData.Services;
using Moq;

namespace FileData.UnitTests.FileDetailsTypeService
{
    public class FileDetailsTypeServiceBuilder
    {
        private Mock<ILogger> _logger;

        public FileDetailsTypeServiceBuilder()
        {
            _logger = new Mock<ILogger>();
        }

        public IFileDetailsTypeService Build() => new Services.FileDetailsTypeService(_logger.Object);
    }
}