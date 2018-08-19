using ThirdPartyTools;

namespace FileData.Services
{
    public class FileSizeDetails : IFileDetails
    {
        public string GetDetails(string filePath) => new FileDetails().Size(filePath).ToString();
    }
}