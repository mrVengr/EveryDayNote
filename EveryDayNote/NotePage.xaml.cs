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
        TextNote textNote;
        Prototype voiceNote;
        Prototype videoNote;
        Prototype pictNote;
        Context context;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textNote = new TextNote("Text");
            voiceNote = new VoNote("Voice");
            videoNote = new VideoNote("Video");
            pictNote = new PictNote("Pict");
        }

        private void Text_Click(object sender, RoutedEventArgs e)
        {
            context = new Context((TextNote)textNote.Clone());
            context.ExecuteOperation();
            MessageBox.Show(Prototype.s);
        }

        private void Voice_Click(object sender, RoutedEventArgs e)
        {
            context = new Context((VoNote)voiceNote.Clone());
            context.ExecuteOperation();
            MessageBox.Show(Prototype.s);
        }

        private void Video_Click(object sender, RoutedEventArgs e)
        {

            context = new Context((VideoNote)videoNote.Clone());
            context.ExecuteOperation();
            MessageBox.Show(Prototype.s);
        }

        private void Picture_Click(object sender, RoutedEventArgs e)
        {
            context.SetStrategy((PictNote)pictNote.Clone());
            //context = new Context((TextNote)pictNote.Clone());
            context.ExecuteOperation();
            MessageBox.Show(Prototype.s);
        }
    }
}
