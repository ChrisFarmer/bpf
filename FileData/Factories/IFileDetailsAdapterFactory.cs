using FileData.Adapters;
using FileData.Enums;

namespace FileData.Factories
{
    public interface IFileDetailsAdapterFactory
    {
        IFileDetailsTarget GetDetailsTargetByType(FileDetailsType fileDetailsType);
    }
}