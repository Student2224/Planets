using System;
using System.Collections.Generic;
using System.Text;

namespace HierarhyForms.Events
{
    public delegate void event_processor(GameEvent.GameEventArgs ev);
    ///all events are singltons(static) derived from GameEvent
    ///with class <SomeEventName >EventArgs derived from GameEvent.GameEventArgs
    ///see StartEvent
    public  abstract class GameEvent
    {
        static GameEvent evnt;
        static GameEvent Event()
        {
            return evnt;
        }
        public abstract class GameEventArgs
        {
            
        };

        public void Occur(GameEventArgs args)
        {
            foreach (var proc in processors)
            {
                proc(args);
            }
        }
        static List<event_processor> processors = new List<event_processor>();
        public void Add(event_processor processor)
        {
            throw new NotImplementedException();
        }
        public void Remove(event_processor processor)
        {
            throw new NotImplementedException();
        }
    }
}
