namespace UserControls
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

    /// <summary>
    /// Interaction logic for VideoPartUC.xaml
    /// </summary>
    public partial class VideoPartUC : UserControl
    {
        public VideoPartUC()
        {
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            this.InitializeComponent();
        }

        public VideoPartUC(MediaElement Res)
        {
            Media = Res;
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            this.InitializeComponent();
        }

        public MediaElement Media = new MediaElement();
        private bool mediaPlayerIsPlaying = false;
        private bool userIsDraggingSlider = false;

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "Media files (*.mp3;*.mpg;*.mpeg)|*.mp3;*.mpg;*.mpeg|All files (*.*)|*.*";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                 video.Source =  new Uri(dlg.FileName);
                Media.Source = video.Source;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((video.Source != null) && (video.NaturalDuration.HasTimeSpan) && (!userIsDraggingSlider))
            {
                Progress.Minimum = 0;
                Progress.Maximum = video.NaturalDuration.TimeSpan.TotalSeconds;
                Progress.Value = video.Position.TotalSeconds;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            video.Source = Media.Source;
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                video.Pause();
            }
            catch { }
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                video.Play();
            mediaPlayerIsPlaying = true;
            }
            catch { }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                video.Stop();
            mediaPlayerIsPlaying = false;
            }
            catch { }
        }


        private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            video.Volume += (e.Delta > 0) ? 0.1 : -0.1;
        }

        private void Progress_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                userIsDraggingSlider = false;
                video.Position = TimeSpan.FromSeconds(Progress.Value);
            }
            catch { }
        }
    }
}
