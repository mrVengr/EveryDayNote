namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Context for strategy
    /// </summary>
    public class Context
    {
        private NotePart notice;

        public Context(NotePart notice_)
        {
            this.notice = notice_;
        }

        public void SetStrategy(NotePart notice_)
        {
            this.notice = notice_;
        }

        public void ExecuteOperation(Note note_)
        {
            this.notice.Create();
            note_.NoteParts.Add(this.notice);
        }
    }
}
