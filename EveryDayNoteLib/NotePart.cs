namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Note parts
    /// </summary>
    public abstract class NotePart
    {
        private Guid id;
        private List<NotePart> noteParts = new List<NotePart>();

        public List<NotePart> NoteParts
        {
            get
            {
                return this.noteParts;
            }

            set
            {
                this.noteParts = value;
            }
        }

        public Guid ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public abstract void SetData();

        public abstract void Create();

        public abstract void Encrypt();

        public void Save()
        {
            SetData();
            Encrypt();
        }

    }
}
