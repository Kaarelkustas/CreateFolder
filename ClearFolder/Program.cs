using System;
using System.IO;

namespace ClearFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";
            DeleteAllfiles();
            DeleteAllfolders(rootPath);
        }

        public static void DeleteAllfiles()
        {
            string rootPath = @"C:\Users\opilane\samples";
            DirectoryInfo directory = new DirectoryInfo(rootPath);

            foreach(FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }
             
        }
        public static void DeleteAllfolder(string directoryName, bool ifExsist)
        {
            if (Directory.Exists(directoryName))
            {
                Directory.Delete(directoryName, true);
            }
            else if(ifExsist)
            {
                throw new SystemException("No such dir")
            }
        }     
    }
}
