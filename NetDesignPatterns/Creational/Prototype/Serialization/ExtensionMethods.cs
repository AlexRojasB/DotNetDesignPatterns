using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace NetDesignPatterns.Creational.Prototype.Serialzation
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            using (var ms = new MemoryStream())
            {
                var s = new XmlSerializer(typeof(T));
                s.Serialize(ms, self);
                ms.Position = 0;
                return(T) s.Deserialize(ms);
            }
        }
    }
}
