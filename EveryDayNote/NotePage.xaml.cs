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
    /// Interaction logic for NotePage.xaml
    /// </summary>
    public partial class NotePage : Window
    {
        private Note note = new Note();
        private Context context;
        public NotePage()
        {
            this.InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void Text_Click(object sender, RoutedEventArgs e)
        {
            this.context = new Context(new TextNote());
            this.context.ExecuteOperation(this.note);
        }

        private void Voice_Click(object sender, RoutedEventArgs e)
        {
            this.context = new Context(new VoNote());
            this.context.ExecuteOperation(this.note);
        }

        private void Video_Click(object sender, RoutedEventArgs e)
        {
            this.context = new Context(new VideoNote());
            this.context.ExecuteOperation(this.note);
        }

        private void Picture_Click(object sender, RoutedEventArgs e)
        {
            this.context = new Context(new PictNote());
            this.context.ExecuteOperation(this.note);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.note.GetProxy();
        }
    }
}
