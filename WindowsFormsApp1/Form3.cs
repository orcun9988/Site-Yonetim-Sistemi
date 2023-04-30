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

namespace SiteYonetimSistemi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=yonetim;Uid=root;Pwd='';");


        private void button1_Click(object sender, EventArgs e)
        {





            { //1 2  3 4  6 16
                if (textBox1.Text == "")
                {
                    MessageBox.Show(" Lütfen İsim-Soyisim giriniz.");
                    return;
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Lütfen daire numarası giriniz.");
                    return;
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Lütfen telefon numarası giriniz.");
                    return;

                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("Lütfen kat bilgisi giriniz.");
                    return;
                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Lütfen blok bilgisi giriniz.");
                    return;
                }
                else if (textBox16.Text == "")
                {

                    MessageBox.Show("Lütfen metre kare bilgisini giriniz.");
                    return;
                }


                else if (textBox5.Text == "")
                {

                    MessageBox.Show("Lütfen ÖncekiAy Kalorifer tüketimi giriniz.");
                    return;
                }


                else if (textBox6.Text == "")
                {

                    MessageBox.Show("Lütfen SonrakiAy Kalorifer tüketimi giriniz.");
                    return;
                }

                else if (textBox12.Text == "")
                {

                    MessageBox.Show("Lütfen ÖncekiAy SıcakSu tüketimi giriniz.");
                    return;
                }

                else if (textBox17.Text == "")
                {

                    MessageBox.Show("Lütfen SonrakiAy SıcakSu tüketimi giriniz.");
                    return;
                }





                string ocak2022 = "INSERT INTO ocak2022(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string subat2022 = "INSERT INTO subat2022(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string mart2022 = "INSERT INTO mart2022(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string nisan2022 = "INSERT INTO nisan2022(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string mayis2022 = "INSERT INTO mayis2022(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string haziran2022 = "INSERT INTO haziran2022(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string temmuz2022 = "INSERT INTO temmuz2022(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string ağustos2022 = "INSERT INTO ağustos2022(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string eylül2022 = "INSERT INTO eylül2022(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string ekim2022 = "INSERT INTO ekim2022(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string kasim2022 = "INSERT INTO kasim2022(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string aralik2022 = "INSERT INTO aralik2022(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string ocak2023 = "INSERT INTO ocak2023(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string subat2023 = "INSERT INTO subat2023(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string mart2023 = "INSERT INTO mart2023(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string nisan2023 = "INSERT INTO nisan2023(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string mayis2023 = "INSERT INTO mayis2023(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string haziran2023 = "INSERT INTO haziran2023(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string temmuz2023 = "INSERT INTO temmuz2023(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string ağustos2023 = "INSERT INTO ağustos2023(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string eylül2023 = "INSERT INTO eylül2023(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string ekim2023 = "INSERT INTO ekim2023(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string kasim2023 = "INSERT INTO kasim2023(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";
                string aralik2023 = "INSERT INTO aralik2023(isim,daire,tel,kat,blok,sicaksu,sutuketim,gaztuketim,oncekiayGAZ,sonrakiayGAZ,oncekiaySu,sonrakiaySu,kalorifer,ekborc,aidat,toplamborc,metre2) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + comboBox1.Text + "',0,0,0,'" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox17.Text + "',0,0,0,0, " + textBox16.Text + " )";



                mysqlbaglan.Open();
                MySqlCommand command = new MySqlCommand(ocak2022, mysqlbaglan);
                MySqlCommand command1 = new MySqlCommand(subat2022, mysqlbaglan);
                MySqlCommand command2 = new MySqlCommand(mart2022, mysqlbaglan);
                MySqlCommand command3 = new MySqlCommand(nisan2022, mysqlbaglan);
                MySqlCommand command4 = new MySqlCommand(mayis2022, mysqlbaglan);
                MySqlCommand command5 = new MySqlCommand(haziran2022, mysqlbaglan);
                MySqlCommand command6 = new MySqlCommand(temmuz2022, mysqlbaglan);
                MySqlCommand command7 = new MySqlCommand(ağustos2022, mysqlbaglan);
                MySqlCommand command8 = new MySqlCommand(eylül2022, mysqlbaglan);
                MySqlCommand command9 = new MySqlCommand(ekim2022, mysqlbaglan);
                MySqlCommand command0 = new MySqlCommand(kasim2022, mysqlbaglan);
                MySqlCommand command11 = new MySqlCommand(aralik2022, mysqlbaglan);
                MySqlCommand command12 = new MySqlCommand(ocak2023, mysqlbaglan);
                MySqlCommand command13 = new MySqlCommand(subat2023, mysqlbaglan);
                MySqlCommand command14 = new MySqlCommand(mart2023, mysqlbaglan);
                MySqlCommand comman15d = new MySqlCommand(nisan2023, mysqlbaglan);
                MySqlCommand command16 = new MySqlCommand(mayis2023, mysqlbaglan);
                MySqlCommand command17 = new MySqlCommand(haziran2023, mysqlbaglan);
                MySqlCommand command18 = new MySqlCommand(temmuz2023, mysqlbaglan);
                MySqlCommand command19 = new MySqlCommand(ağustos2023, mysqlbaglan);
                MySqlCommand command20 = new MySqlCommand(eylül2023, mysqlbaglan);
                MySqlCommand command21 = new MySqlCommand(ekim2023, mysqlbaglan);
                MySqlCommand comman2d = new MySqlCommand(kasim2023, mysqlbaglan);
                MySqlCommand command22 = new MySqlCommand(aralik2023, mysqlbaglan);
                try
                {
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
                    command4.ExecuteNonQuery();
                    command5.ExecuteNonQuery();
                    command6.ExecuteNonQuery();
                    command7.ExecuteNonQuery();
                    command8.ExecuteNonQuery();
                    command9.ExecuteNonQuery();
                    command0.ExecuteNonQuery();
                    command11.ExecuteNonQuery();
                    command12.ExecuteNonQuery();
                    command13.ExecuteNonQuery();
                    command14.ExecuteNonQuery();
                    comman15d.ExecuteNonQuery();
                    command16.ExecuteNonQuery();
                    command17.ExecuteNonQuery();
                    command18.ExecuteNonQuery();
                    command19.ExecuteNonQuery();
                    command20.ExecuteNonQuery();
                    command21.ExecuteNonQuery();
                    comman2d.ExecuteNonQuery();
                    command22.ExecuteNonQuery();

                    if (command.ExecuteNonQuery() >= 1)
                    {
                        mysqlbaglan.Close();
                        MessageBox.Show("Kayıt Başarılı");
                        int arttir;
                        arttir = Convert.ToInt32(textBox2.Text) + 1;
                        textBox2.Text = arttir.ToString();

                        textBox1.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox12.Clear();
                        textBox17.Clear();

                        if (textBox16.Text == "120")
                        {
                            textBox16.Text = "160";
                        }
                        else if (textBox16.Text == "160")
                        {
                            textBox16.Text = "120";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Başarısız");
                        mysqlbaglan.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    mysqlbaglan.Close();
                }












            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                MessageBox.Show("Lütfen önce bir daire numarası giriniz.");
                return;
            }

            if (comboBox11.Text == "")
            {
                MessageBox.Show("Lütfen blok seçiniz.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Emin misin?", "Bu daire bütün kayıtlardan silenecek!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                mysqlbaglan.Open();
                using (MySqlCommand command = new MySqlCommand("DELETE FROM ocak2022 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM subat2022 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM mart2022 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM nisan2022 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();

                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM mayis2022 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM haziran2022 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM temmuz2022 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM ağustos2022 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM eylül2022 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM ekim2022 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM kasim2022 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM aralik2022 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM ocak2023 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM subat2023 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM mart2023 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM nisan2023 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM mayis2023 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM haziran2023 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM temmuz2023 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM ağustos2023 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM eylül2023 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM ekim2023 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM kasim2023 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    command.ExecuteNonQuery();
                }
                using (MySqlCommand command = new MySqlCommand("DELETE FROM aralik2023 WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
                {
                    if (command.ExecuteNonQuery() >= 1)
                    {
                        mysqlbaglan.Close();
                        MessageBox.Show("Silme Başarılı");
                    }
                    else
                    {
                        mysqlbaglan.Close();
                        MessageBox.Show("Silme Başarısız");
                    }
                }

            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                MessageBox.Show("Lütfen önce bir daire numarası giriniz.");
                return;
            }

            if (comboBox11.Text == "")
            {
                MessageBox.Show("Lütfen blok seçiniz.");
                return;
            }

            if (comboBox2.Text == "")
            {
                MessageBox.Show("Lütfen Ay/yıl seçiniz.");
                return;
            }
            mysqlbaglan.Open();
            using (MySqlCommand command = new MySqlCommand("DELETE FROM " + comboBox2.Text + " WHERE daire  = '" + textBox10.Text + "' and blok = '" + comboBox11.Text + "'", mysqlbaglan))
            {
                if (command.ExecuteNonQuery() >= 1)
                {
                    mysqlbaglan.Close();
                    MessageBox.Show("Silme Başarılı");
                }
                else
                {
                    mysqlbaglan.Close();
                    MessageBox.Show("Silme Başarısız");
                }
            }
            mysqlbaglan.Close();
        }
    }
}
