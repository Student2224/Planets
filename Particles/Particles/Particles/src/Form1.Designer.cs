namespace Particles
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mass = new System.Windows.Forms.TextBox();
            this.radius = new System.Windows.Forms.TextBox();
            this.speedX = new System.Windows.Forms.TextBox();
            this.speedY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.k = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sy = new System.Windows.Forms.Label();
            this.sx = new System.Windows.Forms.Label();
            this.koef = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.Label();
            this.RsY = new System.Windows.Forms.Label();
            this.RsX = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rs = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.scale1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DebugMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mass
            // 
            this.mass.Location = new System.Drawing.Point(80, 7);
            this.mass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(99, 22);
            this.mass.TabIndex = 0;
            this.mass.Text = "10,0";
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(80, 39);
            this.radius.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(99, 22);
            this.radius.TabIndex = 1;
            this.radius.Text = "100,0";
            // 
            // speedX
            // 
            this.speedX.Location = new System.Drawing.Point(80, 71);
            this.speedX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.speedX.Name = "speedX";
            this.speedX.Size = new System.Drawing.Size(99, 22);
            this.speedX.TabIndex = 2;
            this.speedX.Text = "0,0";
            // 
            // speedY
            // 
            this.speedY.Location = new System.Drawing.Point(80, 103);
            this.speedY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.speedY.Name = "speedY";
            this.speedY.Size = new System.Drawing.Size(99, 22);
            this.speedY.TabIndex = 3;
            this.speedY.Text = "0,0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "mass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "radius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "k";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "speedX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "speedY";
            // 
            // k
            // 
            this.k.Location = new System.Drawing.Point(80, 135);
            this.k.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(99, 22);
            this.k.TabIndex = 9;
            this.k.Text = "0,001";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(80, 199);
            this.Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 28);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(268, 7);
            this.N.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(51, 22);
            this.N.TabIndex = 12;
            this.N.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "speedY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "speedX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "k";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "radius";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "mass";
            // 
            // sy
            // 
            this.sy.AutoSize = true;
            this.sy.Location = new System.Drawing.Point(345, 225);
            this.sy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sy.Name = "sy";
            this.sy.Size = new System.Drawing.Size(22, 17);
            this.sy.TabIndex = 22;
            this.sy.Text = "sy";
            // 
            // sx
            // 
            this.sx.AutoSize = true;
            this.sx.Location = new System.Drawing.Point(345, 193);
            this.sx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sx.Name = "sx";
            this.sx.Size = new System.Drawing.Size(21, 17);
            this.sx.TabIndex = 21;
            this.sx.Text = "sx";
            // 
            // koef
            // 
            this.koef.AutoSize = true;
            this.koef.Location = new System.Drawing.Point(348, 112);
            this.koef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.koef.Name = "koef";
            this.koef.Size = new System.Drawing.Size(15, 17);
            this.koef.TabIndex = 20;
            this.koef.Text = "k";
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Location = new System.Drawing.Point(345, 80);
            this.r.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(13, 17);
            this.r.TabIndex = 19;
            this.r.Text = "r";
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Location = new System.Drawing.Point(345, 48);
            this.m.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(19, 17);
            this.m.TabIndex = 18;
            this.m.Text = "m";
            // 
            // RsY
            // 
            this.RsY.AutoSize = true;
            this.RsY.Location = new System.Drawing.Point(345, 343);
            this.RsY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RsY.Name = "RsY";
            this.RsY.Size = new System.Drawing.Size(34, 17);
            this.RsY.TabIndex = 26;
            this.RsY.Text = "RsY";
            // 
            // RsX
            // 
            this.RsX.AutoSize = true;
            this.RsX.Location = new System.Drawing.Point(345, 311);
            this.RsX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RsX.Name = "RsX";
            this.RsX.Size = new System.Drawing.Size(34, 17);
            this.RsX.TabIndex = 25;
            this.RsX.Text = "RsX";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(269, 343);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "RspeedY";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(269, 311);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "RspeedX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(269, 165);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "speed ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 279);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Rspeed ";
            // 
            // rs
            // 
            this.rs.AutoSize = true;
            this.rs.Location = new System.Drawing.Point(345, 279);
            this.rs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rs.Name = "rs";
            this.rs.Size = new System.Drawing.Size(20, 17);
            this.rs.TabIndex = 30;
            this.rs.Text = "rs";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(345, 165);
            this.s.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(15, 17);
            this.s.TabIndex = 29;
            this.s.Text = "s";
            // 
            // scale1
            // 
            this.scale1.Location = new System.Drawing.Point(80, 271);
            this.scale1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scale1.Name = "scale1";
            this.scale1.Size = new System.Drawing.Size(99, 22);
            this.scale1.TabIndex = 32;
            this.scale1.Text = "1,01";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 274);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "scale";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(345, 393);
            this.t.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(12, 17);
            this.t.TabIndex = 34;
            this.t.Text = "t";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(248, 393);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 17);
            this.label17.TabIndex = 33;
            this.label17.Text = "temperature";
            // 
            // temperature
            // 
            this.temperature.Location = new System.Drawing.Point(80, 167);
            this.temperature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(99, 22);
            this.temperature.TabIndex = 36;
            this.temperature.Text = "1,001";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 171);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "temp";
            // 
            // DebugMessage
            // 
            this.DebugMessage.AutoSize = true;
            this.DebugMessage.Location = new System.Drawing.Point(649, 393);
            this.DebugMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DebugMessage.Name = "DebugMessage";
            this.DebugMessage.Size = new System.Drawing.Size(0, 17);
            this.DebugMessage.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 554);
            this.Controls.Add(this.DebugMessage);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.t);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.scale1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rs);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RsY);
            this.Controls.Add(this.RsX);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.sy);
            this.Controls.Add(this.sx);
            this.Controls.Add(this.koef);
            this.Controls.Add(this.r);
            this.Controls.Add(this.m);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.N);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.k);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedY);
            this.Controls.Add(this.speedX);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.mass);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1051, 601);
            this.Name = "Form1";
            this.Text = "Particles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox mass;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.TextBox speedX;
        private System.Windows.Forms.TextBox speedY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox k;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label sy;
        private System.Windows.Forms.Label sx;
        private System.Windows.Forms.Label koef;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.Label RsY;
        private System.Windows.Forms.Label RsX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label rs;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.TextBox scale1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox temperature;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label DebugMessage;
    }
}

