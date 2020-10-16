using System.IO;

namespace Own.Backend.Components
{
    public static class DirectoryComponent
    {
        public static void CreateIfNotExists(string filePath)
        {
            string directoryPath = Path.GetDirectoryName(filePath);
            if (Directory.Exists(directoryPath) == false) Directory.CreateDirectory(directoryPath);
        }
    }
}
