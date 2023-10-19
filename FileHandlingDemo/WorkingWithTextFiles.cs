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
            bool ans=File.Exists(@"D:\\NewDrive\\MphasisSept\\file3.txt");
            if (ans) {
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
               Console.WriteLine(  "File doesn't exists");

            }
            
           
             
                Console.Read();





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
