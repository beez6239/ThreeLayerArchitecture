using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using BussinessLogicLayer;
using PresentationLayer;





namespace DataAcessLayer
{
    public class EntityContext : Methodprovider
    {
        static void Main(string[] args)
        {
            EntityContext work = new EntityContext();
            work.writefile(@"");
           
        }
        public void writefile(string ToPath)
        {
            Variables data = new Variables();
            XmlSerializer writexml = new XmlSerializer(typeof(Variables));

            StreamWriter file = new StreamWriter(File.Open(ToPath, FileMode.OpenOrCreate, FileAccess.Write));
            writexml.Serialize(file, data);
            file.Flush();
            file.Close();

        }

        public void Readfile(string FromPath)
        {
            XmlSerializer readxml = new XmlSerializer(typeof(Variables));
            StreamReader read = new StreamReader(FromPath);

            Variables Data = (Variables)readxml.Deserialize(read);
            read.ReadToEnd();
            read.Close();



        }


    }
}
