using ThirdPartyTools;

namespace FileData.Services
{
    public class FileSizeDetailsAdapter : IFileDetailsTarget
    {
        private readonly FileDetails _fileDetails;

        public FileSizeDetailsAdapter(FileDetails fileDetails)
        {
            _fileDetails = fileDetails;
        }

        public string GetDetails(string filePath) => _fileDetails.Size(filePath).ToString();
    }
}