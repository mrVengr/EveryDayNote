namespace EveryDayNoteLib
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NoteComponent : NotePart
    {
        private ArrayList children = new ArrayList();

        public ArrayList Children
        {
            get
            {
                return this.children;
            }
        }

        public void Add(NotePart component)
        {
            this.children.Add(component);
        }

        public void Remove(NotePart component)
        {
            this.children.Remove(component);
        }

        public override void Create()
        { 
        }

        public override void SetData()
        {
        }

        public override void Encrypt()
        {
        }
    }
}
