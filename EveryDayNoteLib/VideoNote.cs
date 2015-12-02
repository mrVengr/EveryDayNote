namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Video notes
    /// </summary>
    public class VideoNote : NotePart
    {
        public override void Create()
        {
            this.ID = Guid.NewGuid();
            NoteParts.Add(this);
        }

        public override void Encrypt()
        {
        }
    }
}
