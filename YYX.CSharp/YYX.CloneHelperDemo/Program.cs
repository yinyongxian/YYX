using System;

using YYX.CSharp.IO;
using YYX.Data;

namespace YYX.CloneHelperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("尹永贤", 18);
            var secondPerson =  CloneHelper.CreateInstanceAgain(person);

            Console.ReadKey();
        }
    }
}
