using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDayNoteLib
{
    public abstract class Prototype
    {
        public Prototype(string id)
        {
            this.Id = id;
        }

        public string Id { get; private set; }

        public virtual Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
