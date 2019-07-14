using System;
using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models
{
    public class TestList
    {
        [XmlAttribute(AttributeName = "id")]
        public Guid Id { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name{ get; set; }
    }
}
