using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket
{
    
    class DummyWeapon : Weapon
    {
        static DummyWeapon dummyWeapon = new DummyWeapon(); //singleton

        private DummyWeapon()
        {

        }
        public static DummyWeapon  CreateDummyWeapon()
        {
            return dummyWeapon;
        }
        override public void Fire()
        {
            //Do nothing maybe write to log
        }
    }
}
