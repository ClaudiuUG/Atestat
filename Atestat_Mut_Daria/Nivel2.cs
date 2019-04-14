using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Mut_Daria
{
    public partial class Nivel2 : Form
    {
        bool goleft = false;
        bool goright = false;
        bool jumping = false;

        int jumpSpeed = 13;
        int force = 10;
        int score = 0;
        int secunde = 600;
        int move = 10;

        public Nivel2()
        {
            InitializeComponent();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nivel2_Load(object sender, EventArgs e)
        {

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goleft = false;
            if (e.KeyCode == Keys.Right)
                goright = false;
            if (jumping)
                jumping = false;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goleft = true;
            if (e.KeyCode == Keys.Right)
                goright = true;
            if (e.KeyCode == Keys.Space && !jumping)
                jumping = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secunde--;
            lbl_timp.Text = Convert.ToString(secunde);
            lbl_scor.Text = Convert.ToString(score);
            pct_caracter.Top += jumpSpeed;
            if (jumping && force < 0)
                jumping = false;
            if (goleft)
                pct_caracter.Left -= move;
            if (goright)
                pct_caracter.Left += move;
            if (jumping)
            {
                jumpSpeed = -10;
                force -= 2;
            }
            else
            {
                jumpSpeed = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "roca")
                {
                    if (pct_caracter.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        pct_caracter.Top = x.Top - pct_caracter.Height;
                    }
                }
                if (x is PictureBox && x.Tag == "bani")
                {
                    if (pct_caracter.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        this.Controls.Remove(x);
                        score += 1000;
                    }
                }
            }
            if (pct_usa.Bounds.IntersectsWith(pct_caracter.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Ați câștigat jocul!");
                MessageBox.Show("Ați câștigat jocul!");
                MessageBox.Show("Ați câștigat jocul!");
                MessageBox.Show("Ați câștigat jocul!");
                MessageBox.Show("Ați câștigat jocul!");
                MessageBox.Show("Ați câștigat jocul!");
            }

            if (secunde == 0)
            {
                timer1.Stop();
                MessageBox.Show("Ați pierdut!");
            }
        }
    }
}
