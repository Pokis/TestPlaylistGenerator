using System.Collections.Generic;
using System.Linq;
using Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models;

namespace Judeikis.Domantas.TestPlaylist.Generator.Models
{
    public class TestsResultModel
    {
        private TrxModel TrxModel { get; set; }

        public TestResult[] Results { get; set; }
        public PlayListModel PlayList { get; set; }

        public int TotalTests => Results.Length;
        public int TotalPassed => Results.Count(r => r.Outcome == Outcome.Passed);
        public int TotalFailed => Results.Count(r => r.Outcome == Outcome.Failed);

        public TestsResultModel(TrxModel model)
        {
            Initialize(model);
        }

        private void Initialize(TrxModel model)
        {
            LoadResults(model);
            LoadPlayList(model);

        }

        private void LoadResults(TrxModel model)
        {
            TrxModel = model;
            var testResults = new List<TestResult>();

            foreach (var testResult in model.Results)
            {
                var result = new TestResult();
                result.TestName = testResult.TestName;
                result.Outcome = testResult.Outcome == TestOutcome.Passed ? Outcome.Passed : Outcome.Failed;
                var testDefinition = model.TestDefinitions.FirstOrDefault(def => def.Id == testResult.TestId);
                if (testDefinition == null)
                {
                    continue;
                }
                result.ClassName = testDefinition.TestMethodInformation.ClassName;

                testResults.Add(result);
            }

            Results = testResults.ToArray();
        }

        private void LoadPlayList(TrxModel model)
        {
            var failedTests = Results.Where(r => r.Outcome == Outcome.Failed).ToArray();

            var tests = new List<PlayListTest>(); 
            foreach (var failedTest in failedTests)
            {
                tests.Add(new PlayListTest
                {
                    TestName = failedTest.FullName
                });
            }

            PlayList = new PlayListModel
            {
                TestNames = tests.ToArray()
            };
        }

    }
}
