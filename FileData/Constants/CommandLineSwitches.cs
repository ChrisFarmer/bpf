using System.Collections.Generic;

namespace FileData.Constants
{
    internal static class CommandLineSwitches
    {
        internal static readonly List<string> FileVersionSwitches = new List<string>
        {
            "-v", "--v", "/v", "--version"
        };

        internal static readonly List<string> FileSizeSwitches = new List<string>
        {
            "-s", "--s", "/s", "--size"
        };
    }
}