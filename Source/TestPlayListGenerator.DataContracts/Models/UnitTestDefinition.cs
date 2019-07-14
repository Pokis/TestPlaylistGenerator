using System;
using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models
{
    public class UnitTestDefinition
    {
        #region Attributes
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "storage")]
        public string Storage { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public Guid Id { get; set; }
        #endregion

        [XmlElement(ElementName = "Execution")]
        public TestExecution TestExecution { get; set; }

        [XmlElement(ElementName = "TestMethod")]
        public TestMethodInformation TestMethodInformation { get; set; }
    }
}
