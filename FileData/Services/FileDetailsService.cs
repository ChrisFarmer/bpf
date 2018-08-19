using System.Linq;

namespace FileData.Services
{
    public class FileDetailsService : IFileDetailsService
    {
        private readonly IFileDetailsTypeService _fileDetailsTypeService;

        public FileDetailsService(IFileDetailsTypeService fileDetailsTypeService)
        {
            _fileDetailsTypeService = fileDetailsTypeService;
        }

        public string GetFileDetails(string[] args)
        {
            var commandLineSwitch = args.First();
            var filePath = args[1];

            var fileDetailsType = _fileDetailsTypeService.GetTypeBySwitch(commandLineSwitch);
            var fileDetails = FileDetailsFactory.GetDetailsByType(fileDetailsType);

            return fileDetails.GetDetails(filePath);
        }
    }
}