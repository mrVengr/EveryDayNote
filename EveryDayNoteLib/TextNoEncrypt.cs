namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;

    public class TextNoEncrypt : TextDecorator
    {
        public override void Create()
        {
        }

        public override void Encrypt()
        {
            base.Component.Text = base.Component.tp.Text.ToString();
        }

        public override void SetData()
        {
        }

        public override UIElement RestoreData()
        {
            return null;
        }
    }
}
