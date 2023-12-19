using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5._1
{
    class InOutOperation
    {
        // 1) declare properties  CurrentPath - path to file (without name of file), CurrentDirectory - name of current directory,
        // CurrentFile - name of current file
        private string CurrentPath { get; set; }
        private string CurrentDirectory { get; set; }
        private string CurrentFileName { get; set; }
        private string ThisFileDestination { get; set; }

        public InOutOperation(string currentPath, string currentDirectory, string currentFileName)
        {
            CurrentPath = currentPath;
            CurrentFileName = currentFileName;
            CurrentDirectory = currentDirectory;
            ThisFileDestination = currentPath + currentDirectory + currentFileName;
            CreateDirectory();
        }

        // 2) declare public methods:
        //ChangeLocation() - change of CurrentPath; 
        // method takes new file path as parameter, creates new directories (if it is necessary)

        public void ChangeLocation(string location)
        {
            ThisFileDestination = location;
        }

        // CreateDirectory() - create new directory in current location

        private void CreateDirectory()
        {
            using FileStream file = new FileStream(ThisFileDestination, FileMode.OpenOrCreate);
        }

        // WriteData() – save data to file
        // method takes data (info about computers) as parameter

        public void WriteData(Computer[] computers)
        {
            using (StreamWriter file = new StreamWriter(ThisFileDestination))
            {
                for (int i = 0; i < computers.Length; i++)
                {
                    file.WriteLine(computers[i].ToString());
                }
            }
        }

        // ReadData() – read data from file
        // method returns info about computers after reading it from file

        public string ReadData()
        {
            string data = "";
            using (StreamReader file = new StreamReader(ThisFileDestination))
            {
                data = file.ReadToEnd();
            }
            return data;
        }

        // WriteZip() – save data to zip file
        // method takes data (info about computers) as parameter

        public void WriteZip(string destination, Computer[] computers)
        {
            using FileStream file = File.Create(destination);
            byte[] buffer = File.ReadAllBytes(ThisFileDestination);
            using (GZipStream zip = new GZipStream(file, CompressionMode.Compress))
            {
                zip.Write(buffer, 0, buffer.Length);
            }
        }

        // ReadZip() – read data from file
        // method returns info about computers after reading it from file

        public byte[] ReadZip(string destination)
        {
            byte[] a;
            using FileStream file = File.OpenRead(destination);
            byte[] buffer = new byte[1024];
            using (GZipStream zip = new GZipStream(file, CompressionMode.Decompress))
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = zip.Read(buffer, 0, 1024);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    a = memory.ToArray();
                }
            }
            return a;
        }

        public byte[] ReadZip(string destination, string fileInfoPath)
        {
            byte[] a = new byte[2048];

            using FileStream file = File.OpenRead(destination);
            using (GZipStream zip = new GZipStream(file, CompressionMode.Decompress))
            {
                using (FileStream zipInfo = new FileStream(fileInfoPath, FileMode.Create, FileAccess.Write))
                {
                    zip.CopyTo(zipInfo);
                }
                using (FileStream zipInfo = new FileStream(fileInfoPath, FileMode.Open, FileAccess.Read))
                {
                    zipInfo.Read(a, 0, a.Length);
                }
            }
            return a;
        }

        // ReadAsync() – read data from file asynchronously
        // method is async
        // method returns Task with info about computers
        // use ReadLineAsync() method to read data from file
        // Note: don't forget about await

        public async Task ReadAsync()
        {
            if (File.Exists(ThisFileDestination))
            {
                string text = await ReadAllAsync(ThisFileDestination);
                Console.WriteLine();
                Console.WriteLine(text);
                return;
            }
            Console.WriteLine("File is not found");
        }

        private async Task<String> ReadAllAsync(string destination)
        {
            Thread.Sleep(1000);
            using FileStream fileAsync = new FileStream(
                destination, FileMode.Open, FileAccess.Read,
                FileShare.Read, bufferSize: 4096, useAsync: true
                );
            StringBuilder sb = new StringBuilder();
            byte[] buffer = new byte[2048];
            int count = 0;

            while ((count = await fileAsync.ReadAsync(buffer, 0, buffer.Length)) != 0)
            {
                string text = Encoding.ASCII.GetString(buffer, 0, count); 
                sb.Append(text);
            }
            return sb.ToString();
        }

        // 7)
        // ADVANCED:
        // WriteToMemoryStream() – save data to memory stream
        // method takes data (info about computers) as parameter
        // info about computers is saved to Memory Stream

        // use  method GetBytes() from class UnicodeEncoding to save array of bytes from string data 
        // create new file stream
        // use method WriteTo() to save memory stream to file stream 
        // method returns file stream

        // WriteToFileFromMemoryStream() – save data to file from memory stream and read it
        // method takes file stream as parameter
        // save data to file      


        // Note: 
        // - use '//' in path string or @ before it (for correct path handling without escape sequence)
        // - use 'using' keyword to organize correct working with files
        // - don't forget to check path before any file or directory operations
        // - don't forget to check existed directory and file before creating
        // use File class to check files, Directory class to check directories, Path to check path


    }
}
