using FileData.Enums;

namespace FileData.Services
{
    public interface IFileDetailsTypeService
    {
        FileDetailsType GetTypeBySwitch(string commandLineSwitch);
    }
}