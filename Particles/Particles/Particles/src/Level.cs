using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particles
{
    [Serializable]
    class Level
    {
        public List<Particle> particles;

        public Level(List<Particle> parts)  
        {
            particles = parts;
        }
        public void AplyForce()
        {
            foreach (var particle in particles)
            {
                particle.MoveProcessor(particles);
                particle.Change_position();
            }

        }
    }
}
