using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravochnik
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
            Spravochnik.Form4 f4 = new Spravochnik.Form4();
            f4.ShowDialog();
            Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            //label4.Text = File.ReadAllText(@"\base.txt");
            using (var sr = new StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\base.txt"))
            {
                var str = sr.ReadToEnd();
                label4.Text = str.ToString();
            }
        }
    }
}
