using System;
using System.IO;
using System.Diagnostics;

namespace Desktop_Operations
{
    public class Operations
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // this path my desktop path

        public string [] fileNames
        {
            get
            {
               return Directory.GetFiles(path);
            }
        }
        public string[] directorieNames
        {
            get
            {
                return Directory.GetDirectories(path);
            }
        }
        public string parseName(string path)
        {
            string [] splitnames = path.Split('\\');
            int index = 0;
            for (int i = 0; i < splitnames.Length; i++)
            {
                index = i;
            }
            return splitnames[index];
        }

        public void Open(string path,bool type)
        {
            if (type) // Files
            {
                Process.Start("explorer.exe",path);
            }
            else // Directory
            {
                Process.Start("explorer.exe",path);
            }
        }
        public void Delete(string path, bool type)
        {
            if (type) // Files
            {
                File.Delete(path);
            }
            else // Directory
            {
                Directory.Delete(path); // Tested...
            }
        }
    }
}
