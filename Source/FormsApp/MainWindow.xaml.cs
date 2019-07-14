using System;
using System.Windows;
using Judeikis.Domantas.TestPlaylist.Generator.DataContracts.Models;
using Judeikis.Domantas.TestPlaylist.Generator.Models;
using Microsoft.Win32;

namespace Judeikis.Domantas.TestPlaylist.Generator.FormsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TrxModel TrxModelFile { get; set; }
        private TestsResultModel TestsResultModel { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadTrxFile(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(this);
            var filePath = openFileDialog.FileName;

            TrxModelFile = new FileGenerator().ReadTrx(filePath);

            TestsResultModel = new TestsResultModel(TrxModelFile);
            LoadLabels(TestsResultModel);
            LoadResultGrid(TestsResultModel);
            GenerateFailedTestsPlaylist();
        }

        private void LoadLabels(TestsResultModel testResultModel)
        {
            FailedTestsLabel.Content = testResultModel.TotalFailed;
            SuccededTestsLabel.Content = testResultModel.TotalPassed;
            TotalTestsLabel.Content = testResultModel.TotalTests;
        }

        private void LoadResultGrid(TestsResultModel testResultModel)
        {
            ResultDataGrid.ItemsSource = testResultModel.Results;
        }

        private void RegeneratePlaylist_ButtonClick(object sender, RoutedEventArgs e)
        {
            GenerateFailedTestsPlaylist();
        }

        private void ExportPlaylist_ButtonClick(object sender, RoutedEventArgs e)
        {
            ExportTestsPlaylist();
        }

        private void GenerateFailedTestsPlaylist()
        {
            var result = new FileGenerator().GeneratePlaylist(TestsResultModel.PlayList);
            FailedTestsPlayListBox.Text = result;
        }

        private void ExportTestsPlaylist()
        {
            var openFileDialog = new SaveFileDialog();
            openFileDialog.ShowDialog(this);
            var fileName = openFileDialog.FileName;

            if (!fileName.EndsWith("playlist", StringComparison.InvariantCultureIgnoreCase))
            {
                fileName += ".playlist";
            }

            System.IO.File.WriteAllText(fileName, FailedTestsPlayListBox.Text);

        }
    }
}
