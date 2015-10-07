using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDayNoteLib
{
    public class Context
    {
        private NotePart notice;

        public Context(NotePart _notice)
        {
            notice = _notice;
        }

        public void SetStrategy(NotePart _notice)
        {

            notice = _notice;
        }


        public void ExecuteOperation(Note _note)
        {
            notice.Create();
            _note.noteParts.Add(notice);
        }
    }
}
