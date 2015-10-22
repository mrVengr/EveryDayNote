namespace EveryDayNote
{
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
    using EveryDayNoteLib;

    /// <summary>
    /// Interaction logic for MainWindow
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NotePage np = new NotePage();
            np.Show();
        }

        private void RefreshB_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in NoteProxy.NotesPr)
            {
                Border border = new Border();
                border.Height = 90;
                DockPanel.SetDock(border, Dock.Top);
                Button noteB = new Button();
                border.Child = noteB;
                DockP.Children.Add(border);
                
                DockPanel dockPanel = new DockPanel();
                ////DP.Height = Double.NaN;
                ////DP.Width = Double.NaN;
                dockPanel.VerticalAlignment = VerticalAlignment.Stretch;
                dockPanel.HorizontalAlignment = HorizontalAlignment.Stretch;
                if (item.IsAudio)
                {
                    Button image = new Button();
                    var brush = new ImageBrush();
                    brush.ImageSource = new BitmapImage(new Uri("Images/Audio.png", UriKind.Relative));
                    image.Background = brush;
                    Border rightBborder = new Border();
                    rightBborder.Width = 50;
                    rightBborder.Height = 50;
                    rightBborder.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
                    rightBborder.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                    DockPanel.SetDock(rightBborder, Dock.Right);
                    dockPanel.Children.Add(rightBborder);
                    rightBborder.Child = image;
                }

                if (item.IsPicture)
                {
                    Button image = new Button();
                    var brush = new ImageBrush();
                    brush.ImageSource = new BitmapImage(new Uri("Images/Picture.png", UriKind.Relative));
                    image.Background = brush;
                    Border infoDatBborder = new Border();
                    infoDatBborder.Width = 50;
                    infoDatBborder.Height = 50;
                    DockPanel.SetDock(infoDatBborder, Dock.Right);
                    dockPanel.Children.Add(infoDatBborder);
                    infoDatBborder.Child = image;
                }

                if (item.IsVideo)
                {
                    Button image = new Button();
                    var brush = new ImageBrush();
                    brush.ImageSource = new BitmapImage(new Uri("Images/Video.png", UriKind.Relative));
                    image.Background = brush;
                    Border infoBborder = new Border();
                    infoBborder.Width = 50;
                    infoBborder.Height = 50;
                    DockPanel.SetDock(infoBborder, Dock.Right);
                    dockPanel.Children.Add(infoBborder);
                    infoBborder.Child = image;
                }

                noteB.Content = dockPanel;
            }
        }
    }
}