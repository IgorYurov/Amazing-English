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
using Word = Microsoft.Office.Interop.Word;

namespace Spravochnik
{
    public partial class Form8 : Form
    {

        string[] question = new string[50];
        string[] answer1 = new string[50];
        string[] answer2 = new string[50];
        string[] answer3 = new string[50];
        string[] answer4 = new string[50];
        string[] zad = new string[50];
        string[] tem = new string[50];
        string[] rights = new string[50];

        string[] verno = new string[50];


        int count = 0;
        int otv = 0;

        //string a;
        //string b;
        //string c;
        //string d;

        //int danie = 0;//zad
        //int zadai = 0;//question
        //int var1 = 0; //answer1 
        //int var2 = 0; //answer2 
        //int var3 = 0; //answer3 
        //int var4 = 0; //answer4
        //int temka = 0; //tema

        public static string connectString = "Provider=Microsoft.Ace.OLEDB.12.0;" + @"Data Source=|DataDirectory|\\dorova.accdb";
        static OleDbConnection myConnection = new OleDbConnection(connectString);

        public Form8()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите вернуться к выбору теста?", "Завершение теста", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Hide();
                Spravochnik.Form6 f6 = new Spravochnik.Form6();
                f6.ShowDialog();
                Close();
            }
            //Application.Exit();
            /* MessageBox.Show("Вы уверены, что хотите завершить тест не закончив его? \nВесь прогресс будет утерян!");
             DialogResult game_over = MessageBox.Show("Вы уверены, что хотите завершить тест не закончив его? \nВесь прогресс будет утерян!", "Аккуратненько!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

             if (MessageBoxButtons == Yes)
             {
                 Hide();
                Spravochnik.Form6 f6 = new Spravochnik.Form6();
                 f6.ShowDialog();
                 Close();
             }
             else
             {
                Spravochnik.Form6 f6 = new Spravochnik.Form6();
                 f6.ShowDialog();
                 Close();
             }
             */
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            button4.Focus();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            button2.Enabled = false;

            button3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            if (w.vibor == 1)
            {
                string sql = String.Concat("SELECT * FROM Test1");
                OleDbCommand command = new OleDbCommand(sql, myConnection);

                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    zad[count] = dataReader["Zadanie"].ToString();
                    question[count] = dataReader["Vopros"].ToString();
                    answer1[count] = dataReader["Variant1"].ToString();
                    answer2[count] = dataReader["Variant2"].ToString();
                    answer3[count] = dataReader["Variant3"].ToString();
                    answer4[count] = dataReader["Variant4"].ToString();
                    tem[count] = dataReader["Tema"].ToString();
                    verno[count] = dataReader["Vern"].ToString();
                    //rights[count] = dataReader["Vern"].ToString();
                    count++;
                }

                count = 0;
                label1.Text = tem[count];
                label2.Text = zad[count];
                label3.Text = question[count];
                radioButton1.Text = answer1[count];
                radioButton2.Text = answer2[count];
                radioButton3.Text = answer3[count];
                radioButton4.Text = answer4[count];
                //label7.Text = rights[count];
                label7.Text = verno[count];

                myConnection.Close();

                //Word.Document doc = null;
                //try
                //{
                //    Word.Application app = new Word.Application();
                //    string source = AppDomain.CurrentDomain.BaseDirectory + @"\\Shablonchik.dotx";
                //    doc = app.Documents.Add(source);
                //    Word.Bookmarks wBookmarks = doc.Bookmarks;

                //    doc.Bookmarks["tema"].Range.Text = label1.Text;
                //    doc.Bookmarks["zad1"].Range.Text = label3.Text;
                //    doc.Bookmarks["zad1var1"].Range.Text = radioButton1.Text;
                //    doc.Bookmarks["zad1var2"].Range.Text = radioButton2.Text;
                //    doc.Bookmarks["zad1var3"].Range.Text = radioButton3.Text;
                //    doc.Bookmarks["zad1var4"].Range.Text = radioButton4.Text;
                //    //doc.Bookmarks["otvet"].Range.Text = rights[count];
                //    //doc.Bookmarks["vernotvet"].Range.Text = "invited";

                //}

                //catch (Exception ex)
                //{
                //    doc.Close();
                //    doc = null;
                //    MessageBox.Show("Во время выполнения произошла ошибка!");
                //}

            }

            if (w.vibor == 2)
            {
                string sql = String.Concat("SELECT * FROM Test2");
                OleDbCommand command = new OleDbCommand(sql, myConnection);

                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    zad[count] = dataReader["Zadanie"].ToString();
                    question[count] = dataReader["Vopros"].ToString();
                    answer1[count] = dataReader["Variant1"].ToString();
                    answer2[count] = dataReader["Variant2"].ToString();
                    answer3[count] = dataReader["Variant3"].ToString();
                    answer4[count] = dataReader["Variant4"].ToString();
                    tem[count] = dataReader["Tema"].ToString();
                    verno[count] = dataReader["Vern"].ToString();
                    count++;
                }


                count = 0;
                label1.Text = tem[count];
                label2.Text = zad[count];
                label3.Text = question[count];
                radioButton1.Text = answer1[count];
                radioButton2.Text = answer2[count];
                radioButton3.Text = answer3[count];
                radioButton4.Text = answer4[count];
                label7.Text = verno[count];

                myConnection.Close();
            }

            if (w.vibor == 3)
            {
                string sql = String.Concat("SELECT * FROM Test3");
                OleDbCommand command = new OleDbCommand(sql, myConnection);

                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    zad[count] = dataReader["Zadanie"].ToString();
                    question[count] = dataReader["Vopros"].ToString();
                    answer1[count] = dataReader["Variant1"].ToString();
                    answer2[count] = dataReader["Variant2"].ToString();
                    answer3[count] = dataReader["Variant3"].ToString();
                    answer4[count] = dataReader["Variant4"].ToString();
                    tem[count] = dataReader["Tema"].ToString();
                    verno[count] = dataReader["Vern"].ToString();
                    count++;
                }


                count = 0;
                label1.Text = tem[count];
                label2.Text = zad[count];
                label3.Text = question[count];
                radioButton1.Text = answer1[count];
                radioButton2.Text = answer2[count];
                radioButton3.Text = answer3[count];
                radioButton4.Text = answer4[count];
                label7.Text = verno[count];

                myConnection.Close();
            }

            if (w.vibor == 4)
            {
                string sql = String.Concat("SELECT * FROM Test4");
                OleDbCommand command = new OleDbCommand(sql, myConnection);

                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    zad[count] = dataReader["Zadanie"].ToString();
                    question[count] = dataReader["Vopros"].ToString();
                    answer1[count] = dataReader["Variant1"].ToString();
                    answer2[count] = dataReader["Variant2"].ToString();
                    answer3[count] = dataReader["Variant3"].ToString();
                    answer4[count] = dataReader["Variant4"].ToString();
                    tem[count] = dataReader["Tema"].ToString();
                    verno[count] = dataReader["Vern"].ToString();
                    count++;
                }


                count = 0;
                label1.Text = tem[count];
                label2.Text = zad[count];
                label3.Text = question[count];
                radioButton1.Text = answer1[count];
                radioButton2.Text = answer2[count];
                radioButton3.Text = answer3[count];
                radioButton4.Text = answer4[count];
                label7.Text = verno[count];

                myConnection.Close();
            }

            if (w.vibor == 5)
            {
                string sql = String.Concat("SELECT * FROM Test5");
                OleDbCommand command = new OleDbCommand(sql, myConnection);

                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    zad[count] = dataReader["Zadanie"].ToString();
                    question[count] = dataReader["Vopros"].ToString();
                    answer1[count] = dataReader["Variant1"].ToString();
                    answer2[count] = dataReader["Variant2"].ToString();
                    answer3[count] = dataReader["Variant3"].ToString();
                    answer4[count] = dataReader["Variant4"].ToString();
                    tem[count] = dataReader["Tema"].ToString();
                    verno[count] = dataReader["Vern"].ToString();
                    count++;
                }


                count = 0;
                label1.Text = tem[count];
                label2.Text = zad[count];
                label3.Text = question[count];
                radioButton1.Text = answer1[count];
                radioButton2.Text = answer2[count];
                radioButton3.Text = answer3[count];
                radioButton4.Text = answer4[count];
                label7.Text = verno[count];

                myConnection.Close();
            }

            if (w.vibor == 6)
            {
                string sql = String.Concat("SELECT * FROM Test6");
                OleDbCommand command = new OleDbCommand(sql, myConnection);

                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    zad[count] = dataReader["Zadanie"].ToString();
                    question[count] = dataReader["Vopros"].ToString();
                    answer1[count] = dataReader["Variant1"].ToString();
                    answer2[count] = dataReader["Variant2"].ToString();
                    answer3[count] = dataReader["Variant3"].ToString();
                    answer4[count] = dataReader["Variant4"].ToString();
                    tem[count] = dataReader["Tema"].ToString();
                    verno[count] = dataReader["Vern"].ToString();
                    count++;
                }


                count = 0;
                label1.Text = tem[count];
                label2.Text = zad[count];
                label3.Text = question[count];
                radioButton1.Text = answer1[count];
                radioButton2.Text = answer2[count];
                radioButton3.Text = answer3[count];
                radioButton4.Text = answer4[count];
                label7.Text = verno[count];

                myConnection.Close();
            }

            if (w.vibor == 7)
            {
                string sql = String.Concat("SELECT * FROM Test7");
                OleDbCommand command = new OleDbCommand(sql, myConnection);

                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    zad[count] = dataReader["Zadanie"].ToString();
                    question[count] = dataReader["Vopros"].ToString();
                    answer1[count] = dataReader["Variant1"].ToString();
                    answer2[count] = dataReader["Variant2"].ToString();
                    answer3[count] = dataReader["Variant3"].ToString();
                    answer4[count] = dataReader["Variant4"].ToString();
                    tem[count] = dataReader["Tema"].ToString();
                    verno[count] = dataReader["Vern"].ToString();
                    count++;
                }


                count = 0;
                label1.Text = tem[count];
                label2.Text = zad[count];
                label3.Text = question[count];
                radioButton1.Text = answer1[count];
                radioButton2.Text = answer2[count];
                radioButton3.Text = answer3[count];
                radioButton4.Text = answer4[count];
                label7.Text = verno[count];

                myConnection.Close();
            }

            if (w.vibor == 8)
            {
                string sql = String.Concat("SELECT * FROM Test8");
                OleDbCommand command = new OleDbCommand(sql, myConnection);

                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    zad[count] = dataReader["Zadanie"].ToString();
                    question[count] = dataReader["Vopros"].ToString();
                    answer1[count] = dataReader["Variant1"].ToString();
                    answer2[count] = dataReader["Variant2"].ToString();
                    answer3[count] = dataReader["Variant3"].ToString();
                    answer4[count] = dataReader["Variant4"].ToString();
                    tem[count] = dataReader["Tema"].ToString();
                    verno[count] = dataReader["Vern"].ToString();
                    count++;
                }


                count = 0;
                label1.Text = tem[count];
                label2.Text = zad[count];
                label3.Text = question[count];
                radioButton1.Text = answer1[count];
                radioButton2.Text = answer2[count];
                radioButton3.Text = answer3[count];
                radioButton4.Text = answer4[count];
                label7.Text = verno[count];

                myConnection.Close();
            }

            if (w.vibor == 9)
            {
                string sql = String.Concat("SELECT * FROM Test9");
                OleDbCommand command = new OleDbCommand(sql, myConnection);

                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    zad[count] = dataReader["Zadanie"].ToString();
                    question[count] = dataReader["Vopros"].ToString();
                    answer1[count] = dataReader["Variant1"].ToString();
                    answer2[count] = dataReader["Variant2"].ToString();
                    answer3[count] = dataReader["Variant3"].ToString();
                    answer4[count] = dataReader["Variant4"].ToString();
                    tem[count] = dataReader["Tema"].ToString();
                    verno[count] = dataReader["Vern"].ToString();
                    count++;
                }


                count = 0;
                label1.Text = tem[count];
                label2.Text = zad[count];
                label3.Text = question[count];
                radioButton1.Text = answer1[count];
                radioButton2.Text = answer2[count];
                radioButton3.Text = answer3[count];
                radioButton4.Text = answer4[count];
                label7.Text = verno[count];

                myConnection.Close();
            }

            if (w.vibor == 10)
            {
                string sql = String.Concat("SELECT * FROM Test10");
                OleDbCommand command = new OleDbCommand(sql, myConnection);

                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    zad[count] = dataReader["Zadanie"].ToString();
                    question[count] = dataReader["Vopros"].ToString();
                    answer1[count] = dataReader["Variant1"].ToString();
                    answer2[count] = dataReader["Variant2"].ToString();
                    answer3[count] = dataReader["Variant3"].ToString();
                    answer4[count] = dataReader["Variant4"].ToString();
                    tem[count] = dataReader["Tema"].ToString();
                    verno[count] = dataReader["Vern"].ToString();
                    count++;
                }


                count = 0;
                label1.Text = tem[count];
                label2.Text = zad[count];
                label3.Text = question[count];
                radioButton1.Text = answer1[count];
                radioButton2.Text = answer2[count];
                radioButton3.Text = answer3[count];
                radioButton4.Text = answer4[count];
                label7.Text = verno[count];

                myConnection.Close();
            }

            if (w.vibor == 11)
            {
                string sql = String.Concat("SELECT * FROM Test11");
                OleDbCommand command = new OleDbCommand(sql, myConnection);

                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    zad[count] = dataReader["Zadanie"].ToString();
                    question[count] = dataReader["Vopros"].ToString();
                    answer1[count] = dataReader["Variant1"].ToString();
                    answer2[count] = dataReader["Variant2"].ToString();
                    answer3[count] = dataReader["Variant3"].ToString();
                    answer4[count] = dataReader["Variant4"].ToString();
                    tem[count] = dataReader["Tema"].ToString();
                    verno[count] = dataReader["Vern"].ToString();
                    count++;
                }


                count = 0;
                label1.Text = tem[count];
                label2.Text = zad[count];
                label3.Text = question[count];
                radioButton1.Text = answer1[count];
                radioButton2.Text = answer2[count];
                radioButton3.Text = answer3[count];
                radioButton4.Text = answer4[count];
                label7.Text = verno[count];

                myConnection.Close();
            }

            if (w.vibor == 12)
            {
                string sql = String.Concat("SELECT * FROM Test12");
                OleDbCommand command = new OleDbCommand(sql, myConnection);

                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    zad[count] = dataReader["Zadanie"].ToString();
                    question[count] = dataReader["Vopros"].ToString();
                    answer1[count] = dataReader["Variant1"].ToString();
                    answer2[count] = dataReader["Variant2"].ToString();
                    answer3[count] = dataReader["Variant3"].ToString();
                    answer4[count] = dataReader["Variant4"].ToString();
                    tem[count] = dataReader["Tema"].ToString();
                    verno[count] = dataReader["Vern"].ToString();
                    count++;
                }


                count = 0;
                label1.Text = tem[count];
                label2.Text = zad[count];
                label3.Text = question[count];
                radioButton1.Text = answer1[count];
                radioButton2.Text = answer2[count];
                radioButton3.Text = answer3[count];
                radioButton4.Text = answer4[count];
                label7.Text = verno[count];

                myConnection.Close();
            }

            radioButton1.CheckedChanged += new EventHandler(izm);
            radioButton2.CheckedChanged += new EventHandler(izm);
            radioButton3.CheckedChanged += new EventHandler(izm);
            radioButton4.CheckedChanged += new EventHandler(izm);
            sledvopr();
        }
        int count1 = 0;
        void sledvopr()
        {

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            button2.Enabled = false;

        }
        void izm(Object sender, EventArgs e)
        {

            button2.Enabled = true; button2.Focus();

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = false;

            if (w.vibor == 1)
            {
                string sql = String.Concat("SELECT * FROM Test1");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                count = 0;
                while (dataReader.Read())
                {
                    rights[count] = dataReader["Vern"].ToString();
                    count++;
                }
                //string queryString = "INSERT INTO Rezults (Otvet) values('" + count + "')";
                //OleDbCommand command1 = new OleDbCommand(queryString, myConnection);
                //command1.ExecuteNonQuery();
            }
            if (w.vibor == 2)
            {
                string sql = String.Concat("SELECT * FROM Test2");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                count = 0;
                while (dataReader.Read())
                {
                    rights[count] = dataReader["Vern"].ToString();
                    count++;
                }
            }

            if (w.vibor == 3)
            {
                string sql = String.Concat("SELECT * FROM Test3");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                count = 0;
                while (dataReader.Read())
                {
                    rights[count] = dataReader["Vern"].ToString();
                    count++;
                }
            }

            if (w.vibor == 4)
            {
                string sql = String.Concat("SELECT * FROM Test4");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                count = 0;
                while (dataReader.Read())
                {
                    rights[count] = dataReader["Vern"].ToString();
                    count++;
                }
            }

            if (w.vibor == 5)
            {
                string sql = String.Concat("SELECT * FROM Test5");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                count = 0;
                while (dataReader.Read())
                {
                    rights[count] = dataReader["Vern"].ToString();
                    count++;
                }
            }

            if (w.vibor == 6)
            {
                string sql = String.Concat("SELECT * FROM Test6");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                count = 0;
                while (dataReader.Read())
                {
                    rights[count] = dataReader["Vern"].ToString();
                    count++;
                }
            }

            if (w.vibor == 7)
            {
                string sql = String.Concat("SELECT * FROM Test7");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                count = 0;
                while (dataReader.Read())
                {
                    rights[count] = dataReader["Vern"].ToString();
                    count++;
                }
            }

            if (w.vibor == 8)
            {
                string sql = String.Concat("SELECT * FROM Test8");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                count = 0;
                while (dataReader.Read())
                {
                    rights[count] = dataReader["Vern"].ToString();
                    count++;
                }
            }

            if (w.vibor == 9)
            {
                string sql = String.Concat("SELECT * FROM Test9");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                count = 0;
                while (dataReader.Read())
                {
                    rights[count] = dataReader["Vern"].ToString();
                    count++;
                }
            }

            if (w.vibor == 10)
            {
                string sql = String.Concat("SELECT * FROM Test10");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                count = 0;
                while (dataReader.Read())
                {
                    rights[count] = dataReader["Vern"].ToString();
                    count++;
                }
            }

            if (w.vibor == 11)
            {
                string sql = String.Concat("SELECT * FROM Test11");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                count = 0;
                while (dataReader.Read())
                {
                    rights[count] = dataReader["Vern"].ToString();
                    count++;
                }
            }

            if (w.vibor == 12)
            {
                string sql = String.Concat("SELECT * FROM Test12");
                OleDbCommand command = new OleDbCommand(sql, myConnection);
                myConnection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                count = 0;
                while (dataReader.Read())
                {
                    rights[count] = dataReader["Vern"].ToString();
                    count++;
                }
            }

            myConnection.Close();

            //radioButton1.Text = a;
            //radioButton2.Text = b;
            //radioButton3.Text = c;
            //radioButton4.Text = d;

            if (radioButton1.Checked == true)
            {
                myConnection.Open();
                //string queryString = "INSERT INTO Rezults (Otvet) values('" + radioButton1.Text + "')";
                string queryString = "INSERT INTO Rezults (Tema, Otvet, Zadanie, Variant1, Variant2, Variant3, Variant4, Vern) values('" + label1.Text + "' ,'" + radioButton1.Text + "' , '" + label3.Text + "' , '" + radioButton1.Text + "', '" + radioButton2.Text + "', '" + radioButton3.Text + "', '" + radioButton4.Text + "', '" + label7.Text + "')";
                OleDbDataAdapter DataAdapter = new OleDbDataAdapter("SELECT * FROM Rezults", myConnection);
                DataSet dt = new DataSet();
                DataAdapter.Fill(dt);
                OleDbCommand command = new OleDbCommand(queryString, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();

            }
            if (radioButton2.Checked == true)
            {
                myConnection.Open();
                string queryString = "INSERT INTO Rezults (Tema, Otvet, Zadanie, Variant1, Variant2, Variant3, Variant4, Vern) values('" + label1.Text + "' ,'" + radioButton2.Text + "' , '" + label3.Text + "' , '" + radioButton1.Text + "', '" + radioButton2.Text + "', '" + radioButton3.Text + "', '" + radioButton4.Text + "', '" + label7.Text + "')";
                OleDbDataAdapter DataAdapter = new OleDbDataAdapter("SELECT * FROM Rezults", myConnection);
                DataSet dt = new DataSet();
                DataAdapter.Fill(dt);
                OleDbCommand command = new OleDbCommand(queryString, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();

                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dorova.accdb");
                //con.Open();
                //string queryString = "INSERT INTO Rezults (Otvet) values('" + radioButton2.Text + "')";
                //OleDbCommand command1 = new OleDbCommand(queryString, myConnection);
                //command1.ExecuteNonQuery();
                //con.Close();
            }
            if (radioButton3.Checked == true)
            {
                myConnection.Open();
                string queryString = "INSERT INTO Rezults (Tema, Otvet, Zadanie, Variant1, Variant2, Variant3, Variant4, Vern) values('" + label1.Text + "' ,'" + radioButton3.Text + "' , '" + label3.Text + "' , '" + radioButton1.Text + "', '" + radioButton2.Text + "', '" + radioButton3.Text + "', '" + radioButton4.Text + "', '" + label7.Text + "')";
                OleDbDataAdapter DataAdapter = new OleDbDataAdapter("SELECT * FROM Rezults", myConnection);
                DataSet dt = new DataSet();
                DataAdapter.Fill(dt);
                OleDbCommand command = new OleDbCommand(queryString, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
            }
            if (radioButton4.Checked == true)
            {
                myConnection.Open();
                string queryString = "INSERT INTO Rezults (Tema, Otvet, Zadanie, Variant1, Variant2, Variant3, Variant4, Vern) values('" + label1.Text + "' ,'" + radioButton4.Text + "' , '" + label3.Text + "' , '" + radioButton1.Text + "', '" + radioButton2.Text + "', '" + radioButton3.Text + "', '" + radioButton4.Text + "', '" + label7.Text + "')";
                OleDbDataAdapter DataAdapter = new OleDbDataAdapter("SELECT * FROM Rezults", myConnection);
                DataSet dt = new DataSet();
                DataAdapter.Fill(dt);
                OleDbCommand command = new OleDbCommand(queryString, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
            }

            if ((radioButton1.Checked && radioButton1.Text == rights[count1]) || (radioButton2.Checked && radioButton2.Text == rights[count1]) || (radioButton3.Checked && radioButton3.Text == rights[count1]) || (radioButton4.Checked && radioButton4.Text == rights[count1]))
            {
                MessageBox.Show("Правильный ответ!");

                count1++;
                otv++;
                label1.Text = tem[count1];
                label2.Text = zad[count1];
                label3.Text = question[count1];
                radioButton1.Text = answer1[count1];
                radioButton2.Text = answer2[count1];
                radioButton3.Text = answer3[count1];
                radioButton4.Text = answer4[count1];
                label7.Text = verno[count1];

                //string queryString = "INSERT INTO Rezults (Otvet) values('" + count1 + "')";
                //OleDbCommand command1 = new OleDbCommand(queryString, myConnection);
                //command1.ExecuteNonQuery();
                //myConnection.Close();
            }

            else
            {
                MessageBox.Show("Неправильный ответ!");

                count1++;
                label1.Text = tem[count1];
                label2.Text = zad[count1];
                label3.Text = question[count1];
                radioButton1.Text = answer1[count1];
                radioButton2.Text = answer2[count1];
                radioButton3.Text = answer3[count1];
                radioButton4.Text = answer4[count1];
                label7.Text = verno[count1];
            }

            


            if (count1 == 9)
            {
                button2.Text = "Завершить";

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

                button2.Enabled = false;
            }

            
            if (count1 == 10)
            {
                button2.Visible = false;
                button3.Visible = true;
            }

            if (button2.Text == "Далее")
            {

                sledvopr();
            } 

            if (button3.Visible == true)
            {
                label6.Visible = true;
                myConnection.Open();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM polzov", myConnection);
                DataSet dt = new DataSet();
                dataAdapter.Fill(dt);
                label6.Text = dt.Tables[0].Rows[0].Field<string>("Imya").ToString() + " " + dt.Tables[0].Rows[0].Field<string>("Otchestvo").ToString();
                //label6.Text = ",";
                myConnection.Close();

                label4.Visible = true;
                label4.Text = string.Format("По итогам теста из 10 вопросов вы ответили верно на :{0}", otv);
                label5.Visible = true;
                label5.Text = string.Format("Спасибо, что прошли данный тест!\n" + "При необходимости вы можете разобрать свои ошибки\n" + "и попытаться пройти вновь.");

                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите путь сохранения!");

            Word.Document doc = null;
            try
            {
                Word.Application app = new Word.Application();
                string source = AppDomain.CurrentDomain.BaseDirectory + @"\\Shablonchik.dotx";
                doc = app.Documents.Add(source);
                doc.Activate();

                Word.Bookmarks wBookmarks = doc.Bookmarks;
                //Word.Range wRange;
                //int i = 0;
                //string[] data = new string[72] { " ", "Past Simple", "I (to invite) __ your friend to the party.", "invited", "invite", "inviting", "invites", "", "invited",//1
                //                                 "Paul (to find) __ a good and inexpensive hotel.", "finded", "found", "finds", "finding", "", "found",//2
                //                                 "We (to understand) __ each other.", "understood", "understanded", "understand", "understanding", "", "understand",//3
                //                                 "Did you (to see) __ my new bike?", "seen", "see", "saw", "seeing", "", "seeing",//4
                //                                 "I (not to know) __ this.", "didn't know", "wasn't know", "didn't knew", "didn't knows", "", "didn't knew",//5
                //                                 "Why did you (to ask) __ me this question?", "asking", "asked", "ask", "asks" ,"" , "asked",//6
                //                                 "She (not to like) __ New York.", "didn't liked", "did not like", "wasn't liked", "was not like" ,"" , "didn't liked",//7
                //                                 "I (to think) __ you (not to be) __ busy.", "thought, aren't", "thought, weren't", "thinked, isn't", "thinked, weren't" ,"" , "thought, weren't",//8
                //                                 "How (can) __ you (to forget) __ about her birthday?", "could, forgot", "caned, forgetted", "could, forget", "caned, forget" ,"" , "could, forget",//9
                //                                 "At 7:50 I (to sleep) __, so I (to be) __ able to be at the crime scene.", "slept, wasn't", "slept, wasn't", "was sleeping, weren't", "was sleeping, wasn't" ,"" , "was sleeping, wasn't",};//10
                //string[] data = new string[16] { " ", "Past Simple", "I (to invite) __ your friend to the party.", "invited", "invite", "inviting", "invites", "", "invited",//1
                //                                 "Paul (to find) __ a good and inexpensive hotel.", "finded", "found", "finds", "finding", "", "found"};//2

                //foreach (Word.Bookmark mark in wBookmarks)
                //{
                //    wRange = mark.Range;
                //    wRange.Text = data[i];
                //    i++;
                //}

                //oDoc.Bookmarks["tema"].Range.Text = q; label1.Text tem[a];

                //string sql = String.Concat("SELECT * FROM Rezults");
                //OleDbDataAdapter DataAdapter = new OleDbDataAdapter("SELECT * FROM Rezults", myConnection);
                //OleDbCommand command = new OleDbCommand(sql, myConnection);
                //DataSet dt = new DataSet();
                //DataAdapter.Fill(dt);
                //myConnection.Open();

                myConnection.Open();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM Rezults", myConnection);
                DataSet dt = new DataSet();
                dataAdapter.Fill(dt);

                //label6.Text = dt.Tables[0].Rows[0].Field<string>("Imya").ToString() + " " + dt.Tables[0].Rows[0].Field<string>("Otchestvo").ToString();
                ////label6.Text = ",";
                //myConnection.Close();

                doc.Bookmarks["a"].Range.Text = label6.Text;
                doc.Bookmarks["b"].Range.Text = dt.Tables[0].Rows[0].Field<string>("Tema").ToString();
                doc.Bookmarks["c"].Range.Text = dt.Tables[0].Rows[0].Field<string>("Zadanie").ToString();
                doc.Bookmarks["c1"].Range.Text = dt.Tables[0].Rows[0].Field<string>("Variant1").ToString();
                doc.Bookmarks["c2"].Range.Text = dt.Tables[0].Rows[0].Field<string>("Variant2").ToString();
                doc.Bookmarks["c3"].Range.Text = dt.Tables[0].Rows[0].Field<string>("Variant3").ToString();
                doc.Bookmarks["c4"].Range.Text = dt.Tables[0].Rows[0].Field<string>("Variant4").ToString();
                doc.Bookmarks["c5"].Range.Text = dt.Tables[0].Rows[0].Field<string>("Otvet").ToString();
                doc.Bookmarks["c6"].Range.Text = dt.Tables[0].Rows[0].Field<string>("Vern").ToString();

                doc.Bookmarks["d"].Range.Text = dt.Tables[0].Rows[1].Field<string>("Zadanie").ToString();
                doc.Bookmarks["d1"].Range.Text = dt.Tables[0].Rows[1].Field<string>("Variant1").ToString();
                doc.Bookmarks["d2"].Range.Text = dt.Tables[0].Rows[1].Field<string>("Variant2").ToString();
                doc.Bookmarks["d3"].Range.Text = dt.Tables[0].Rows[1].Field<string>("Variant3").ToString();
                doc.Bookmarks["d4"].Range.Text = dt.Tables[0].Rows[1].Field<string>("Variant4").ToString();
                doc.Bookmarks["d5"].Range.Text = dt.Tables[0].Rows[1].Field<string>("Otvet").ToString();
                doc.Bookmarks["d6"].Range.Text = dt.Tables[0].Rows[1].Field<string>("Vern").ToString();

                doc.Bookmarks["e"].Range.Text = dt.Tables[0].Rows[2].Field<string>("Zadanie").ToString();
                doc.Bookmarks["e1"].Range.Text = dt.Tables[0].Rows[2].Field<string>("Variant1").ToString();
                doc.Bookmarks["e2"].Range.Text = dt.Tables[0].Rows[2].Field<string>("Variant2").ToString();
                doc.Bookmarks["e3"].Range.Text = dt.Tables[0].Rows[2].Field<string>("Variant3").ToString();
                doc.Bookmarks["e4"].Range.Text = dt.Tables[0].Rows[2].Field<string>("Variant4").ToString();
                doc.Bookmarks["e5"].Range.Text = dt.Tables[0].Rows[2].Field<string>("Otvet").ToString();
                doc.Bookmarks["e6"].Range.Text = dt.Tables[0].Rows[2].Field<string>("Vern").ToString();

                doc.Bookmarks["f"].Range.Text = dt.Tables[0].Rows[3].Field<string>("Zadanie").ToString();
                doc.Bookmarks["f1"].Range.Text = dt.Tables[0].Rows[3].Field<string>("Variant1").ToString();
                doc.Bookmarks["f2"].Range.Text = dt.Tables[0].Rows[3].Field<string>("Variant2").ToString();
                doc.Bookmarks["f3"].Range.Text = dt.Tables[0].Rows[3].Field<string>("Variant3").ToString();
                doc.Bookmarks["f4"].Range.Text = dt.Tables[0].Rows[3].Field<string>("Variant4").ToString();
                doc.Bookmarks["f5"].Range.Text = dt.Tables[0].Rows[3].Field<string>("Otvet").ToString();
                doc.Bookmarks["f6"].Range.Text = dt.Tables[0].Rows[3].Field<string>("Vern").ToString();

                doc.Bookmarks["g"].Range.Text = dt.Tables[0].Rows[4].Field<string>("Zadanie").ToString();
                doc.Bookmarks["g1"].Range.Text = dt.Tables[0].Rows[4].Field<string>("Variant1").ToString();
                doc.Bookmarks["g2"].Range.Text = dt.Tables[0].Rows[4].Field<string>("Variant2").ToString();
                doc.Bookmarks["g3"].Range.Text = dt.Tables[0].Rows[4].Field<string>("Variant3").ToString();
                doc.Bookmarks["g4"].Range.Text = dt.Tables[0].Rows[4].Field<string>("Variant4").ToString();
                doc.Bookmarks["g5"].Range.Text = dt.Tables[0].Rows[4].Field<string>("Otvet").ToString();
                doc.Bookmarks["g6"].Range.Text = dt.Tables[0].Rows[4].Field<string>("Vern").ToString();

                doc.Bookmarks["i"].Range.Text = dt.Tables[0].Rows[5].Field<string>("Zadanie").ToString();
                doc.Bookmarks["i1"].Range.Text = dt.Tables[0].Rows[5].Field<string>("Variant1").ToString();
                doc.Bookmarks["i2"].Range.Text = dt.Tables[0].Rows[5].Field<string>("Variant2").ToString();
                doc.Bookmarks["i3"].Range.Text = dt.Tables[0].Rows[5].Field<string>("Variant3").ToString();
                doc.Bookmarks["i4"].Range.Text = dt.Tables[0].Rows[5].Field<string>("Variant4").ToString();
                doc.Bookmarks["i5"].Range.Text = dt.Tables[0].Rows[5].Field<string>("Otvet").ToString();
                doc.Bookmarks["i6"].Range.Text = dt.Tables[0].Rows[5].Field<string>("Vern").ToString();

                doc.Bookmarks["j"].Range.Text = dt.Tables[0].Rows[6].Field<string>("Zadanie").ToString();
                doc.Bookmarks["j1"].Range.Text = dt.Tables[0].Rows[6].Field<string>("Variant1").ToString();
                doc.Bookmarks["j2"].Range.Text = dt.Tables[0].Rows[6].Field<string>("Variant2").ToString();
                doc.Bookmarks["j3"].Range.Text = dt.Tables[0].Rows[6].Field<string>("Variant3").ToString();
                doc.Bookmarks["j4"].Range.Text = dt.Tables[0].Rows[6].Field<string>("Variant4").ToString();
                doc.Bookmarks["j5"].Range.Text = dt.Tables[0].Rows[6].Field<string>("Otvet").ToString();
                doc.Bookmarks["j6"].Range.Text = dt.Tables[0].Rows[6].Field<string>("Vern").ToString();

                doc.Bookmarks["t"].Range.Text = dt.Tables[0].Rows[7].Field<string>("Zadanie").ToString();
                doc.Bookmarks["t1"].Range.Text = dt.Tables[0].Rows[7].Field<string>("Variant1").ToString();
                doc.Bookmarks["t2"].Range.Text = dt.Tables[0].Rows[7].Field<string>("Variant2").ToString();
                doc.Bookmarks["t3"].Range.Text = dt.Tables[0].Rows[7].Field<string>("Variant3").ToString();
                doc.Bookmarks["t4"].Range.Text = dt.Tables[0].Rows[7].Field<string>("Variant4").ToString();
                doc.Bookmarks["t5"].Range.Text = dt.Tables[0].Rows[7].Field<string>("Otvet").ToString();
                doc.Bookmarks["t6"].Range.Text = dt.Tables[0].Rows[7].Field<string>("Vern").ToString();

                doc.Bookmarks["u"].Range.Text = dt.Tables[0].Rows[8].Field<string>("Zadanie").ToString();
                doc.Bookmarks["u1"].Range.Text = dt.Tables[0].Rows[8].Field<string>("Variant1").ToString();
                doc.Bookmarks["u2"].Range.Text = dt.Tables[0].Rows[8].Field<string>("Variant2").ToString();
                doc.Bookmarks["u3"].Range.Text = dt.Tables[0].Rows[8].Field<string>("Variant3").ToString();
                doc.Bookmarks["u4"].Range.Text = dt.Tables[0].Rows[8].Field<string>("Variant4").ToString();
                doc.Bookmarks["u5"].Range.Text = dt.Tables[0].Rows[8].Field<string>("Otvet").ToString();
                doc.Bookmarks["u6"].Range.Text = dt.Tables[0].Rows[8].Field<string>("Vern").ToString();

                doc.Bookmarks["v"].Range.Text = dt.Tables[0].Rows[9].Field<string>("Zadanie").ToString();
                doc.Bookmarks["v1"].Range.Text = dt.Tables[0].Rows[9].Field<string>("Variant1").ToString();
                doc.Bookmarks["v2"].Range.Text = dt.Tables[0].Rows[9].Field<string>("Variant2").ToString();
                doc.Bookmarks["v3"].Range.Text = dt.Tables[0].Rows[9].Field<string>("Variant3").ToString();
                doc.Bookmarks["v4"].Range.Text = dt.Tables[0].Rows[9].Field<string>("Variant4").ToString();
                doc.Bookmarks["v5"].Range.Text = dt.Tables[0].Rows[9].Field<string>("Otvet").ToString();
                doc.Bookmarks["v6"].Range.Text = dt.Tables[0].Rows[9].Field<string>("Vern").ToString();

                //doc.Bookmarks["v6"].Range.Text = dt.Tables[0].Rows[9].Field<string>("Vern").ToString();
                doc.Bookmarks["x"].Range.Text = label4.Text;
                myConnection.Close();
                doc.Close();
                doc = null;
            }
            catch (Exception ex)
            {

                doc.Close();
                doc = null;
                MessageBox.Show("Во время выполнения произошла ошибка!");
            }
            //if (q.vibor == 1)
            //{
            //    Word._Application oWord = new Word.Application();
            //    Word._Document oDoc = oWord.Documents.Open(Environment.CurrentDirectory + "\\Shablon.dotx");
            //    oDoc.Activate();

            //    //oDoc.Bookmarks["tema"].Range.Text = q;  label1.Text tem[a];
            //    oDoc.Bookmarks["tema"].Range.Text = label1.Text;
            //    oDoc.Bookmarks["zad1"].Range.Text = "I (to invite) __ your friend to the party.";
            //    oDoc.Bookmarks["zad1var1"].Range.Text = "invited";
            //    oDoc.Bookmarks["zad1var2"].Range.Text = "invite";
            //    oDoc.Bookmarks["zad1var3"].Range.Text = "inviting";
            //    oDoc.Bookmarks["zad1var4"].Range.Text = "invites";
            //    oDoc.Bookmarks["otvet"].Range.Text = rights[count];
            //    oDoc.Bookmarks["vernotvet"].Range.Text = "invited";

            //    oDoc.Bookmarks["zad2"].Range.Text = "Paul (to find) __ a good and inexpensive hotel.";
            //    oDoc.Bookmarks["zad2var1"].Range.Text = "finded";
            //    oDoc.Bookmarks["zad2var2"].Range.Text = "found";
            //    oDoc.Bookmarks["zad2var3"].Range.Text = "finds";
            //    oDoc.Bookmarks["zad2var4"].Range.Text = "finding";
            //    oDoc.Bookmarks["otvet2"].Range.Text = rights[count]+1;
            //    oDoc.Bookmarks["vernotvet2"].Range.Text = "found";

            //    oDoc.SaveAs(FileName: Environment.CurrentDirectory + "\\Resultus.dotx");
            //}


            //myConnection.Open();
            //OleDbDataReader dataReader = command.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    zad[count] = dataReader["Zadanie"].ToString();
            //    question[count] = dataReader["Vopros"].ToString();
            //    answer1[count] = dataReader["Variant1"].ToString();
            //    answer2[count] = dataReader["Variant2"].ToString();
            //    answer3[count] = dataReader["Variant3"].ToString();
            //    answer4[count] = dataReader["Variant4"].ToString();
            //    tem[count] = dataReader["Tema"].ToString();
            //    count++;
            //}


            //count = 0;
            //label1.Text = tem[count];
            //label2.Text = zad[count];
            //label3.Text = question[count];
            //radioButton1.Text = answer1[count];
            //radioButton2.Text = answer2[count];
            //radioButton3.Text = answer3[count];
            //radioButton4.Text = answer4[count];

            //myConnection.Close();



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
