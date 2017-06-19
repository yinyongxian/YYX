using System;
using System.IO;
using YYX.CSharp.IO;

namespace YYX.TestCA
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFile.Write("1.txt", "hello");


            var x = File.Exists("1.txt");
            var text =
                TextFile.Read("1.txt");
            Console.WriteLine(@"读取" + text);

            Console.ReadLine();
        }
    }
}
