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
    /// Interaction logic for NoteUserControl.xaml
    /// </summary>
    public partial class NoteUserControl : UserControl
    {
        NoteProxy Note;
        MainWindow MainW;
        public NoteUserControl(NoteProxy note, MainWindow MW)
        {
            this.InitializeComponent();

            if (!note.IsAudio)
            {
                AudioEl.Opacity = 0;
            }
            else
            {
                AudioEl.Opacity = 1;
            }

            if (!note.IsPicture)
            {
                PictureEl.Opacity = 0;
            }
            else
            {
                PictureEl.Opacity = 1;
            }

            if (!note.IsVideo)
            {
                VideoEl.Opacity = 0;
            }
            else
            {
                VideoEl.Opacity = 1;
            }
            Main.Background = note.Scb;
            Main.BorderBrush = note.BorderColor;
            Note = note;
            MainW = MW;
            Theme.Content = note.Currentnote.NoteTheme;
        }

        private void UserControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            NotePage NP = new NotePage(MainW ,Note.Currentnote);
            NP.Show();
            
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DatePick.SelectedDate = Note.DateNote;
        }
    }
}
