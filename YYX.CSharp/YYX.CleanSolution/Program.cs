using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace YYX.CleanSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDirectory = Environment.CurrentDirectory;
            var parentDirectory = Directory.GetParent(currentDirectory);
            var directoryInfos = parentDirectory.GetDirectories("*", SearchOption.AllDirectories);
            var deleteDirectoryNames = new List<string>
            {
                "bin",
                "obj"
            };
            var deleteDirectoryInfos = directoryInfos.Where(item => deleteDirectoryNames.Contains(item.Name)).ToList();
            deleteDirectoryInfos.ForEach(item => item.Delete(true));
        }
    }
}
