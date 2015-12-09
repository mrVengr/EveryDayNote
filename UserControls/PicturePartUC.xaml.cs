namespace UserControls
{
    using System;
    using System.Collections.Generic;
    using System.IO;
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

    /// <summary>
    /// Interaction logic for PicturePartUC.xaml
    /// </summary>
    public partial class PicturePartUC : UserControl
    {
        public PicturePartUC()
        {
            //this.InitializeComponent();
        }

        public PicturePartUC(Image Res )
        {
            Im = Res;
            //this.InitializeComponent();
        }

        public Image Im = new Image();

        private void image_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
                image.Source = Im.Source;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "Pictures (.jpg)|*.jpg | PNG.Files (.png)|*.png";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                // Open document
                FileInfo fileInfo = new FileInfo(dlg.FileName);
                BitmapImage loadImage = new BitmapImage();
                    loadImage.BeginInit();
                    loadImage.UriSource = new Uri(fileInfo.FullName);
                    loadImage.EndInit();
 
                image.Source = loadImage;
                Im.Source = image.Source;
            }

        }
    }
}
