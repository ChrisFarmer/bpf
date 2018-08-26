using ThirdPartyTools;

namespace FileData.Services
{
    public class FileVersionDetailsAdapter : IFileDetailsTarget
    {
        private readonly FileDetails _fileDetails;

        public FileVersionDetailsAdapter(FileDetails fileDetails)
        {
            _fileDetails = fileDetails;
        }

        public string GetDetails(string filePath) => _fileDetails.Version(filePath);
    }
}