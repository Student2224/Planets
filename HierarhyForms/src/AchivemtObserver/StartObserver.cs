using System;
using System.Collections.Generic;
using System.Text;
using HierarhyForms.Events;

namespace HierarhyForms.AchivemtObserver
{
    public class StartObserver:AchivmentObserver
    {
        public bool isChecked = false;
        
        public StartObserver()
        {
            Init("start", StartEvent.evnt, (GameEvent.GameEventArgs args) => { isChecked = true; });
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
