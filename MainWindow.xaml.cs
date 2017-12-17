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

namespace YoutubeWPFPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string videoId = idtextBox.Text;            
            string videoUrl = "http://www.youtube.com/v/{0}?version=3&playlist=1&hd=1&autoplay=1&fs=0&autohide=1&loop=1";
            string url = string.Format(videoUrl, videoId);
            browser.Source = new System.Uri(url);
        }
    }
}
