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
    using UserControls;
    using EveryDayNoteLib;
    
    /// <summary>
    /// Interaction logic for NotePage
    /// </summary>
    public partial class NotePage : Window
    {
        private Note note = new Note();
        private NoteComponent component = new NoteComponent();
        private TextEncrypt Encrypt = new TextEncrypt();
        private MainWindow MainW;
        bool IsNew = true;
        public NotePage(MainWindow MW)
        {
            MainW = MW;
            this.InitializeComponent();
        }

        public NotePage(MainWindow MW, Note NP)
        {
            note = NP;
            component = NP.NoteComponent;
            foreach (NoteProxy item in NoteProxy.NotesPr)
            {
                if (item.Currentnote == this.note)
                {
                    NoteProxy.NotesPr.Remove(item);
                    break;
                }
            }
            MainW = MW;
            this.InitializeComponent();
            FieldPanel.Children.Clear();
            foreach (NotePart item in this.note.NoteComponent.Children)
            {
                FieldPanel.Children.Add(item.RestoreData());
            }
            IsNew = false;
        }

        private void Text_Click(object sender, RoutedEventArgs e)
        {
            TextNote TN = new TextNote();
            //Encrypt.SetComponent(TN);
            this.component.Add(TN);
            TextPartUC tP = new TextPartUC();
            tP.InitializeComponent();
            TN.tp = tP;
            tP.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            FieldPanel.Children.Add(tP);
        }

        private void Voice_Click(object sender, RoutedEventArgs e)
        {
            VoNote VoN = new VoNote();
            this.component.Add(VoN);
            AudioPartUC aP = new AudioPartUC();
            aP.InitializeComponent();
            VoN.ap = aP;
            aP.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            FieldPanel.Children.Add(aP);
        }

        private void Video_Click(object sender, RoutedEventArgs e)
        {
            VideoNote VN = new VideoNote();
            this.component.Add(VN);
            VideoPartUC vP = new VideoPartUC();
            vP.InitializeComponent();
            VN.vp = vP;
            vP.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            FieldPanel.Children.Add(vP);
        }

        private void Picture_Click(object sender, RoutedEventArgs e)
        {
            PictNote PN = new PictNote();
            this.component.Add(PN);
            PicturePartUC pP = new PicturePartUC();
            pP.InitializeComponent();
            PN.pictp = pP;
            pP.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            FieldPanel.Children.Add(pP);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.note.NoteComponent = this.component;
            this.note.NoteTheme = Theme.Text;
            this.note.GetProxy();
            foreach (NotePart item in this.note.NoteComponent.Children)
            {
                item.SetData();
            }
            MainW.RefreshTable();
        }

        private void Date_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? date = Date.SelectedDate;
            if (date == null)
            {
            }
            else
            {
                note.DateNote = date.Value;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!IsNew)
            {
                Date.SelectedDate = note.DateNote;
            }
            else
            {
                Random Rnd = new Random();
                byte R = (byte)(Rnd.Next(2, 7) * 20);
                byte B = (byte)(Rnd.Next(2, 7) * 20);
                byte G = (byte)(Rnd.Next(8, 12) * 20);
                SolidColorBrush SCB = new SolidColorBrush();
                SCB.Color = Color.FromArgb(255, R, G, B);
                note.FormColor = SCB;
            }
        }



    }
}
