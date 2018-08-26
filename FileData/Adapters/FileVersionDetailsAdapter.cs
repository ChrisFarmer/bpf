using ThirdPartyTools;

namespace FileData.Adapters
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