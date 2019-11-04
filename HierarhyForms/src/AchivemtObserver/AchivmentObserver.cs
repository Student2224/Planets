using System;
using System.Collections.Generic;
using System.Text;
using HierarhyForms.Events;

namespace HierarhyForms.AchivemtObserver
{
 
    //<SomeName>Observer must be derived from AchivementObserver
    abstract public class AchivmentObserver
    {
        public string name;
        GameEvent evnt;

        public AchivmentObserver()
        {
            //using only for children
        }

        protected void Init(string name, GameEvent evnt, event_processor processor)
        {
            this.name = name;
            this.evnt = evnt;
            this.evnt.Add(processor);
        }
        public AchivmentObserver(string name, GameEvent evnt, event_processor processor)
        {
            Init(name, evnt, processor);            
        }

        override abstract  public string ToString();

    }
}
