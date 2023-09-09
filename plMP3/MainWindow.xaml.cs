using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace plMP3
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

        private void choese_but_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media Files|*.avi;*.mp4;*.mkv;*.mp3|All Files|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFilePath = openFileDialog.FileName;

                string fileExtension = System.IO.Path.GetExtension(selectedFilePath);

                if (fileExtension.Equals(".mp3", StringComparison.OrdinalIgnoreCase))
                {
                    mediaElement1.Source = new Uri(selectedFilePath);
                    mediaElement1.Play(); 
                }
                else
                {
                    mediaElement1.Source = new Uri(selectedFilePath);
                }
            }
        }

        private void play_but_Click(object sender, RoutedEventArgs e)
        {
            if (mediaElement1.Source != null)
            {
                mediaElement1.Play(); 
            }
        }

        private void pause_but_Click(object sender, RoutedEventArgs e)
        {
            if (mediaElement1.Source != null)
            {
                mediaElement1.Pause();
            }
        }
    }

}
