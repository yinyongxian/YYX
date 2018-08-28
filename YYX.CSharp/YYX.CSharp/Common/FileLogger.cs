using System;
using System.Collections.Generic;
using System.IO;

namespace YYX.CSharp.Common
{
    public class FileLogger
    {
        private const string DefaultDirectory = "C://Error";

        static FileLogger()
        {
            var exist = Directory.Exists(DefaultDirectory);
            if (!exist)
            {
                Directory.CreateDirectory(DefaultDirectory);
            }
        }

        public void WriterException(Exception exception)
        {
            File.WriteAllLines(DefaultDirectory + "//" + DateTime.Now.ToString("dd-MM-yyyy mm hh ss") + ".txt", new List<string>
            {
                "Message:" + exception.Message,
                exception.StackTrace
            });
        }
    }
}