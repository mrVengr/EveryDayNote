using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDayNoteLib
{
    public class Note:INote
    {
        public List<NotePart> noteParts = new List<NotePart>();
        public void GetProxy()
        {
            NoteProxy proxy = new NoteProxy(this);
        }

    }
}
