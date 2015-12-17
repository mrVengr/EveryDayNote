namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
using System.Windows.Media;

    /// <summary>
    /// Note Proxy
    /// </summary>
    public class NoteProxy : INote
    {
        private static List<NoteProxy> notesPr = new List<NoteProxy>();
        private bool isPicture = false;
        private bool isVideo = false;
        private bool isAudio = false;
        public Note Currentnote;
        private SolidColorBrush scb;
        private SolidColorBrush borderColor;
        private DateTime dateNote;

        public DateTime DateNote
        {
            get { return dateNote; }
            set { dateNote = value; }
        }
        

        public NoteProxy(Note note_)
        {
            DateNote = note_.DateNote;
            Random Rnd = new Random();
            byte R = (byte)(Rnd.Next(2, 7) * 20);
            byte B = (byte)(Rnd.Next(2, 7) * 20);
            byte G = (byte)(Rnd.Next(8, 12) * 20);
            SolidColorBrush SCB = new SolidColorBrush();
            SCB.Color = Color.FromArgb(255, R, G, B);
            Scb = SCB;
            SolidColorBrush SCBBorder = new SolidColorBrush();
            SCBBorder.Color = Color.FromArgb(255, (byte)(R - 20), (byte)(G - 20), (byte)(B - 20));
            BorderColor = SCBBorder;
            NotesPr.Add(this);
            this.Currentnote = note_;
            if (this.Currentnote.NoteComponent.Children != null)
            {
                foreach (var item in this.Currentnote.NoteComponent.Children)
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

        public SolidColorBrush Scb
        {
            get
            {
                return this.scb;
            }
            set
            {
                this.scb = value;
            }
        }

        public SolidColorBrush BorderColor
        {
            get
            {
                return this.borderColor;
            }
            set
            {
                this.borderColor = value;
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
