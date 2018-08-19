using FileData.Exceptions;
using NUnit.Framework;

namespace FileData.UnitTests.ArgumentsValidator
{
    [TestFixture]
    public class ValidateTests
    {
        [TestCase("-v @C:\test.txt")]
        [TestCase("--s @C:\test.txt")]
        [TestCase("--version @C:\test.txt")]
        [TestCase("/s @C:\test.txt")]
        public void When_switch_is_valid_and_2_arguments_supplied_should_validate_successfully(string input)
        {
            var sut = new ArgumentsValidatorBuilder().Build();
            var args = input.Split(' ');

            sut.Validate(args);
        }

        [TestCase("")]
        [TestCase("-v")]
        [TestCase("@C:\test.txt")]
        [TestCase("-v -x @C:\test.txt")]
        public void When_invalid_number_of_arguments_supplied_should_throw_arguments_length_exception(string input)
        {
            var sut = new ArgumentsValidatorBuilder().Build();
            var args = input.Split(' ');

            Assert.Throws<ArgumentsLengthException>(() => sut.Validate(args));
        }

        [TestCase("-xyz @C:\test.txt")]
        [TestCase("- @C:\test.txt")]
        [TestCase("---v @C:\test.txt")]
        [TestCase("\v @C:\test.txt")]
        public void When_switch_is_invalid_and_2_arguments_supplied_should_throw_invalid_switch_exception(string input)
        {
            var sut = new ArgumentsValidatorBuilder().Build();
            var args = input.Split(' ');

            Assert.Throws<InvalidSwitchException>(() => sut.Validate(args));
        }
    }
}