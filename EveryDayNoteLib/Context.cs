using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDayNoteLib
{
    public class Context
    {
        private Notice notice;

        public Context(Notice _notice)
        {
            notice = _notice;
        }

        public void SetStrategy(Notice _notice)
        {
            notice = _notice;
        }


        public void ExecuteOperation()
        {
            notice.Create();
        }
    }
}
