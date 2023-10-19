using System;
using System.IO;
using System.Runtime.InteropServices;

namespace FileHandlingDemo
{
    internal class WorkingWithTextFiles
    {
        static void Main(string[] args)
        {

            //createFileandWrite();
            //OpenAndReadFile();
            //EditFileAppendMode();
            //TruncateFile();

            Console.Read();





        }

        private static void TruncateFile()
        {
            string filename = @"D:\\NewDrive\\MphasisSept\\file2.txt";
            bool a = File.Exists(filename);
            if (a)
            {
                //truncate
                FileStream fs = new FileStream(filename, FileMode.Truncate, FileAccess.Write);

                try
                {

                    Console.WriteLine("truncated....");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {

                    fs.Close();
                    fs.Dispose();
                }

            }
            else
            {
                Console.WriteLine("file doesn't exists....");
            }
        }

        private static void EditFileAppendMode()
        {
            string filename = @"D:\\NewDrive\\MphasisSept\\file3.txt";
            bool a = File.Exists(filename);
            if (a)
            {
                FileStream fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
                StreamWriter wr = new StreamWriter(fs);
                try
                {

                    wr.WriteLine("Appending this line to the file");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    wr.Flush();
                    wr.Close();
                    wr.Dispose();
                    fs.Close();
                    fs.Dispose();
                }

            }
            else
            {
                Console.WriteLine("file doesn't exists");
            }
        }

        private static void OpenAndReadFile()
        {
            bool ans = File.Exists(@"D:\\NewDrive\\MphasisSept\\file3.txt");
            if (ans)
            {
                FileStream fs = null;
                try
                {

                    fs = new FileStream(@"D:\\NewDrive\\MphasisSept\\file2.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = null;
                    try
                    {
                        sr = new StreamReader(fs);
                        string data = sr.ReadToEnd();
                        Console.WriteLine(data);

                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);

                    }

                    finally
                    {

                        sr.Close();
                        sr.Dispose();
                        fs.Close();
                        fs.Dispose();
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                Console.WriteLine("File doesn't exists");

            }
        }

        private static void createFileandWrite()
        {
            FileStream fs = new FileStream(@"D:\NewDrive\MphasisSept\file2.txt", FileMode.Create, FileAccess.Write);
            //streamwriter represent pen/pencil
            StreamWriter writer = new StreamWriter(fs);
            try
            {
                //pen/pencil----same line(Write), newline(WriteLine)
                writer.Write("Hello World");
                writer.Write("This is second line in the file");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Flush();//flush means the buffer data if anything is remaining will be written to the file
                writer.Close();
                writer.Dispose();
                fs.Close();//close and save
                fs.Dispose();

            }
        }
    }
}
