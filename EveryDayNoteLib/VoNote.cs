﻿namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// audio note
    /// </summary>
    public class VoNote : NotePart
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