using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.Models
{
    public class PlayListTest
    {
        [XmlAttribute("Test")]
        public string TestName { get; set; }
    }
}
