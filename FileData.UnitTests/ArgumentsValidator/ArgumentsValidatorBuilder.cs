using FileData.Logging;
using FileData.Validators;
using Moq;

namespace FileData.UnitTests.ArgumentsValidator
{
    public class ArgumentsValidatorBuilder
    {
        private Mock<ILogger> _logger;

        public ArgumentsValidatorBuilder()
        {
            _logger = new Mock<ILogger>();
        }

        public IArgumentsValidator Build() => new Validators.ArgumentsValidator(_logger.Object);
    }
}