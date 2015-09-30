using System;
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
            s = "222";
        }
        public static string s="";
        public TextNote(string id)
            : base(id)
        {
        }
    }
}
