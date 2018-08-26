using FileData.Enums;
using FileData.Services;
using NUnit.Framework;

namespace FileData.UnitTests.FileDetailsFactory
{
    [TestFixture]
    public class GetDetailsTargetByTypeTests
    {
        [TestCase]
        public void When_size_type_is_supplied_should_return_FileSizeDetailsAdapter_type()
        {
            var sut = new FileDetailsAdapterFactory();

            var fileDetails = sut.GetDetailsTargetByType(FileDetailsType.Size);

            Assert.IsInstanceOf<FileSizeDetailsAdapter>(fileDetails);
        }

        [TestCase]
        public void When_version_type_is_supplied_should_return_FileVersionDetailsAdapter_type()
        {
            var sut = new FileDetailsAdapterFactory();

            var fileDetails = sut.GetDetailsTargetByType(FileDetailsType.Version);

            Assert.IsInstanceOf<FileVersionDetailsAdapter>(fileDetails);
        }
    }
}