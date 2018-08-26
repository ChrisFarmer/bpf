using FileData.Enums;
using FileData.Services;
using NUnit.Framework;

namespace FileData.UnitTests.FileDetailsFactory
{
    [TestFixture]
    public class GetDetailsByTypeTests
    {
        [TestCase]
        public void When_size_type_is_supplied_should_return_FileSizeDetails_type()
        {
            var sut = new Services.FileDetailsFactory();

            var fileDetails = sut.GetDetailsByType(FileDetailsType.Size);

            Assert.IsInstanceOf<FileSizeDetails>(fileDetails);
        }

        [TestCase]
        public void When_version_type_is_supplied_should_return_FileVersionDetails_type()
        {
            var sut = new Services.FileDetailsFactory();

            var fileDetails = sut.GetDetailsByType(FileDetailsType.Version);

            Assert.IsInstanceOf<FileVersionDetails>(fileDetails);
        }
    }
}