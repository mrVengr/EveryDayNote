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

namespace EveryDayNote
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
            NotePage NP = new NotePage();
            NP.Show();

        }

        private void RefreshB_Click(object sender, RoutedEventArgs e)
        {

            foreach (var item in NoteProxy.notesPr)
            {

                Border border = new Border();
                border.Height = 90;
                DockPanel.SetDock(border, Dock.Top);
                Button NoteB = new Button();
                border.Child = NoteB;
                DockP.Children.Add(border);

                DockPanel DP = new DockPanel();
                DP.Height = Double.NaN;
                DP.Width = Double.NaN;
                DP.VerticalAlignment = VerticalAlignment.Stretch;
                DP.HorizontalAlignment = HorizontalAlignment.Stretch;


                if (item.isAudio)
                {
                    Button Im = new Button();
                    var brush = new ImageBrush();
                    brush.ImageSource = new BitmapImage(new Uri("Images/Audio.png", UriKind.Relative));
                    Im.Background = brush;
                    Border DBborder = new Border();
                    DBborder.Width = 50;
                    DockPanel.SetDock(DBborder, Dock.Right);
                    DP.Children.Add(DBborder);
                    DBborder.Child = Im;

                }
                if (item.isPicture)
                {
                    Button Im = new Button();
                    var brush = new ImageBrush();
                    brush.ImageSource = new BitmapImage(new Uri("Images/Picture.png", UriKind.Relative));
                    Im.Background = brush;
                    Border DBborder = new Border();
                    DBborder.Width = 50;
                    DockPanel.SetDock(DBborder, Dock.Right);
                    DP.Children.Add(DBborder);
                    DBborder.Child = Im;
                }
                if (item.isVideo)
                {
                    Button Im = new Button();
                    var brush = new ImageBrush();
                    brush.ImageSource = new BitmapImage(new Uri("Images/Video.png", UriKind.Relative));
                    Im.Background = brush;
                    Border DBborder = new Border();
                    DBborder.Width = 50;
                    DockPanel.SetDock(DBborder, Dock.Right);
                    DP.Children.Add(DBborder);
                    DBborder.Child = Im;
                }
                NoteB.Content = DP;
            }
        }

    }
}
