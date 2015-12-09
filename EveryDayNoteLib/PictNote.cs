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
    /// Class for pictures
    /// </summary>
    public class PictNote : NotePart
    {
        public PicturePartUC pictp;
        public Image imageSource;

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
            imageSource = pictp.Im;
        }

        public override UIElement RestoreData()
        {
            PicturePartUC PN = new PicturePartUC(imageSource);
            PN.InitializeComponent();
            PN.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            return PN;

        }
    }
}