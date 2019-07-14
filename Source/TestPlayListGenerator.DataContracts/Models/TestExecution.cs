using System;
using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models
{
    public class TestExecution
    {
        [XmlAttribute(AttributeName = "id")]
        public Guid Id { get; set; }
    }
}
