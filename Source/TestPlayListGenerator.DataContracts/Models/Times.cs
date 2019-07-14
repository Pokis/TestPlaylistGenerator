using System;
using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models
{
    public class Times
    {
        [XmlAttribute(AttributeName = "creation")]
        public DateTime CreationTime { get; set; }

        [XmlAttribute(AttributeName = "queuing")]
        public DateTime QueuedTime { get; set; }

        [XmlAttribute(AttributeName = "start")]
        public DateTime StartTime { get; set; }

        [XmlAttribute(AttributeName = "finish")]
        public DateTime FinishTime { get; set; }
    }
}
