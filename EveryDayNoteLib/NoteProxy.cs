namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Note Proxy
    /// </summary>
    public class NoteProxy : INote
    {
        private static List<NoteProxy> notesPr = new List<NoteProxy>();
        private bool isPicture = false;
        private bool isVideo = false;
        private bool isAudio = false;
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

        public bool IsVideo
        {
            get
            {
                return this.isVideo;
            }

            set
            {
                this.isVideo = value;
            }
        }

        public bool IsAudio
        {
            get
            {
                return this.isAudio;
            }

            set
            {
                this.isAudio = value;
            }
        }

        public bool IsPicture
        {
            get
            {
                return this.isPicture;
            }

            set
            {
                this.isPicture = value;
            }
        }
    }
}
