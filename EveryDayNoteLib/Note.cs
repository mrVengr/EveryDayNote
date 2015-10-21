namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Note : INote
    {
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
        public void GetProxy()
        {
            NoteProxy proxy = new NoteProxy(this);
        }

    }
}
