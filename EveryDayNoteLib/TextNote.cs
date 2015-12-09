namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Xaml;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using UserControls;
    using System.Windows;

    /// <summary>
    /// Text notes
    /// </summary>
    public class TextNote : NotePart
    {
        public TextPartUC tp = new TextPartUC();

        public string Text;

        public override void Create()
        {
            this.ID = Guid.NewGuid();
            NoteParts.Add(this);
        }

        public override void Encrypt()
        {
        }

        public override void SetData()
        {
            if (tp.Text != null)
            {
                Text = tp.Text.ToString();
            }
            else
                Text = "";
        }

        public override UIElement RestoreData()
        {
            TextPartUC tP = new TextPartUC(Text);
            tP.InitializeComponent();
            tP.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            return tP;

        }
    }
}