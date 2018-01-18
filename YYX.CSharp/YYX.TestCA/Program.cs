using System;
using System.Collections.Generic;
using System.IO;
using YYX.CSharp.IO;
using YYX.Data;

namespace YYX.TestCA
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashSet = new HashSet<Person>();
            //{
            //    "尹",
            //    "永",
            //    "贤",
            //    "贤",
            //};

            hashSet.Add(new Person("尹永贤", 1));
            hashSet.UnionWith(new[]{new Person("尹永贤", 2)});

            Console.ReadLine();
        }
    }
}
