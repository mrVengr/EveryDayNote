namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for pictures
    /// </summary>
    public class PictNote : NotePart
    {
        public override void Create()
        {
            this.ID = Guid.NewGuid();
            NoteParts.Add(this);
        }
    }
}