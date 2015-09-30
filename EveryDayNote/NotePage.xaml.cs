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
        Prototype voNote;
        Prototype videoNote;
        Prototype pictNote;
        Context context;


        private void Text_Click(object sender, RoutedEventArgs e)
        {
            context = new Context((TextNote)textNote.Clone());
            context.ExecuteOperation();
            MessageBox.Show(TextNote.s);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textNote = new TextNote("Text");
            voNote = new VoNote("Voice");
            videoNote = new VideoNote("Video");
            pictNote = new PictNote("Pict");
        }
    }
}
