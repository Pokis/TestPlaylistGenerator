using System;
using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models
{
    public class TestSettings
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public Guid Id { get; set; }

        [XmlElement(ElementName = "Deployment")]
        public Deployment DeploymentRoot { get; set; }

    }
}
