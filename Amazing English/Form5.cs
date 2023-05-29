using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravochnik
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Spravochnik.Form4 f4 = new Spravochnik.Form4();
            f4.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            q.vibor = 1;
            Hide();
            Spravochnik.Form7 f7 = new Spravochnik.Form7();
            f7.ShowDialog();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            q.vibor = 2;
            Hide();
            Spravochnik.Form7 f7 = new Spravochnik.Form7();
            f7.ShowDialog();
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            q.vibor = 3;
            Hide();
            Spravochnik.Form7 f7 = new Spravochnik.Form7();
            f7.ShowDialog();
            Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            q.vibor = 4;
            Hide();
            Spravochnik.Form7 f7 = new Spravochnik.Form7();
            f7.ShowDialog();
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            q.vibor = 5;
            Hide();
            Spravochnik.Form7 f7 = new Spravochnik.Form7();
            f7.ShowDialog();
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            q.vibor = 6;
            Hide();
            Spravochnik.Form7 f7 = new Spravochnik.Form7();
            f7.ShowDialog();
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            q.vibor = 7;
            Hide();
            Spravochnik.Form7 f7 = new Spravochnik.Form7();
            f7.ShowDialog();
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            q.vibor = 8;
            Hide();
            Spravochnik.Form7 f7 = new Spravochnik.Form7();
            f7.ShowDialog();
            Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            q.vibor = 9;
            Hide();
            Spravochnik.Form7 f7 = new Spravochnik.Form7();
            f7.ShowDialog();
            Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            q.vibor = 10;
            Hide();
            Spravochnik.Form7 f7 = new Spravochnik.Form7();
            f7.ShowDialog();
            Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            q.vibor = 11;
            Hide();
            Spravochnik.Form7 f7 = new Spravochnik.Form7();
            f7.ShowDialog();
            Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            q.vibor = 12;
            Hide();
            Spravochnik.Form7 f7 = new Spravochnik.Form7();
            f7.ShowDialog();
            Close();
        }
    }
}
