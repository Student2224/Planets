using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket
{
    class RocketWeapon: Weapon
    {
        public RocketWeapon(int ammoCount, TimeSpan cooldown)
        {
            Init(new RocketProjectile(), ammoCount, cooldown);
        }
    }
}
