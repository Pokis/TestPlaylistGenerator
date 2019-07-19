using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models
{
    public enum TestOutcome
    {
        [XmlEnum("Passed")]
        Passed,

        [XmlEnum("Failed")]
        Failed,

        [XmlEnum("NotExecuted")]
        NotExecuted,

        [XmlEnum("Skipped")]
        Skipped,

        [XmlEnum("Inconclusive")]
        Inconclusive
    }
}
