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
    using System.Windows.Shapes;
    using EveryDayNoteLib;

    /// <summary>
    /// Interaction logic for NotePage
    /// </summary>
    public partial class NotePage : Window
    {
        private Note note = new Note();
        private NoteComponent component = new NoteComponent();

        public NotePage()
        {
            this.InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Text_Click(object sender, RoutedEventArgs e)
        {
            this.component.Add(new TextNote());
        }

        private void Voice_Click(object sender, RoutedEventArgs e)
        {
            this.component.Add(new VoNote());
        }

        private void Video_Click(object sender, RoutedEventArgs e)
        {
            this.component.Add(new VideoNote());
        }

        private void Picture_Click(object sender, RoutedEventArgs e)
        {
            this.component.Add(new PictNote());
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.note.NoteComponent = this.component;
            this.note.GetProxy();
        }
    }
}
