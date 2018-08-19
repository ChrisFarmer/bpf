using ThirdPartyTools;

namespace FileData.Services
{
    public class FileVersionDetails : IFileDetails
    {
        public string GetDetails(string filePath) => new FileDetails().Version(filePath);
    }
}