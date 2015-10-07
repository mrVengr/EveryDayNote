using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDayNoteLib
{
    public abstract class NotePart
    {
        public static List<NotePart> NoteParts = new List<NotePart>();
        private Guid id;
        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }
        public abstract void Create();
    }
}
