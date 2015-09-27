using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDayNoteLib
{
    public interface Notice:Prototype
    {
        public Notice(string id) : base(id)
    {
    }
        void Create();
    }
}
