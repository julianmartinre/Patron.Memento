using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    public class Memento
    {
        private string _state;

        public string State
        {
            get { return _state; }
        }

        public Memento() 
        { 
        }

        public Memento(string state)
        {
            _state = state;
        }
    }
}
