

namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TextNote : NotePart
    {

        public override void Create()
        {
            this.ID = Guid.NewGuid();
            NoteParts.Add(this);
        }


    }
}
