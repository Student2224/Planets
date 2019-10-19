using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

//using System.Text.Json;
using Newtonsoft.Json;


namespace Particles
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static Form1 window;
        static public void Debug(string msg)
        {
            window.DebugMessage.Text = msg;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SpringParticle p1, p2, p3;
            p1 = new SpringParticle(new Vector(600, 300), new Vector(0.1, 0), 10000000, 100, 1, 1, new List<Particle>());
            p2 = new SpringParticle(new Vector(600, 400), new Vector(0, 0), 10000000, 100, 1, 1, new List<Particle>());
            p3 = new SpringParticle(new Vector(700, 400), new Vector(0, 0), 10000000, 100, 1, 1, new List<Particle>());

            p1.AddSpring(p2);
            p2.AddSpring(p3);

            List<Particle> particles = new List<Particle>();
            particles.Add(p1);
            particles.Add(p2);
            particles.Add(p3);

            Level level = new Level(particles);

            //  string str = JsonConvert.SerializeObject(level);
            window = new Form1(level);

            //window.level = level;
            Application.Run(window);
        }
    }
}
