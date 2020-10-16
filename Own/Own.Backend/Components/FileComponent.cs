using System.IO;

namespace Own.Backend.Components
{
    public static class FileComponent
    {
        public static void SaveContent(string filePath, string content)
        {
            FileStream fileStream = null;
            StreamWriter streamWriter = null;
            try
            {
                DirectoryComponent.CreateIfNotExists(filePath);
                fileStream = new FileStream(filePath, FileMode.OpenOrCreate | FileMode.Append, FileAccess.Write, FileShare.None);
                using (streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write(content);
                }
            }
            finally
            {
                if(fileStream != null) fileStream.Dispose();
                if (streamWriter != null) streamWriter.Dispose();
            }
        }
    }
}
