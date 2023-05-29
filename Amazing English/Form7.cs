using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravochnik
{
    public partial class Form7 : Form
    {
        public static string connectString = "Provider=Microsoft.Ace.OLEDB.12.0;" + @"Data Source=|DataDirectory|\\dorova.accdb";
        OleDbConnection myConnection = new OleDbConnection(connectString);
        int i = 0;
        int j = 0;
        int t = 0;
        //string[] tip = new string[5];
        //string[] index = new string[5];
        //string[] yea = new string[5];

        String[] tip;
        String[] index;
        String[] yea;
        public Form7()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Spravochnik.Form5 f5 = new Spravochnik.Form5();
            f5.ShowDialog();
            Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            button3.Visible = false;
              if (q.vibor == 1)
              {
                  tip = new String[7];
                  index = new String[7];
                  yea = new String[7];
                    
                  myConnection.Open();
                  string sql = String.Concat("SELECT * FROM Tema1");
                  OleDbCommand command = new OleDbCommand(sql, myConnection);
                  OleDbDataReader dataReader = command.ExecuteReader();
                  int i = 0;
                  int j = 0;
                  int t = 0;
                  while (dataReader.Read())
                  {
                      index[i] = dataReader["Infa1"].ToString(); 
                      tip[j] = dataReader["Infa2"].ToString();
                      yea[t] = dataReader["Tema"].ToString();
                      //index[i] = dataReader.GetValue(2).ToString();
                      //tip[j] = dataReader.GetValue(3).ToString();
                      //yea[t] = dataReader.GetValue(1).ToString();
                      i++;
                      j++;
                      t++;
                  }
                  i = 0;
                  j = 0;
                  t = 0;
                  dataReader.Close();
                  myConnection.Close();
                  label2.Text = index[i];
                  label3.Text = tip[j];
                  label1.Text = yea[t];

              }
              if (q.vibor == 2)
              {
                //string[] tip = new string[3];
                //string[] index = new string[3];
                //string[] yea = new string[3];

                  tip = new String[5];
                  index = new String[5];
                  yea = new String[5];

                  myConnection.Open();
                  string sql = String.Concat("SELECT * FROM Tema2");
                  OleDbCommand command = new OleDbCommand(sql, myConnection);
                  OleDbDataReader dataReader = command.ExecuteReader();
                  int i = 0;
                  int j = 0;
                  int t = 0;
                  while (dataReader.Read())
                  {
                    index[i] = dataReader["Infa1"].ToString();
                    tip[j] = dataReader["Infa2"].ToString();
                    yea[t] = dataReader["Tema"].ToString();

                      j++;
                      i++;
                      t++;
                  }
                  j = 0;
                  i = 0;
                  t = 0;
                  dataReader.Close();
                  myConnection.Close();
                  label2.Text = index[i];
                  label3.Text = tip[j];
                  label1.Text = yea[t];
            }
            if (q.vibor == 3)
            {

                tip = new String[5];
                index = new String[5];
                yea = new String[5];

                myConnection.Open();
                string sql = String.Concat("SELECT * FROM Tema3");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                OleDbDataReader dataReader = command.ExecuteReader();
                int i = 0;
                int j = 0;
                int t = 0;
                while (dataReader.Read())
                {
                    index[i] = dataReader["Infa1"].ToString();
                    tip[j] = dataReader["Infa2"].ToString();
                    yea[t] = dataReader["Tema"].ToString();

                    j++;
                    i++;
                    t++;
                }
                j = 0;
                i = 0;
                t = 0;
                dataReader.Close();
                myConnection.Close();
                label2.Text = index[i];
                label3.Text = tip[j];
                label1.Text = yea[t];
            }
            if (q.vibor == 4)
            {

                tip = new String[3];
                index = new String[3];
                yea = new String[3];

                myConnection.Open();
                string sql = String.Concat("SELECT * FROM Tema4");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                OleDbDataReader dataReader = command.ExecuteReader();
                int i = 0;
                int j = 0;
                int t = 0;
                while (dataReader.Read())
                {
                    index[i] = dataReader["Infa1"].ToString();
                    tip[j] = dataReader["Infa2"].ToString();
                    yea[t] = dataReader["Tema"].ToString();

                    j++;
                    i++;
                    t++;
                }
                j = 0;
                i = 0;
                t = 0;
                dataReader.Close();
                myConnection.Close();
                label2.Text = index[i];
                label3.Text = tip[j];
                label1.Text = yea[t];
            }

            if (q.vibor == 5)
            {

                tip = new String[2];
                index = new String[2];
                yea = new String[2];

                myConnection.Open();
                string sql = String.Concat("SELECT * FROM Tema5");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                OleDbDataReader dataReader = command.ExecuteReader();
                int i = 0;
                int j = 0;
                int t = 0;
                while (dataReader.Read())
                {
                    index[i] = dataReader["Infa1"].ToString();
                    tip[j] = dataReader["Infa2"].ToString();
                    yea[t] = dataReader["Tema"].ToString();

                    j++;
                    i++;
                    t++;
                }
                j = 0;
                i = 0;
                t = 0;
                dataReader.Close();
                myConnection.Close();
                label2.Text = index[i];
                label3.Text = tip[j];
                label1.Text = yea[t];
            }

            if (q.vibor == 6)
            {

                tip = new String[3];
                index = new String[3];
                yea = new String[3];

                myConnection.Open();
                string sql = String.Concat("SELECT * FROM Tema6");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                OleDbDataReader dataReader = command.ExecuteReader();
                int i = 0;
                int j = 0;
                int t = 0;
                while (dataReader.Read())
                {
                    index[i] = dataReader["Infa1"].ToString();
                    tip[j] = dataReader["Infa2"].ToString();
                    yea[t] = dataReader["Tema"].ToString();

                    j++;
                    i++;
                    t++;
                }
                j = 0;
                i = 0;
                t = 0;
                dataReader.Close();
                myConnection.Close();
                label2.Text = index[i];
                label3.Text = tip[j];
                label1.Text = yea[t];
            }

            if (q.vibor == 7)
            {

                tip = new String[3];
                index = new String[3];
                yea = new String[3];

                myConnection.Open();
                string sql = String.Concat("SELECT * FROM Tema7");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                OleDbDataReader dataReader = command.ExecuteReader();
                int i = 0;
                int j = 0;
                int t = 0;
                while (dataReader.Read())
                {
                    index[i] = dataReader["Infa1"].ToString();
                    tip[j] = dataReader["Infa2"].ToString();
                    yea[t] = dataReader["Tema"].ToString();

                    j++;
                    i++;
                    t++;
                }
                j = 0;
                i = 0;
                t = 0;
                dataReader.Close();
                myConnection.Close();
                label2.Text = index[i];
                label3.Text = tip[j];
                label1.Text = yea[t];
            }

            if (q.vibor == 8)
            {

                tip = new String[3];
                index = new String[3];
                yea = new String[3];

                myConnection.Open();
                string sql = String.Concat("SELECT * FROM Tema8");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                OleDbDataReader dataReader = command.ExecuteReader();
                int i = 0;
                int j = 0;
                int t = 0;
                while (dataReader.Read())
                {
                    index[i] = dataReader["Infa1"].ToString();
                    tip[j] = dataReader["Infa2"].ToString();
                    yea[t] = dataReader["Tema"].ToString();

                    j++;
                    i++;
                    t++;
                }
                j = 0;
                i = 0;
                t = 0;
                dataReader.Close();
                myConnection.Close();
                label2.Text = index[i];
                label3.Text = tip[j];
                label1.Text = yea[t];
            }

            if (q.vibor == 9)
            {

                tip = new String[5];
                index = new String[5];
                yea = new String[5];

                myConnection.Open();
                string sql = String.Concat("SELECT * FROM Tema9");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                OleDbDataReader dataReader = command.ExecuteReader();
                int i = 0;
                int j = 0;
                int t = 0;
                while (dataReader.Read())
                {
                    index[i] = dataReader["Infa1"].ToString();
                    tip[j] = dataReader["Infa2"].ToString();
                    yea[t] = dataReader["Tema"].ToString();

                    j++;
                    i++;
                    t++;
                }
                j = 0;
                i = 0;
                t = 0;
                dataReader.Close();
                myConnection.Close();
                label2.Text = index[i];
                label3.Text = tip[j];
                label1.Text = yea[t];
            }

            if (q.vibor == 10)
            {

                tip = new String[5];
                index = new String[5];
                yea = new String[5];

                myConnection.Open();
                string sql = String.Concat("SELECT * FROM Tema10");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                OleDbDataReader dataReader = command.ExecuteReader();
                int i = 0;
                int j = 0;
                int t = 0;
                while (dataReader.Read())
                {
                    index[i] = dataReader["Infa1"].ToString();
                    tip[j] = dataReader["Infa2"].ToString();
                    yea[t] = dataReader["Tema"].ToString();

                    j++;
                    i++;
                    t++;
                }
                j = 0;
                i = 0;
                t = 0;
                dataReader.Close();
                myConnection.Close();
                label2.Text = index[i];
                label3.Text = tip[j];
                label1.Text = yea[t];
            }

            if (q.vibor == 11)
            {

                tip = new String[7];
                index = new String[7];
                yea = new String[7];

                myConnection.Open();
                string sql = String.Concat("SELECT * FROM Tema11");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                OleDbDataReader dataReader = command.ExecuteReader();
                int i = 0;
                int j = 0;
                int t = 0;
                while (dataReader.Read())
                {
                    index[i] = dataReader["Infa1"].ToString();
                    tip[j] = dataReader["Infa2"].ToString();
                    yea[t] = dataReader["Tema"].ToString();

                    j++;
                    i++;
                    t++;
                }
                j = 0;
                i = 0;
                t = 0;
                dataReader.Close();
                myConnection.Close();
                label2.Text = index[i];
                label3.Text = tip[j];
                label1.Text = yea[t];
            }

            if (q.vibor == 12)
            {

                tip = new String[6];
                index = new String[6];
                yea = new String[6];

                myConnection.Open();
                string sql = String.Concat("SELECT * FROM Tema12");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                OleDbDataReader dataReader = command.ExecuteReader();
                int i = 0;
                int j = 0;
                int t = 0;
                while (dataReader.Read())
                {
                    index[i] = dataReader["Infa1"].ToString();
                    tip[j] = dataReader["Infa2"].ToString();
                    yea[t] = dataReader["Tema"].ToString();

                    j++;
                    i++;
                    t++;
                }
                j = 0;
                i = 0;
                t = 0;
                dataReader.Close();
                myConnection.Close();
                label2.Text = index[i];
                label3.Text = tip[j];
                label1.Text = yea[t];
            }

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;

            i++;
            j++;
            t++;
            label2.Text = index[i];
            label3.Text = tip[j];
            label1.Text = yea[t];

            if (i == index.Length - 1)
            {
                button2.Visible = false;
                label4.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            i--;
            j--;
            t--;
            label2.Text = index[i];
            label3.Text = tip[j];
            label1.Text = yea[t];

            if (i == 0)
            {
                button3.Visible = false;
                label4.Visible = false;
            }
            if (i == index.Length - 2)
            {
                button2.Visible = true;
                label4.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите пройти тест по пройденной теме?", "Начало тестирования", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                if (q.vibor == 1)
                {
                    w.vibor = 1;
                    Hide();
                    Spravochnik.Form8 f8 = new Spravochnik.Form8();
                    f8.ShowDialog();
                    Close();
                }
                if (q.vibor == 2)
                {
                    w.vibor = 2;
                    Hide();
                    Spravochnik.Form8 f8 = new Spravochnik.Form8();
                    f8.ShowDialog();
                    Close();
                }
                if (q.vibor == 3)
                {
                    w.vibor = 3;
                    Hide();
                    Spravochnik.Form8 f8 = new Spravochnik.Form8();
                    f8.ShowDialog();
                    Close();
                }
                if (q.vibor == 4)
                {
                    w.vibor = 4;
                    Hide();
                    Spravochnik.Form8 f8 = new Spravochnik.Form8();
                    f8.ShowDialog();
                    Close();
                }
                if (q.vibor == 5)
                {
                    w.vibor = 5;
                    Hide();
                    Spravochnik.Form8 f8 = new Spravochnik.Form8();
                    f8.ShowDialog();
                    Close();
                }
                if (q.vibor == 6)
                {
                    w.vibor = 6;
                    Hide();
                    Spravochnik.Form8 f8 = new Spravochnik.Form8();
                    f8.ShowDialog();
                    Close();
                }
                if (q.vibor == 7)
                {
                    w.vibor = 7;
                    Hide();
                    Spravochnik.Form8 f8 = new Spravochnik.Form8();
                    f8.ShowDialog();
                    Close();
                }
                if (q.vibor == 8)
                {
                    w.vibor = 8;
                    Hide();
                    Spravochnik.Form8 f8 = new Spravochnik.Form8();
                    f8.ShowDialog();
                    Close();
                }
                if (q.vibor == 9)
                {
                    w.vibor = 9;
                    Hide();
                    Spravochnik.Form8 f8 = new Spravochnik.Form8();
                    f8.ShowDialog();
                    Close();
                }
                if (q.vibor == 10)
                {
                    w.vibor = 10;
                    Hide();
                    Spravochnik.Form8 f8 = new Spravochnik.Form8();
                    f8.ShowDialog();
                    Close();
                }
                if (q.vibor == 11)
                {
                    w.vibor = 11;
                    Hide();
                    Spravochnik.Form8 f8 = new Spravochnik.Form8();
                    f8.ShowDialog();
                    Close();
                }
                if (q.vibor == 8)
                {
                    w.vibor = 12;
                    Hide();
                    Spravochnik.Form8 f8 = new Spravochnik.Form8();
                    f8.ShowDialog();
                    Close();
                }
            }
        }
    }
}
