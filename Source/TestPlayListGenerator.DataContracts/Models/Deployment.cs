using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models
{
    public class Deployment
    {
        [XmlAttribute(AttributeName = "runDeploymentRoot")]
        public string RunDeploymentRoot { get; set; }
    }
}
