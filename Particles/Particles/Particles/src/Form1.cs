using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Particles
{
    public partial class Form1 : Form
    {
        protected bool pause = false;
        double scale = 1;

        //List<Particle> level.particles = new List<Particle>();

        Level level = new Level(new List<Particle>());

        void Properties()
        {
            try
            {
                int n = int.Parse(N.Text);
                r.Text = $"{level.particles[n].radius}";
                sy.Text = $"{level.particles[n].speed.Y}";
                sx.Text = $"{level.particles[n].speed.X}";
                m.Text = $"{level.particles[n].mass}";
                koef.Text = $"{level.particles[n].k}";
                s.Text = $"{level.particles[n].speed.Length}";
                rs.Text = $"{level.particles[n].Rspeed.Length}";
                RsX.Text = $"{level.particles[n].Rspeed.X}";
                RsY.Text = $"{level.particles[n].Rspeed.Y}";
                t.Text = $"{level.particles[n].temperature}";  
            }
            catch (Exception)
            {
                r.Text = $"";
                sy.Text = $"";
                sx.Text = $"";
                m.Text = $"";
                koef.Text = $"";
                s.Text = $"";
                rs.Text = $"";
                RsX.Text = $"";
                RsY.Text = $"";
                t.Text = $"";
            }
        }

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer|
                ControlStyles.AllPaintingInWmPaint|
                ControlStyles.UserPaint,true);
            UpdateStyles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // const string path = "data/test1.lvl";
            List<Particle> new_particles = ParticlesFactory.Parse("");
            Program.Debug("load");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Properties();

            level.AplyForce();
            for (int i = 0; i < level.particles.Count; i++)
            {
                try
                {
                    e.Graphics.DrawEllipse(new Pen(Color.FromArgb(255, 100, 200, 255), 10), 
                        (int)(level.particles[i].position.X / scale), (int)(level.particles[i].position.Y / scale), 2, 2);
                }
                catch (Exception)
                {
                    level.particles.Remove(level.particles[i]);
                }           
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!pause)
                Refresh();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            try
            {
                level.particles.Add(
                             new Particle(new Vector(Cursor.Position.X * scale, Cursor.Position.Y * scale),
                             new Vector(Double.Parse(speedX.Text), Double.Parse(speedY.Text)),
                             Double.Parse(mass.Text), Double.Parse(radius.Text), 
                             Double.Parse(k.Text), Double.Parse(temperature.Text)));
                scale = Double.Parse(scale1.Text);
            }
            catch (Exception)
            {
                mass.Text = "10,0";
                speedX.Text = "0,0";
                speedY.Text = "0,0";
                k.Text = "0,001";
                radius.Text = "100,0";
                scale = Double.Parse("1,0");
            }
         
        }

        private void Clear_Click(object sender, EventArgs e)
        {
             CreateGraphics().Clear(Color.White);
            level.particles.Clear();
        }

        private void properties_Click(object sender, EventArgs e)
        {
    
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                pause = !pause;
            }
        }

    }
}
