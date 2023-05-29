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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            Spravochnik.Form4 f4 = new Spravochnik.Form4();
            f4.ShowDialog();
            Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Hide();
                Spravochnik.Form10 f10 = new Spravochnik.Form10();
                f10.ShowDialog();
                Close();
            }

            else MessageBox.Show("Проверьте правильность введенных данных!");

            label5.Focus();
        }
    }
}
