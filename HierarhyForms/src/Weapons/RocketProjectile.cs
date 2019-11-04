using System;
using System.Collections.Generic;
using System.Text;
using HierarhyForms;

namespace Rocket
{
    class RocketProjectile : HierarhyForms.NPC
    {
        
        public RocketProjectile()
        {
            const int defaultHealth = 0;
            const double thrustPower = 0;
            const double rotationSpeed = 0;
            Init(DummyWeapon.CreateDummyWeapon(), defaultHealth, thrustPower, rotationSpeed);
        }
        public RocketProjectile(int health, double thrustPower, double rotationSpeed)
        {
            Init(DummyWeapon.CreateDummyWeapon(), health, thrustPower ,rotationSpeed);
        }
        public override void AI(List<HeavenBody> bodies)
        {
            base.AI(bodies);
            throw new NotImplementedException();
        }
    }
}
