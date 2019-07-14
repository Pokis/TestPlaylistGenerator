using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.Models
{
    [XmlRoot(ElementName = "Playlist")]
    public class PlayListModel
    {
        [XmlAttribute("Version")]
        public string Version
        {
            get => "1.0";
            set { }
        }

        [XmlElement("Add")]
        public PlayListTest[] TestNames { get; set; }
    }
}
