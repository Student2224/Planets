using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Particles
{
    [Serializable]
    class SpringParticle : Particle
    {
        List<Particle> springs;
        static double spring_length = 100;

        void Init(Vector pos, Vector s, //FIXUP
               double m, double r, double koef, double t, move_delegate move, List<Particle> _springs)
        {
            Init(pos, s, m, r, koef, t, SpringMove);
            springs = _springs;
        }

        public SpringParticle(Vector pos, Vector s,
               double m, double r, double koef, double t, List<Particle> _springs)
        {
            Init(pos, s, m, r, koef, t, SpringMove, _springs);
        }
        public SpringParticle()
        {

            Init(new Vector(0, 0), new Vector(0, 0), 10, 100, 1, 1, SpringMove, new List<Particle>());
        }

        public void AddSpring(SpringParticle particle)
        {
            springs.Add(particle);
            particle.springs.Add(this);
        }

        public void SpringMove(List<Particle> particles)
        {
            {
                Vector F = new Vector(0,0);
                foreach (var item in particles)
                {
                    double distance = (position - item.position).Length;
                    if (distance < eps)
                        continue;
                    F = (item.position - position);
                    F *= G * Math.Pow(distance, -2) * item.mass / mass;//Гравитация

                    double r = (position - item.position).Length;

                    if (distance < radius)
                    {
                        //Отталкивание
                        F = -F * 4 * temperature;
                    }
                }

                foreach (var spring in springs)
                {
                    Vector direction = spring.position - position;
                    double spring_len = direction.Length;

                    Vector deltaSpring = -direction * (spring_length - spring_len);
                    F += deltaSpring;

                }

                speed += F / mass;
            }
        }
    }
}
