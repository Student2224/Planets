using System;
using System.Collections.Generic;
using System.Text;
using HierarhyForms;


namespace Rocket
{
    public class Weapon
    {
        protected HeavenBody projectile;
        int ammoCount;
        TimeSpan cooldown;

        protected void Init(HeavenBody projectile, int ammoCount, TimeSpan cooldown)
        {
            this.projectile = projectile;
            this.ammoCount = ammoCount;
            this.cooldown = cooldown;
        }
        protected Weapon()
        {
            //this function exists for DummyWeapon so must not be called except you dont init it somehow.
            throw new Exception("Weapon should not call default constructor");
        }

        public Weapon(HeavenBody projectile, int ammoCount, TimeSpan cooldown)
        {
            this.projectile = projectile;
            this.ammoCount = ammoCount;
            this.cooldown = cooldown;
        }

        virtual public  void Fire()
        {
            //TODO Init projectile end add to Level
            throw new NotImplementedException();
        }
    }
}
