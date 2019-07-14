using System;
using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models
{
    public class TestEntry
    {
        [XmlAttribute(AttributeName = "testId")]
        public Guid TestId { get; set; }

        [XmlAttribute(AttributeName = "executionId")]
        public Guid ExecutionId { get; set; }

        [XmlAttribute(AttributeName = "testListId")]
        public Guid TestListId { get; set; }
    }
}
