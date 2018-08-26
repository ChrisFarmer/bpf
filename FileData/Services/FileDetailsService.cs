using System.Linq;

namespace FileData.Services
{
    public class FileDetailsService : IFileDetailsService
    {
        private readonly IFileDetailsTypeService _fileDetailsTypeService;
        private readonly IFileDetailsFactory _fileDetailsFactory;

        public FileDetailsService(IFileDetailsTypeService fileDetailsTypeService, IFileDetailsFactory fileDetailsFactory)
        {
            _fileDetailsTypeService = fileDetailsTypeService;
            _fileDetailsFactory = fileDetailsFactory;
        }

        public string GetFileDetails(string[] args)
        {
            var commandLineSwitch = args.First();
            var filePath = args[1];

            var fileDetailsType = _fileDetailsTypeService.GetTypeBySwitch(commandLineSwitch);
            var fileDetails = _fileDetailsFactory.GetDetailsByType(fileDetailsType);

            return fileDetails.GetDetails(filePath);
        }
    }
}