﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDayNoteLib
{
    public class TextNote : Prototype
    {
        public override void Create()
        {
            s = "Text";
        }

        public TextNote(string id)
            : base(id)
        {
        }
    }
}
