using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDayNoteLib
{
    public class VoNote : Prototype
    {
        public override void Create()
        {
            s = "Audio";
        }

        public VoNote(string id)
            : base(id)
        {
        }

    }
}
