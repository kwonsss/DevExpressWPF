using System.IO;

namespace DXWPFSkeleton.Common
{
    public class DIRECTORY
    {
        public static string HOME = string.Empty;

        public static string Config     => Path.Combine(HOME, "Config");
        public static string Data       => Path.Combine(HOME, "Data");
    }
}
