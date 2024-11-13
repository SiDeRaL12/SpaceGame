namespace SpaceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Bullet()
        {
            bullet.Left += 100;
            if (bullet.Left > 600)
            {
                bullet.Image = Properties.Resources.bullet;
                bullet.Left = Player.Left;
                bullet.Top = Player.Top + 35;
            }
        }

        void Stars()
        {
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && x.Tag == "star")
                {
                    x.Left -= 5;
                    if (x.Left < 0)
                    {
                        x.Left = 800;
                    }
                }
            }

        }
        void Rocks()
        {
            Random rnd = new Random();
            int x, y;
            rock1.Left -= 2;
            if (rock1.Left < 0)
            {
                x = rnd.Next(0, 400);
                rock1.Location = new Point(800, x);
            }
            rock2.Left -= 2;
            if (rock1.Left < 0)
            {
                y = rnd.Next(0, 500);
                rock2.Location = new Point(800, y);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (Player.Top > 20)
                {
                    Player.Top -= 5; // Move up by reducing the 'Top' value
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (Player.Top < 350)
                {
                    Player.Top += 5; // Move down by increasing the 'Top' value
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bullet();
            Stars();
            Rocks();
        }


    }
}
