using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=yonetim;Uid=root;Pwd='';");



        private void button1_Click(object sender, EventArgs e)
        {
            mysqlbaglan.Open();
            if (mysqlbaglan.State != ConnectionState.Closed)
            {
                MessageBox.Show("Bağlantı Başarılı Bir Şekilde Gerçekleşti");
            }
            else
            {
                MessageBox.Show("Maalesef Bağlantı Yapılamadı...!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Hilal" || textBox2.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
