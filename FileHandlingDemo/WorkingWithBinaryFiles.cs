using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingDemo
{
    internal class WorkingWithBinaryFiles
    {
        static void Main(string[] args)
        {
            //createAndWriteBinary();
            FileStream fs = new FileStream(@"D:\NewDrive\MphasisSept\file12.bin", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            Console.Write(br.ReadInt32());
            br.Close();
            br.Dispose();
            fs.Close();
            fs.Dispose();
            Console.Read();

        }

        private static void createAndWriteBinary()
        {
            FileStream fs = new FileStream(@"D:\NewDrive\MphasisSept\file12.bin", FileMode.Create, FileAccess.Write);
            //streamwriter represent pen/pencil
            BinaryWriter writer = new BinaryWriter(fs);

            try
            {
                //pen/pencil----same line(Write), newline(WriteLine)

                writer.Write(12323123);
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
