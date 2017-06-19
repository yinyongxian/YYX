using System.IO;

namespace YYX.CSharp.IO
{
    public static class TextFile
    {
        public static string Read(string filePath)
        {
            using (var fileStream = new FileStream(filePath, FileMode.Open))
            using (var reader = new StreamReader(fileStream))
            {
                return reader.ReadToEnd();
            }
        }

        public static void Write(string filePath, string text)
        {
            using (var file = new FileStream(filePath, FileMode.Create))
            using (var writer = new StreamWriter(file))
            {
                writer.Write(text);
            }
        }
    }
}