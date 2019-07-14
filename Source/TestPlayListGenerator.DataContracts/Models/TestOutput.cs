using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models
{
    public class TestOutput
    {
        [XmlElement(ElementName = "StdOut")]
        public string StdOut { get; set; }
    }
}
