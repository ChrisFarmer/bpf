using System.Collections.Generic;
using System.Linq;
using FileData.Constants;
using FileData.Exceptions;
using FileData.Logging;

namespace FileData.Validators
{
    public class ArgumentsValidator : IArgumentsValidator
    {
        private const int ValidNumberOfArguments = 2;
        private readonly ILogger _logger;

        public ArgumentsValidator(ILogger logger)
        {
            _logger = logger;
        }

        public void Validate(string[] args)
        {
            try
            {
                ValidateNumberOfArguments(args);
                ValidateSwitches(args);
            }
            catch (ArgumentsLengthException exception)
            {
                _logger.LogException(exception);

                throw;
            }
            catch (InvalidSwitchException exception)
            {
                _logger.LogException(exception);

                throw;
            }
        }

        private void ValidateNumberOfArguments(string[] args)
        {
            if (args.Length != ValidNumberOfArguments)
            {
                throw new ArgumentsLengthException($"Invalid number of arguments supplied ({args.Length}).");
            }
        }

        private void ValidateSwitches(string[] args)
        {
            var commandLineSwitch = args.First();

            var validCommandLineSwitches = new List<string>();
            validCommandLineSwitches.AddRange(CommandLineSwitches.FileVersionSwitches);
            validCommandLineSwitches.AddRange(CommandLineSwitches.FileSizeSwitches);

            if (!validCommandLineSwitches.Contains(commandLineSwitch))
            {
                throw new InvalidSwitchException($"Invalid switch supplied: '{commandLineSwitch}'");
            }
        }
    }
}