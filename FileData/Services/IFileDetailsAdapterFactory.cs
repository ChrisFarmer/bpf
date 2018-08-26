using FileData.Enums;

namespace FileData.Services
{
    public interface IFileDetailsAdapterFactory
    {
        IFileDetailsTarget GetDetailsTargetByType(FileDetailsType fileDetailsType);
    }
}