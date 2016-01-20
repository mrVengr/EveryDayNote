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
    /// Interaction logic for AudioPartUC.xaml
    /// </summary>
    public partial class AudioPartUC : UserControl
    {
        public AudioPartUC()
        {
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            this.InitializeComponent();
        }

        public AudioPartUC(MediaElement Res)
        {
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            audio = Res;
            this.InitializeComponent();
        }
        MediaElement audio = new MediaElement();

         private bool mediaPlayerIsPlaying = false;
        private bool userIsDraggingSlider = false;

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "Media files (*.mp3)|*.mp3|All files (*.*)|*.*";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                AudioPlay.Source =  new Uri(dlg.FileName);
                audio.Source = AudioPlay.Source;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((AudioPlay.Source != null) && (AudioPlay.NaturalDuration.HasTimeSpan) && (!userIsDraggingSlider))
            {
                Progress.Minimum = 0;
                Progress.Maximum = AudioPlay.NaturalDuration.TimeSpan.TotalSeconds;
                Progress.Value = AudioPlay.Position.TotalSeconds;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            AudioPlay.Source = audio.Source;
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AudioPlay.Pause();
            }
            catch { }
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AudioPlay.Play();
            mediaPlayerIsPlaying = true;
            }
            catch { }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AudioPlay.Stop();
            mediaPlayerIsPlaying = false;
            }
            catch { }
        }

        private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            AudioPlay.Volume += (e.Delta > 0) ? 0.1 : -0.1;
        }

        private void Progress_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                userIsDraggingSlider = false;
                AudioPlay.Position = TimeSpan.FromSeconds(Progress.Value);
            }
            catch { }
        }
    }
}
