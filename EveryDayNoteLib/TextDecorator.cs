namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class TextDecorator : NotePart
    {
        private TextNote component;

        public TextNote Component
        {
            get
            {
                return component;
            }
            set
            {
                component = value;
            }
        }

        public void SetComponent(TextNote component)
        {
            this.component = component;
        }

        public override void Encrypt()
        {
            if (this.component != null)
            {
                this.component.Encrypt();
            }
        }
    }
}
