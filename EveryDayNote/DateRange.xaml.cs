using EveryDayNoteLib;
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

namespace EveryDayNote
{
    /// <summary>
    /// Interaction logic for DateRange.xaml
    /// </summary>
    public partial class DateRange : Window
    {
        MainWindow MW;
        public DateRange(MainWindow mw)
        {
            MW = mw;
            InitializeComponent();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            
            DateTime? date = Date.SelectedDate;
            if (date == null)
            {
            }
            else
            {
                Notes.Children.Clear();
                foreach (var item in NoteProxy.NotesPr)
                {
                    if (item.DateNote == date.Value)
                    {
                        NoteUserControl noteUC = new NoteUserControl(item, MW);
                        Notes.Children.Add(noteUC);
                    }
                }
            }
        }
    }
}
