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
        public NoteUserControl(NoteProxy note)
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
        }
    }
}
