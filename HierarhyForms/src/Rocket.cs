using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket
{
    public class Rocket : HierarhyForms.HeavenBody
    {
        double rotationSpeed;
        double thrustPower;
        protected Weapon weapon;
        protected int health; //?
        protected void Init(Weapon weapon, int health, double thrustPower, double rotationSpeed)
        {
            this.weapon = weapon;
            this.health = health;
            this.thrustPower = thrustPower;
            this.rotationSpeed = rotationSpeed;
        }
        
    }
}
