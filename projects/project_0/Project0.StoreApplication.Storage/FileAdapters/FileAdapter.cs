using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.FileAdapters
{

    public class FileAdapter
    {
        public List<F> ReadFromFile<F>(string path) where F : class
        {   
            var file = new StreamReader(path);

            var xml = new XmlSerializer(typeof(F));

            var result = xml.Deserialize(file) as List<F>;

            file.Close();       

            return result;
        }

        public void WriteToFile(List<Store> stores)
        {   
            var path = "~/revature/austin_code/data/project_0.xml";
            
            var file = new StreamWriter(path);

            var xml = new XmlSerializer(typeof(Store));

            xml.Serialize(file, stores);

            file.Close();
        }
    }
    
}



