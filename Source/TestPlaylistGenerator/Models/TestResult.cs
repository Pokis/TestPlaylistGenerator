namespace Judeikis.Domantas.TestPlaylist.Generator.Models
{
    public class TestResult
    {
        public string TestName { get; set; }
        public string ClassName { get; set; }
        public string FullName => $"{ClassName}.{TestName}";
        public Outcome Outcome { get; set; }
    }
}
