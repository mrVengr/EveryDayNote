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
    using UserControls;
    using EveryDayNoteLib;
    using System.Threading;
    
    /// <summary>
    /// Interaction logic for MainWindow
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            this.InitializeComponent();
            double screenHeight = SystemParameters.FullPrimaryScreenHeight;
            double screenWidth = SystemParameters.FullPrimaryScreenWidth;
            this.Top = screenHeight/100;
            this.Left = (screenWidth - this.Width); 

        }

        public void RefreshTable()
        {
            WrapP.Children.Clear();
            foreach (var item in NoteProxy.NotesPr)
            {
                NoteUserControl noteUC = new NoteUserControl(item, this);
                WrapP.Children.Add(noteUC);
            }
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            if (AddNote.Opacity == 0)
            {
                AddNote.Opacity = 1;
                LookCalendar.Opacity = 1;
                Exit.Opacity = 1;
            }
            else
            {

                AddNote.Opacity = 0;
                LookCalendar.Opacity = 0;
                Exit.Opacity = 0;

            }
        }

        private void AddNote_Click(object sender, RoutedEventArgs e)
        {
            NotePage np = new NotePage(this);
            np.Show();
            AddNote.Opacity = 0;
            LookCalendar.Opacity = 0;
            Exit.Opacity = 0;
        }

        private void LookCalendar_Click(object sender, RoutedEventArgs e)
        {
            DateRange DR = new DateRange(this);
            DR.ShowDialog();
            AddNote.Opacity = 0;
            LookCalendar.Opacity = 0;
            Exit.Opacity = 0;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application app = Application.Current;
            app.Shutdown(); 
        }

      

    }
}