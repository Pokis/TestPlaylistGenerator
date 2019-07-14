using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models
{
    public class TestMethodInformation
    {
        [XmlAttribute(AttributeName = "codeBase")]
        public string CodeBase { get; set; }

        [XmlAttribute(AttributeName = "adapterTypeName")]
        public string AdapterTypeName { get; set; }

        [XmlAttribute(AttributeName = "className")]
        public string ClassName { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }
}
