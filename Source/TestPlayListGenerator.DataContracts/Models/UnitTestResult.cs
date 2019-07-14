using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models
{
    public class UnitTestResult
    {
        #region Attributes

        [XmlAttribute(AttributeName = "executionId")]
        public Guid ExecutionId { get; set; }

        [XmlAttribute(AttributeName = "testId")]
        public Guid TestId { get; set; }

        [XmlAttribute(AttributeName = "testName")]
        public string TestName { get; set; }

        [XmlAttribute(AttributeName = "computerName")]
        public string ComputerName { get; set; }


        [XmlIgnore]
        public TimeSpan TestDuration { get; set; }


        [XmlAttribute(AttributeName = "duration")]
        public string Duration
        {
            get
            {
                return XmlConvert.ToString(TestDuration);
            }
            set
            {
                TestDuration = string.IsNullOrEmpty(value) ?
                    TimeSpan.Zero : TimeSpan.Parse(value);
            }

        }



        [XmlAttribute(AttributeName = "startTime")]
        public DateTime StartTime { get; set; }

        [XmlAttribute(AttributeName = "endTime")]
        public DateTime EndTime { get; set; }

        [XmlAttribute(AttributeName = "testType")]
        public Guid TestType { get; set; }

        [XmlAttribute(AttributeName = "outcome")]
        public TestOutcome Outcome { get; set; }

        [XmlAttribute(AttributeName = "testListId")]
        public Guid TestListId { get; set; }

        [XmlAttribute(AttributeName = "relativeResultsDirectory")]
        public Guid RelativeResultsDirectory { get; set; }
        #endregion

        [XmlElement(ElementName = "Output")]
        public TestOutput Output { get; set; }
    }
}
