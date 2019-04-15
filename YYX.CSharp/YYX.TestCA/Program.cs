using System;
using System.Collections.Generic;
using YYX.CSharp.Common;
using YYX.Data;

namespace YYX.TestCA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                var logger = new FileLogger();
                logger.WriterException(e);
                throw;
            }

            //Console.ReadLine();
        }
    }
}
