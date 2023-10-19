using System;
using System.IO;
using System.Collections.Generic;

namespace FileHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.Create("firstFile.txt");
            //string[] s = new string[2] {"Hello","World" };
            //File.WriteAllLines("secondfile.txt", s);
            //File.WriteAllText("D:\\NewDrive\\MphasisSept\\abc.txt", "Welcome...File Trial ");
            //File.WriteAllLines(@"D:\NewDrive\MphasisSept\xyz.txt", s);
            //File.Create(@"D:\NewDrive\MphasisSept\pqe.txt");
            //File.Delete(@"D:\NewDrive\MphasisSept\pqe.txt");
            //File.Delete(@"D:\NewDrive\MphasisSept\abc.txt");
            //File.Delete(@"D:\NewDrive\MphasisSept\xyz.txt");

            //Directory.CreateDirectory("dir1");
            //File.Move("secondfile.txt", "dir1\\secfile1.txt");
            //File.Move("D:\\NewDrive\\MphasisSept\\gcNotes.txt", "dir1\\mygarbageCollectionNotes.txt");
            //File.Copy("firstFile.txt", "dir1\\firstFile.txt");
            //string s=File.ReadAllText("firstFile.txt");
            //File.AppendAllText(@"dir1\\secfile1.txt", s);
            IEnumerable<string> files=Directory.EnumerateFiles("dir1");
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            IEnumerable<string> dirs=Directory.EnumerateDirectories("D:\\NewDrive\\MphasisSept\\");
            foreach (var item in dirs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(  "------------------------------");
            string[]  filesinDir=Directory.GetFiles(@"D:\NewDrive\MphasisSept\");
            foreach (var item in filesinDir)
            {
                Console.WriteLine(  item);
            }







            Console.Read();

        }
    }
}
