using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDayNoteLib
{
    public class NoteProxy:INote
    {
        private Note note;
        public static List<NoteProxy> notesPr = new List<NoteProxy>();
        public bool isVideo = false;
        public bool isAudio = false;
        public bool isPicture = false;

        public NoteProxy(Note _note)
        {
            notesPr.Add(this);
            note = _note;
            foreach (var item in note.noteParts)
            {

                switch (item.GetType().FullName)
                {
                    case "EveryDayNoteLib.PictNote":
                        isPicture = true;
                        break;
                    case "EveryDayNoteLib.VideoNote":
                        isVideo = true;
                        break;
                    case "EveryDayNoteLib.VoNote":
                        isAudio = true;
                        break;
                }
            }
        }

    }
}
