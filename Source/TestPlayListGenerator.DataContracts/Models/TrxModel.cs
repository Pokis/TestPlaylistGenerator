using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models
{
    [DataContract]
    [XmlRoot(ElementName = "TestRun", Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class TrxModel
    {
        #region Attributes

        [XmlAttribute(AttributeName = "id")]
        public Guid Id { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "runUser")]
        public string User { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public string Namespace { get; set; }

        #endregion

        #region Elements
        [XmlElement(ElementName = "Times")]
        public Times Times { get; set; }

        [XmlElement(ElementName = "TestSettings")]
        public TestSettings TestSettings { get; set; }

        [XmlArray(ElementName = "Results")]
        [XmlArrayItem("UnitTestResult")]
        public UnitTestResult[] Results { get; set; }

        [XmlArray(ElementName = "TestDefinitions")]
        [XmlArrayItem("UnitTest")]
        public UnitTestDefinition[] TestDefinitions { get; set; }

        [XmlArray(ElementName = "TestEntries")]
        [XmlArrayItem("TestEntry")]
        public TestEntry[] TestEntries { get; set; }

        [XmlArray(ElementName = "TestLists")]
        [XmlArrayItem("TestList")]
        public TestList[] TestLists { get; set; }

        [XmlElement(ElementName = "ResultSummary")]
        public ResultSummary ResultSummary { get; set; }

        #endregion

    }
}
