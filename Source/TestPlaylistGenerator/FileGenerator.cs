using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models;
using Judeikis.Domantas.TestPlaylist.Generator.Models;

namespace Judeikis.Domantas.TestPlaylist.Generator
{

    public class FileGenerator
    {
        public TrxModel ReadTrx(string path)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(TrxModel));
            TrxModel trxModel = null;

            using (var xmlReader = XmlReader.Create(path))
            {
                
                trxModel = (TrxModel) serializer.Deserialize(xmlReader);
            }

            return trxModel;
        }

        public string GeneratePlaylist(PlayListModel model)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PlayListModel));
            XmlSerializerNamespaces xmlNamespaces = new XmlSerializerNamespaces(new[] { new XmlQualifiedName("", "") });
            using (var memory = new MemoryStream())
            {
                using (var textWriter = new StreamWriter(memory, new UTF8Encoding(false)))
                using (var xmlWriter = new XmlTextWriter(textWriter))
                {
                    serializer.Serialize(xmlWriter, model, xmlNamespaces);
                }

                var byteArray = memory.ToArray();
                return System.Text.Encoding.UTF8.GetString(byteArray);
            }

        }
    }

}
