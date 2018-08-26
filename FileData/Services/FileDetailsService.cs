using System.Linq;
using FileData.Factories;

namespace FileData.Services
{
    public class FileDetailsService : IFileDetailsService
    {
        private readonly IFileDetailsTypeService _fileDetailsTypeService;
        private readonly IFileDetailsAdapterFactory _fileDetailsAdapterFactory;

        public FileDetailsService(IFileDetailsTypeService fileDetailsTypeService, IFileDetailsAdapterFactory fileDetailsAdapterFactory)
        {
            _fileDetailsTypeService = fileDetailsTypeService;
            _fileDetailsAdapterFactory = fileDetailsAdapterFactory;
        }

        public string GetFileDetails(string[] args)
        {
            var commandLineSwitch = args[0];
            var filePath = args[1];

            var fileDetailsType = _fileDetailsTypeService.GetTypeBySwitch(commandLineSwitch);
            var fileDetailsTarget = _fileDetailsAdapterFactory.GetDetailsTargetByType(fileDetailsType);

            return fileDetailsTarget.GetDetails(filePath);
        }
    }
}