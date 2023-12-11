using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoppyFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter source file: ");
            string sourcePath = Console.ReadLine();
            Console.WriteLine("Enter destination file: ");
            string destinationPath = Console.ReadLine();

            FileInfo source = new FileInfo(sourcePath);
            FileInfo des = new FileInfo(destinationPath);
            try
            {
                CopyFileUsingFileInfo(source, des);
                Console.WriteLine("Copy Completed");
            }
            catch (IOException e)
            {
                Console.WriteLine("Cannot Copy");
                Console.Error.WriteLine(e.Message);
            }
        }
        private static void CopyFileUsingFileInfo(FileInfo source, FileInfo des)
        {
            source.CopyTo(des.FullName, true);
        }
        
    }

}
