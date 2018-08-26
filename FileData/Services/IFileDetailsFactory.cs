using FileData.Enums;

namespace FileData.Services
{
    public interface IFileDetailsFactory
    {
        IFileDetails GetDetailsByType(FileDetailsType fileDetailsType);
    }
}