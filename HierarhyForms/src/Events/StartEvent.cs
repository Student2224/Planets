using System;
using System.Collections.Generic;
using System.Text;

namespace HierarhyForms.Events
{
    //example of GameEvent must be called after level start;
    class StartEvent : GameEvent
    {
        static public readonly GameEvent evnt = new StartEvent();
        public class StartEventArgs:GameEventArgs
        {
            TimeSpan time;

            public StartEventArgs()
            {
                this.time = new TimeSpan();
            }
        }
    }
}
