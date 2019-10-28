using System;
using System.Collections.Generic;
using System.Text;
using HierarhyForms;


namespace Rocket
{
    class Weapon
    {
        protected HeavenBody projectile;
        int ammoCount;
        TimeSpan cooldown;

        override public  void Fire()
        {
            throw new Exception("NI");
        }
    }
}
