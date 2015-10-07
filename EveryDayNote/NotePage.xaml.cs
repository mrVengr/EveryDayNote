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

namespace EveryDayNote
{
    /// <summary>
    /// Interaction logic for NotePage.xaml
    /// </summary>
    public partial class NotePage : Window
    {
        public NotePage()
        {
            InitializeComponent();
        }
        Context context;
        Note note = new Note();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Text_Click(object sender, RoutedEventArgs e)
        {
            context = new Context(new TextNote());
            context.ExecuteOperation(note);

        }

        private void Voice_Click(object sender, RoutedEventArgs e)
        {
            context = new Context(new VoNote());
            context.ExecuteOperation(note);
        }

        private void Video_Click(object sender, RoutedEventArgs e)
        {

            context = new Context(new VideoNote());
            context.ExecuteOperation(note);
        }

        private void Picture_Click(object sender, RoutedEventArgs e)
        {
            context = new Context(new PictNote());
            context.ExecuteOperation(note);

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            note.GetProxy();
        }
    }
}
