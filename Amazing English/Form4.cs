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
    public partial class Form4 : Form
    {
        //StreamReader schitivayu;
        public Form4()
        {
            //OleDbConnection con;
            //DataSet ds;

            InitializeComponent();

            //con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dorova.accdb");
            //OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM polzov", con);
            //ds = new DataSet();
            //dataAdapter.Fill(ds);
            ////label9.Text = ds.Tables[0].Rows[0].Field<string>("Imya").ToString() + " " +  ds.Tables[0].Rows[0].Field<string>("Otchestvo").ToString();
            //label9.Text = ds.Tables[0].Rows[0].Field<string>("Imya").ToString() + " " + ds.Tables[0].Rows[0].Field<string>("Otchestvo").ToString();
            ////ItemArray[0]
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();
            Spravochnik.Form5 f5 = new Spravochnik.Form5();
            f5.ShowDialog();
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //StreamWriter file = new StreamWriter("base.txt", true);
            //file.WriteLine(label9.Text);
            //file.Close();

            Hide();
            Spravochnik.Form6 f6 = new Spravochnik.Form6();
            f6.ShowDialog();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите вернуться на форму ввода данных?\n"+ "При этом вы выйдите из своей учетной записи!", "Выход из учетной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Hide();
                Spravochnik.Form2 f2 = new Spravochnik.Form2();
                f2.ShowDialog();
                Close();
            }
            //MessageBox.Show("Вы действительно хотите вернуть на начальную страницу? \nПри этом придётся заново авторизоваться!");

            //Hide();
            //Spravochnik.Form2 f2 = new Spravochnik.Form2();
            //f2.ShowDialog();
            //Close();
            //Spravochnik.Form10 f10 = new Spravochnik.Form10();
            //f10.ShowDialog();
            //Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label8.Visible = false;
            OleDbConnection con;
            DataSet ds;

            //InitializeComponent();

            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dorova.accdb");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM polzov", con);
            ds = new DataSet();
            dataAdapter.Fill(ds);
            //label9.Text = ds.Tables[0].Rows[0].Field<string>("Imya").ToString() + " " +  ds.Tables[0].Rows[0].Field<string>("Otchestvo").ToString();
            label9.Text = ds.Tables[0].Rows[0].Field<string>("Imya").ToString() + " " + ds.Tables[0].Rows[0].Field<string>("Otchestvo").ToString();
            //ItemArray[0]
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\CHMEditor.chm");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Подтвердите права доступа!");
            Hide();
            Spravochnik.Form9 f9 = new Spravochnik.Form9();
            f9.ShowDialog();
            Close();
        }
    }
}
