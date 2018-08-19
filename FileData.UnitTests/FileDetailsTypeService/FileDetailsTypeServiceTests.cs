using FileData.Enums;
using NUnit.Framework;

namespace FileData.UnitTests.FileDetailsTypeService
{
    [TestFixture]
    public class FileDetailsTypeServiceTests
    {
        [TestCase("-s")]
        [TestCase("--s")]
        [TestCase("/s")]
        [TestCase("--size")]
        public void When_size_switch_is_supplied_should_return_size_file_details_type(string commandLineSwitch)
        {
            var sut = new FileDetailsTypeServiceBuilder().Build();

            var result = sut.GetTypeBySwitch(commandLineSwitch);

            Assert.AreEqual(FileDetailsType.Size, result);
        }

        [TestCase("-v")]
        [TestCase("--v")]
        [TestCase("/v")]
        [TestCase("--version")]
        public void When_version_switch_is_supplied_should_return_version_file_details_type(string commandLineSwitch)
        {
            var sut = new FileDetailsTypeServiceBuilder().Build();

            var result = sut.GetTypeBySwitch(commandLineSwitch);

            Assert.AreEqual(FileDetailsType.Version, result);
        }
    }
}