using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDayNoteLib
{
    public class VoNote : NotePart
    {
        public override void Create()
        {
            ID = Guid.NewGuid();
            NoteParts.Add(this);
        }

    }
}
