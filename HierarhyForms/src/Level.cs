using System;
using System.Collections.Generic;
using System.Text;
using HierarhyForms.Events;

namespace HierarhyForms
{
    public static class Level
    {
        static List<HeavenBody> heavenBodies;
        static List<NPC> npcs;
        static Player player;
        static List<GameEvent> events;//?

        static public void Init()
        {
            StartEvent.evnt.Occur(new StartEvent.StartEventArgs());
            heavenBodies = new List<HeavenBody>();
            npcs = new List<NPC>();
            player = new Player();
        }
        static public void AddBody(HeavenBody body)
        {
            heavenBodies.Add(body);
        }

        static public void AddNPC(NPC npc)
        {
            npcs.Add(npc);
        }
    }
}
