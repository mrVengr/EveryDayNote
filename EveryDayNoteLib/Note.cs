namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Note Interface
    /// </summary>
    public class Note : INote
    {
        private NoteComponent component;

        public NoteComponent NoteComponent
        {
            get
            {
                return this.component;
            }

            set
            {
                this.component = value;
            }
        }

        private DateTime dateNote;

        public DateTime DateNote
        {
            get { return dateNote; }
            set { dateNote = value; }
        }
        

        public void GetProxy()
        {
            NoteProxy proxy = new NoteProxy(this);
        }
    }
}