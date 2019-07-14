using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models
{
    public class ResultSummary
    {
        [XmlAttribute(AttributeName = "outcome")]
        public TestOutcome Outcome { get; set; }
    }
}
