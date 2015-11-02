﻿namespace EveryDayNote
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
    /// Interaction logic for MainWindow
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NotePage np = new NotePage();
            np.Show();
        }

        private void RefreshB_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in NoteProxy.NotesPr)
            {
                NoteUserControl noteUC = new NoteUserControl();
                WrapP.Children.Add(noteUC);
            }
        }
    }
}