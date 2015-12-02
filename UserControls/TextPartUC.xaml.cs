namespace UserControls
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

    /// <summary>
    /// Interaction logic for TextPartUC.xaml
    /// </summary>
    public partial class TextPartUC : UserControl
    {
        public TextPartUC()
        {
            //this.InitializeComponent();
        }

        public string Text;

        private void TextData_TextChanged(object sender, TextChangedEventArgs e)
        {
            Text = TextData.Document.ToString();
        }
    }
}
