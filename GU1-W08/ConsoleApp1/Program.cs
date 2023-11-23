using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sourceFilePath = exeDirectory + @"data1.txt";
            string destinationFilePath = @"E:\data.txt";
            bool overwrite = true;
            FileInfo fInfo = new FileInfo(sourceFilePath);
            fInfo.CopyTo(destinationFilePath, overwrite);
        }
    }
}
