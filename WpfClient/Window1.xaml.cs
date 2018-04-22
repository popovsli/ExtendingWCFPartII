using System;
using System.Windows;
using System.IO;
using WcfExtensions;
using Common.Services;
using System.Diagnostics;

namespace WpfClient
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnGetFile_Click(object sender, RoutedEventArgs e)
        {
            GetFile();
        }

        private void GetFile()
        {
            try
            {
                var configFile = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\WcfClientConfiguration.xml";
                configFile = Path.GetFullPath(configFile);
                var proxy = WcfClientHelper.GetProxy<IFileService>(configFile);
                var fileName = "Spring1.2.chm";
                var fileAsByte = proxy.GetFile(fileName);
                var filePath = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\" + fileName;
                filePath = Path.GetFullPath(filePath);
                File.WriteAllBytes(filePath, fileAsByte);
                Process.Start(filePath);
            }
            catch (Exception exception)
            {
                ShowMessage(string.Format("Exception Type: {0}, Exception message: {1}", exception.GetType().AssemblyQualifiedName, exception.Message), true);
            }
        }

        private void ShowMessage(string message, bool isError)
        {
            txtMessage.Text = message;
        }
    }
}
