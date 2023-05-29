using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravochnik
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dorova.accdb");
            con.Open();
           
            string queryString = "INSERT INTO polzov ( Familiya, Imya, Otchestvo) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
          
            OleDbCommand command1 = new OleDbCommand(queryString, con);
            command1.ExecuteNonQuery();
            //обновляет в таблице значения..
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter("SELECT * FROM polzov", con);
            DataSet dt = new DataSet();
            DataAdapter.Fill(dt);

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Проверьте правильность введенных данных!");

                Hide();
                Spravochnik.Form3 f3 = new Spravochnik.Form3();
                f3.ShowDialog();
                Close();
            }
            else
            MessageBox.Show("Вы успешно авторизовались!");

            Hide();
            Spravochnik.Form4 f4 = new Spravochnik.Form4();
            f4.ShowDialog();
            Close();


            //StreamWriter file = new StreamWriter("base.txt", true);
            //file.WriteLine(textBox2.Text);
            //file.WriteLine(textBox3.Text);
            //file.Close();

            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
