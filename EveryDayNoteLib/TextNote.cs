namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Xaml;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using UserControls;

    /// <summary>
    /// Text notes
    /// </summary>
    public class TextNote : NotePart
    {
        public TextPartUC tp;

        public string Text;

        public override void Create()
        {
            this.ID = Guid.NewGuid();
            NoteParts.Add(this);
        }

        public override void Encrypt()
        {
        }
    }
}