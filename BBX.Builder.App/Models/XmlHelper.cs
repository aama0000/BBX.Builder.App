using System.Xml.Serialization;

namespace BBX.Builder.App.Models
{
    public static class XmlHelper
    {
        public static void SaveToXml<T>(string path, T data)
        {
            var directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var serializer = new XmlSerializer(typeof(T));
            using (var writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static T LoadFromXml<T>(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("XML file not found", path);

            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StreamReader(path))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

    }

}
