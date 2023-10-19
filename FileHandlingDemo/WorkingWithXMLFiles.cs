using System;
using System.IO;
using System.Text;
using System.Xml;

namespace FileHandlingDemo
{
    internal class WorkingWithXMLFiles
    {
        static void Main(string[] args)
        {
            CreateAndWriteXMLFile();
            //FileStream fs = new FileStream(@"D:\NewDrive\MphasisSept\file10.xml", FileMode.Open, FileAccess.Read);
            //XmlTextReader xr=new XmlTextReader(fs);
            //while (xr.Read())
            //{
            //    //first step--switch tab+tab
            //    //second step--type xr.NodeType and press down arrow key

            //    StringBuilder bldr=new StringBuilder();
                

            //    switch (xr.NodeType)
            //    {
            //        case XmlNodeType.None:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.Element:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.Attribute:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.Text:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.CDATA:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.EntityReference:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.Entity:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.ProcessingInstruction:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.Comment:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.Document:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.DocumentType:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.DocumentFragment:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.Notation:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.Whitespace:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.SignificantWhitespace:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.EndElement:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.EndEntity:
            //            bldr.Append(xr.Value);
            //            break;
            //        case XmlNodeType.XmlDeclaration:
            //            bldr.Append(xr.Value);
            //            break;
                    
            //    }
            //    Console.WriteLine(bldr);
            //}

            
            Console.ReadLine();

        }

        private static void CreateAndWriteXMLFile()
        {


            FileStream fs = new FileStream(@"D:\NewDrive\MphasisSept\file10.xml", FileMode.Create, FileAccess.Write);
            XmlWriter writer = null;
            using (writer = XmlWriter.Create(fs))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Book");
                writer.WriteElementString("bookid", "1");
                writer.WriteElementString("bookname", "Learn csharp");
                writer.WriteElementString("bookprice", "400");
                writer.WriteEndElement();
                           
               
                

                writer.WriteEndDocument();
                writer.Flush();
            }
            fs.Close();
            fs.Dispose();
        }
    }
}
