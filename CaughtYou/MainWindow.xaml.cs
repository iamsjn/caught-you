using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace CaughtYou
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string fileName;
        DateTime fileCreatedDate;
        DateTime fileModifiedDate;
        string fileSize;
        string fileExtension;
        string fileContents;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void file_open_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            fileName = openFileDialog.FileName;
            fileCreatedDate = File.GetCreationTime(fileName);
            fileModifiedDate = File.GetLastWriteTime(fileName);
            fileSize = new FileInfo(fileName).Length.ToString();
            fileExtension = System.IO.Path.GetExtension(fileName).ToString();

            if (fileExtension == ".txt")
            {
                fileContents = File.ReadAllText(fileName);
            }

            if(fileExtension == ".pdf")
            {

            }


            this.test_label.Content = fileContents.ToString();
        }
    }
}
