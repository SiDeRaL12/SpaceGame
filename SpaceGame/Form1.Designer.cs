namespace SpaceGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Player = new PictureBox();
            bullet = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox20 = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox22 = new PictureBox();
            pictureBox23 = new PictureBox();
            pictureBox24 = new PictureBox();
            pictureBox25 = new PictureBox();
            pictureBox26 = new PictureBox();
            pictureBox27 = new PictureBox();
            pictureBox28 = new PictureBox();
            pictureBox29 = new PictureBox();
            rock1 = new PictureBox();
            rock2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rock1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rock2).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.Image = Properties.Resources.SpaceShip_resized_1;
            Player.Location = new Point(59, 142);
            Player.Name = "Player";
            Player.Size = new Size(60, 80);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // bullet
            // 
            bullet.Image = Properties.Resources.bullet;
            bullet.Location = new Point(125, 171);
            bullet.Name = "bullet";
            bullet.Size = new Size(35, 12);
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.TabIndex = 1;
            bullet.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.star;
            pictureBox1.Location = new Point(191, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 16);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "star";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.star;
            pictureBox2.Location = new Point(504, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "star";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.star;
            pictureBox3.Location = new Point(351, 142);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(15, 16);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "star";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.star;
            pictureBox4.Location = new Point(265, 298);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(15, 16);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "star";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.star;
            pictureBox5.Location = new Point(80, 354);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(15, 16);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "star";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.star;
            pictureBox6.Location = new Point(448, 226);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(15, 16);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "star";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.star;
            pictureBox7.Location = new Point(249, 194);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(15, 16);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "star";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.star;
            pictureBox8.Location = new Point(36, 43);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(15, 16);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 9;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "star";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.star;
            pictureBox9.Location = new Point(375, 362);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(15, 16);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 10;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "star";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.star;
            pictureBox10.Location = new Point(125, 253);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(15, 16);
            pictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox10.TabIndex = 11;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "star";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.star;
            pictureBox11.Location = new Point(416, 32);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(15, 16);
            pictureBox11.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox11.TabIndex = 12;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "star";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.star;
            pictureBox12.Location = new Point(125, 84);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(15, 16);
            pictureBox12.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox12.TabIndex = 13;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "star";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.star;
            pictureBox13.Location = new Point(570, 226);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(15, 16);
            pictureBox13.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox13.TabIndex = 14;
            pictureBox13.TabStop = false;
            pictureBox13.Tag = "star";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.star;
            pictureBox14.Location = new Point(656, 354);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(15, 16);
            pictureBox14.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox14.TabIndex = 15;
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "star";
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Properties.Resources.star;
            pictureBox15.Location = new Point(212, 379);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(15, 16);
            pictureBox15.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox15.TabIndex = 16;
            pictureBox15.TabStop = false;
            pictureBox15.Tag = "star";
            // 
            // pictureBox16
            // 
            pictureBox16.Image = Properties.Resources.star;
            pictureBox16.Location = new Point(626, 66);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(15, 16);
            pictureBox16.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox16.TabIndex = 17;
            pictureBox16.TabStop = false;
            pictureBox16.Tag = "star";
            // 
            // pictureBox17
            // 
            pictureBox17.Image = Properties.Resources.star;
            pictureBox17.Location = new Point(677, 130);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(15, 16);
            pictureBox17.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox17.TabIndex = 18;
            pictureBox17.TabStop = false;
            pictureBox17.Tag = "star";
            // 
            // pictureBox18
            // 
            pictureBox18.Image = Properties.Resources.star;
            pictureBox18.Location = new Point(512, 346);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(15, 16);
            pictureBox18.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox18.TabIndex = 19;
            pictureBox18.TabStop = false;
            pictureBox18.Tag = "star";
            // 
            // pictureBox19
            // 
            pictureBox19.Image = Properties.Resources.star;
            pictureBox19.Location = new Point(677, 253);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(15, 16);
            pictureBox19.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox19.TabIndex = 20;
            pictureBox19.TabStop = false;
            pictureBox19.Tag = "star";
            // 
            // pictureBox20
            // 
            pictureBox20.Image = Properties.Resources.star;
            pictureBox20.Location = new Point(590, 406);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(15, 16);
            pictureBox20.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox20.TabIndex = 21;
            pictureBox20.TabStop = false;
            pictureBox20.Tag = "star";
            // 
            // pictureBox21
            // 
            pictureBox21.Image = Properties.Resources.star;
            pictureBox21.Location = new Point(538, 66);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(15, 16);
            pictureBox21.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox21.TabIndex = 22;
            pictureBox21.TabStop = false;
            pictureBox21.Tag = "star";
            // 
            // pictureBox22
            // 
            pictureBox22.Image = Properties.Resources.star;
            pictureBox22.Location = new Point(324, 43);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(15, 16);
            pictureBox22.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox22.TabIndex = 23;
            pictureBox22.TabStop = false;
            pictureBox22.Tag = "star";
            // 
            // pictureBox23
            // 
            pictureBox23.Image = Properties.Resources.star;
            pictureBox23.Location = new Point(401, 286);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(15, 16);
            pictureBox23.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox23.TabIndex = 24;
            pictureBox23.TabStop = false;
            pictureBox23.Tag = "star";
            // 
            // pictureBox24
            // 
            pictureBox24.Image = Properties.Resources.star;
            pictureBox24.Location = new Point(427, 130);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(15, 16);
            pictureBox24.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox24.TabIndex = 25;
            pictureBox24.TabStop = false;
            pictureBox24.Tag = "star";
            // 
            // pictureBox25
            // 
            pictureBox25.Image = Properties.Resources.star;
            pictureBox25.Location = new Point(475, 395);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(15, 16);
            pictureBox25.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox25.TabIndex = 26;
            pictureBox25.TabStop = false;
            pictureBox25.Tag = "star";
            // 
            // pictureBox26
            // 
            pictureBox26.Image = Properties.Resources.star;
            pictureBox26.Location = new Point(726, 43);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(15, 16);
            pictureBox26.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox26.TabIndex = 27;
            pictureBox26.TabStop = false;
            pictureBox26.Tag = "star";
            // 
            // pictureBox27
            // 
            pictureBox27.Image = Properties.Resources.star;
            pictureBox27.Location = new Point(726, 395);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(15, 16);
            pictureBox27.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox27.TabIndex = 28;
            pictureBox27.TabStop = false;
            pictureBox27.Tag = "star";
            // 
            // pictureBox28
            // 
            pictureBox28.Image = Properties.Resources.star;
            pictureBox28.Location = new Point(342, 226);
            pictureBox28.Name = "pictureBox28";
            pictureBox28.Size = new Size(15, 16);
            pictureBox28.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox28.TabIndex = 29;
            pictureBox28.TabStop = false;
            pictureBox28.Tag = "star";
            // 
            // pictureBox29
            // 
            pictureBox29.Image = Properties.Resources.star;
            pictureBox29.Location = new Point(278, 111);
            pictureBox29.Name = "pictureBox29";
            pictureBox29.Size = new Size(15, 16);
            pictureBox29.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox29.TabIndex = 30;
            pictureBox29.TabStop = false;
            pictureBox29.Tag = "star";
            // 
            // rock1
            // 
            rock1.Image = Properties.Resources.image_7;
            rock1.Location = new Point(427, 54);
            rock1.Name = "rock1";
            rock1.Size = new Size(90, 63);
            rock1.SizeMode = PictureBoxSizeMode.AutoSize;
            rock1.TabIndex = 31;
            rock1.TabStop = false;
            // 
            // rock2
            // 
            rock2.Image = Properties.Resources.image_8;
            rock2.Location = new Point(309, 362);
            rock2.Name = "rock2";
            rock2.Size = new Size(60, 63);
            rock2.SizeMode = PictureBoxSizeMode.AutoSize;
            rock2.TabIndex = 32;
            rock2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(782, 453);
            Controls.Add(rock2);
            Controls.Add(rock1);
            Controls.Add(Player);
            Controls.Add(pictureBox29);
            Controls.Add(pictureBox28);
            Controls.Add(pictureBox27);
            Controls.Add(pictureBox26);
            Controls.Add(pictureBox25);
            Controls.Add(pictureBox24);
            Controls.Add(pictureBox23);
            Controls.Add(pictureBox22);
            Controls.Add(pictureBox21);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox19);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(bullet);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).EndInit();
            ((System.ComponentModel.ISupportInitialize)rock1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rock2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Player;
        private PictureBox bullet;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox29;
        private PictureBox rock1;
        private PictureBox rock2;
    }
}
