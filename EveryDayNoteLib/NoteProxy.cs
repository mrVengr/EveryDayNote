namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NoteProxy : INote
    {
        public bool IsVideo = false;
        public bool IsAudio = false;
        public bool IsPicture = false;
        private static List<NoteProxy> notesPr = new List<NoteProxy>();
        private Note note;
        public NoteProxy(Note note_)
        {
            NotesPr.Add(this);
            this.note = note_;
            foreach (var item in this.note.NoteParts)
            {

                switch (item.GetType().FullName)
                {
                    case "EveryDayNoteLib.PictNote":
                        this.IsPicture = true;
                        break;
                    case "EveryDayNoteLib.VideoNote":
                        this.IsVideo = true;
                        break;
                    case "EveryDayNoteLib.VoNote":
                        this.IsAudio = true;
                        break;
                }
            }
        }

        public static List<NoteProxy> NotesPr
        {
            get
            {
                return notesPr;
            }
            set
            {
                notesPr = value;
            }
        }

    }
}
