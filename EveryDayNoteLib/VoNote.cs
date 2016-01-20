namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using UserControls;

    /// <summary>
    /// audio note
    /// </summary>
    public class VoNote : NotePart
    {
        public AudioPartUC ap = new AudioPartUC();
        MediaElement Audio;

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
        }

        public override UIElement RestoreData()
        {
            AudioPartUC AP = new AudioPartUC(Audio);
            AP.InitializeComponent();
            AP.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            return AP;

        }
    }
}