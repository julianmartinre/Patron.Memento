using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    public class Document
    {
        public string name { get; set; }
        public string content { get; set; }

        public Memento SaveMemento()
        {
            return new Memento(content);
        }

        public string restoreMemento(Memento m)
        {
            content = m.State;
            return content;
        }
    }
}
