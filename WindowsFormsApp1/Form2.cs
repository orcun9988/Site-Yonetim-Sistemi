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
using Microsoft.Office.Interop.Excel;


/*   kayıt silme tamam - sorgulama tamam  - tablo oluşturma tamam  - kayıt yapma tamam - 
  CREATE TABLE IF NOT EXISTS ocak2022 (
    isim varchar(255),
    daire varchar(255),
    tel varchar(255),
    kat varchar(255),
    blok varchar(255),
    sicaksu varchar(255),
    kalorifer varchar(255),
    ekborc varchar(255),
    aidat varchar(255),
    toplamborc varchar(255)
);
*/

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            /*
            string komut = "select * from larasitesi";
            MySqlCommand mycom = new MySqlCommand(komut, mysqlbaglan);
            MySqlDataAdapter adap = new MySqlDataAdapter(komut, mysqlbaglan);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            mysqlbaglan.Open();
            MySqlDataReader mydr = mycom.ExecuteReader();
            mysqlbaglan.Close();
            */

        }

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=yonetim;Uid=root;Pwd='';");

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void Form2_Load(object sender, EventArgs e)
        {


            mysqlbaglan.Open();
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS ocak2022 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS subat2022 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS mart2022 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS nisan2022 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255), sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS mayis2022 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS haziran2022 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS temmuz2022 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS ağustos2022 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS eylül2022 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS ekim2022 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS kasim2022 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS aralik2022 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS ocak2023 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS subat2023 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS mart2023 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS nisan2023 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS mayis2023 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS haziran2023 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS temmuz2023 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS ağustos2023 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS eylül2023 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS ekim2023 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS kasim2023 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255), sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,    toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("CREATE TABLE IF NOT EXISTS aralik2023 (  isim varchar(255),   daire INT(255),  tel INT(255),  kat INT(255),    blok varchar(255), metre2 INT(255), devredenborc INT(255),  sicaksu INT,    kalorifer INT,    ekborc INT,    aidat INT, oncekiayGAZ FLOAT, sonrakiayGAZ FLOAT, oncekiaySu FLOAT, sonrakiaySu FLOAT, gaztuketim FLOAT, sutuketim FLOAT,   toplamborc INT, toplamdogalgazfaturasi INT, toplamsufaturasi INT, sabitisinmamasrafi double, kisiselisinmamasrafi double, sabitsumasrafi double, kisiselsumasrafi double) ", mysqlbaglan))
            {
                command.ExecuteNonQuery();
            }
            mysqlbaglan.Close();
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text == "")
            {
                MessageBox.Show("Lütfen önce ay/yıl seçiniz");
                return;
            }
            else if (textBox13.Text == "")
            {
                MessageBox.Show("Lütfen önce sıcaksu faturası tutarı giriniz.");
                return;
            }

            button2.Enabled = false;
            button4.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button13.Enabled = false;





            //ZAAA
            string aa = "UPDATE ağustos2022 JOIN temmuz2022 ON ağustos2022.isim = temmuz2022.isim SET ağustos2022.OncekiAySu = temmuz2022.sonrakiaySu";
            string bb = "UPDATE eylül2022 JOIN ağustos2022 ON eylül2022.isim = ağustos2022.isim SET eylül2022.OncekiAySu = ağustos2022.sonrakiaySu";
            string cc = "UPDATE ekim2022 JOIN eylül2022 ON ekim2022.isim = eylül2022.isim SET ekim2022.OncekiAySu = eylül2022.sonrakiaySu";
            string dd = "UPDATE kasim2022 JOIN ekim2022 ON kasim2022.isim = ekim2022.isim SET kasim2022.OncekiAySu = ekim2022.sonrakiaySu";
            string ee = "UPDATE aralik2022 JOIN kasim2022 ON aralik2022.isim = kasim2022.isim SET aralik2022.OncekiAySu = kasim2022.sonrakiaySu";
            string ff = "UPDATE ocak2023 JOIN aralik2022 ON ocak2023.isim = aralik2022.isim SET ocak2023.OncekiAySu = aralik2022.sonrakiaySu";
            string gg = "UPDATE subat2023 JOIN ocak2023 ON subat2023.isim = ocak2023.isim SET subat2023.OncekiAySu = ocak2023.sonrakiaySu";
            string hh = "UPDATE mart2023 JOIN subat2023 ON mart2023.isim = subat2023.isim SET mart2023.OncekiAySu = subat2023.sonrakiaySu";
            string jj = "UPDATE nisan2023 JOIN mart2023 ON nisan2023.isim = mart2023.isim SET nisan2023.OncekiAySu = mart2023.sonrakiaySu";
            string kk = "UPDATE mayis2023 JOIN nisan2023 ON mayis2023.isim = nisan2023.isim SET mayis2023.OncekiAySu = nisan2023.sonrakiaySu";
            string ll = "UPDATE haziran2023 JOIN mayis2023 ON haziran2023.isim = mayis2023.isim SET haziran2023.OncekiAySu = mayis2023.sonrakiaySu";
            string ww = "UPDATE temmuz2023 JOIN haziran2023 ON temmuz2023.isim = haziran2023.isim SET temmuz2023.OncekiAySu = haziran2023.sonrakiaySu";
            string oo = "UPDATE ağustos2023 JOIN temmuz2023 ON ağustos2023.isim = temmuz2023.isim SET ağustos2023.OncekiAySu = temmuz2023.sonrakiaySu";
            string rr = "UPDATE eylül2023 JOIN ağustos2023 ON eylül2023.isim = ağustos2023.isim SET eylül2023.OncekiAySu = ağustos2023.sonrakiaySu";
            string tt = "UPDATE ekim2023 JOIN eylül2023 ON ekim2023.isim = eylül2023.isim SET ekim2023.OncekiAySu = eylül2023.sonrakiaySu";
            string yy = "UPDATE kasim2023 JOIN ekim2023 ON kasim2023.isim = ekim2023.isim SET kasim2023.OncekiAySu = ekim2023.sonrakiaySu";
            string uu = "UPDATE aralik2023 JOIN kasim2023 ON aralik2023.isim = kasim2023.isim SET aralik2023.OncekiAySu = kasim2023.sonrakiaySu";
            mysqlbaglan.Open();
            MySqlCommand aq = new MySqlCommand(aa, mysqlbaglan);
            MySqlCommand bq = new MySqlCommand(bb, mysqlbaglan);
            MySqlCommand cq = new MySqlCommand(cc, mysqlbaglan);
            MySqlCommand dq = new MySqlCommand(dd, mysqlbaglan);
            MySqlCommand eq = new MySqlCommand(ee, mysqlbaglan);
            MySqlCommand fq = new MySqlCommand(ff, mysqlbaglan);
            MySqlCommand gq = new MySqlCommand(gg, mysqlbaglan);
            MySqlCommand hq = new MySqlCommand(hh, mysqlbaglan);
            MySqlCommand iq = new MySqlCommand(jj, mysqlbaglan);
            MySqlCommand kq = new MySqlCommand(kk, mysqlbaglan);
            MySqlCommand lq = new MySqlCommand(ll, mysqlbaglan);
            MySqlCommand mq = new MySqlCommand(ww, mysqlbaglan);
            MySqlCommand nq = new MySqlCommand(oo, mysqlbaglan);
            MySqlCommand oq = new MySqlCommand(rr, mysqlbaglan);
            MySqlCommand pq = new MySqlCommand(tt, mysqlbaglan);
            MySqlCommand rq = new MySqlCommand(yy, mysqlbaglan);
            MySqlCommand sq = new MySqlCommand(uu, mysqlbaglan);
            aq.ExecuteNonQuery();
            bq.ExecuteNonQuery();
            cq.ExecuteNonQuery();
            dq.ExecuteNonQuery();
            eq.ExecuteNonQuery();
            fq.ExecuteNonQuery();
            gq.ExecuteNonQuery();
            hq.ExecuteNonQuery();
            iq.ExecuteNonQuery();
            kq.ExecuteNonQuery();
            lq.ExecuteNonQuery();
            mq.ExecuteNonQuery();
            nq.ExecuteNonQuery();
            aq.ExecuteNonQuery();
            oq.ExecuteNonQuery();
            pq.ExecuteNonQuery();
            rq.ExecuteNonQuery();
            sq.ExecuteNonQuery();
            mysqlbaglan.Close();



















            ///  SU TÜKETİM COPY PASTE DOGALGAZDAN
            string hesaplaa = "UPDATE " + comboBox7.Text + " SET sutuketim = sonrakiaySu-oncekiaySu";
            // string sifirati = "UPDATE " + comboBox7.Text + " SET sutuketim = sutuketim * 1000";
            string yuvarla = "UPDATE " + comboBox7.Text + " SET sutuketim = ROUND(sutuketim,3)";

            mysqlbaglan.Open();
            MySqlCommand command22 = new MySqlCommand(hesaplaa, mysqlbaglan);
            //   MySqlCommand command27 = new MySqlCommand(sifirati, mysqlbaglan);
            MySqlCommand command26 = new MySqlCommand(yuvarla, mysqlbaglan);



            command22.ExecuteNonQuery();
            //       command27.ExecuteNonQuery();
            command26.ExecuteNonQuery();



            mysqlbaglan.Close();
            //


            // metre kareleri toplamak için
            string insertQuery = "SELECT SUM(metre2) from " + comboBox7.Text + "";

            mysqlbaglan.Open();
            MySqlCommand command11 = new MySqlCommand(insertQuery, mysqlbaglan);
            MySqlDataReader myReader;
            myReader = command11.ExecuteReader();
            while (myReader.Read())
            {
                label28.Text = myReader[0].ToString();  //5600 toplam metre kareler
            }

            Task.Delay(1000).Wait();
            mysqlbaglan.Close();



            //

            // sutuketim toplamı hesaplama

            string insertQuery2 = "SELECT SUM(sutuketim) from " + comboBox7.Text + "";
            mysqlbaglan.Open();
            MySqlCommand commandx = new MySqlCommand(insertQuery2, mysqlbaglan);
            MySqlDataReader myreader2;
            myreader2 = commandx.ExecuteReader();
            while (myreader2.Read())
            {
                label5.Text = myreader2[0].ToString(); //su tüketim toplamları
            }
            double toplamtuketimkwh = Convert.ToDouble(label5.Text);
            Task.Delay(1000).Wait();
            mysqlbaglan.Close();

            //



            // %30 sabit tüketim hesaplama bölümü
            string dogalgazfaturasitoplami = "UPDATE " + comboBox7.Text + " SET toplamsufaturasi = " + textBox13.Text + "";
            mysqlbaglan.Open();
            MySqlCommand dogalgazfaturatoplamihesapla = new MySqlCommand(dogalgazfaturasitoplami, mysqlbaglan);
            dogalgazfaturatoplamihesapla.ExecuteNonQuery();
            mysqlbaglan.Close();

            double toplamsufatura = Convert.ToDouble(textBox13.Text); // biz giriyoruz tablo sol üst   --6600TL
            double ortaktuketim = toplamsufatura * 30 / 100;     // tablo sol üst                     -- 1274.70
            int toplammetrekare = Convert.ToInt32(label28.Text);
            double sabittuketimbirimfiyati = ortaktuketim / toplammetrekare;      //tablo sağ üst          -- 0.23 ( 0.227625)
            string sabittuketimbirimfiyati2 = sabittuketimbirimfiyati.ToString().Replace(",", ".");

            string hesap1 = "UPDATE " + comboBox7.Text + " SET sabitsumasrafi = " + sabittuketimbirimfiyati2 + " * metre2";       //ortak masraf payını hesaplamak için   daireninmetrekaresi * sabittuketimbirimfiyati   120*1.1786 = 141.4
            mysqlbaglan.Open();
            MySqlCommand sabitmasrafhesapla = new MySqlCommand(hesap1, mysqlbaglan);
            sabitmasrafhesapla.ExecuteNonQuery();
            mysqlbaglan.Close();


            //%30 sabit ısıtma hesaplama bölümü bitiş



            // %70 sabit kişisel ısıtma hesaplama bölümü
            string sufaturasitoplami2 = "UPDATE " + comboBox7.Text + " SET toplamsufaturasi = " + textBox13.Text + "";
            mysqlbaglan.Open();
            MySqlCommand sufaturasihesapla2 = new MySqlCommand(sufaturasitoplami2, mysqlbaglan);
            sufaturasihesapla2.ExecuteNonQuery();
            mysqlbaglan.Close();

            double toplamsufatura2 = Convert.ToDouble(textBox13.Text); // biz giriyoruz tablo sol üst   --22.000TL
            double kisiseltuketim = toplamsufatura2 * 70 / 100;  // tablo sol üst                      -- 15400
            double kisiseltuketimbirim = kisiseltuketim / Convert.ToDouble(label5.Text);      //tablo sağ üst           -- 0.2165
            string kisiseltuketimbirim2 = kisiseltuketimbirim.ToString().Replace(",", ".");


            string hesap2 = "UPDATE " + comboBox7.Text + " SET kisiselsumasrafi = " + kisiseltuketimbirim2 + " * sutuketim";                                                                 //ortak masraf payını hesaplamak için   daireninmetrekaresi * sabittuketimbirimfiyati   120*1.1786 = 141.4
            mysqlbaglan.Open();
            MySqlCommand kisiselmasrafhesapla = new MySqlCommand(hesap2, mysqlbaglan);
            kisiselmasrafhesapla.ExecuteNonQuery();
            mysqlbaglan.Close();


            //%70 sabit kişisel ısıtma hesaplama bölümü bitiş





            //  final borc topla yazdır


            string insertQuery5 = "UPDATE " + comboBox7.Text + " SET sicaksu = sabitsumasrafi + kisiselsumasrafi";

            mysqlbaglan.Open();
            MySqlCommand final = new MySqlCommand(insertQuery5, mysqlbaglan);
            final.ExecuteNonQuery();



            if (final.ExecuteNonQuery() >= 1)
            {
                MessageBox.Show("Sonraki Ay - Önceki Ay  Hesaplandı.\n Ondalık Sayıdan kurtulmak için sonuçlar 1000 ile çarpıldı. \n Küsüratlı sonuçlar yuvarlandı. \n Toplam bina metre karesi hesaplandı: " + label28.Text + " \n Toplam bina sıcaksu tüketimi hesaplandı: " + label5.Text + "\n Sabit tüketim tutarı hesaplanıyor: " + toplamsufatura + " * 30 / 100 = " + toplamsufatura * 30 / 100 + " \n Sabit tüketim birim fiyatı hesaplanıyor: " + ortaktuketim + " / " + toplammetrekare + " = " + sabittuketimbirimfiyati + " \n Kişisel tüketim tutarı hesaplanıyor: " + Convert.ToDouble(textBox13.Text) + " * 70 / 100 = " + Convert.ToInt32(textBox13.Text) * 70 / 100 + " \n Kişisel tüketim birim fiyatı hesaplanıyor: " + kisiseltuketim + " / " + label5.Text + " = " + kisiseltuketimbirim + " \n    SıcakSu hesaplama İşlemi Başarılı!!!");
                mysqlbaglan.Close();


                string komut = "select * from " + comboBox7.Text + "";
                comboBox6.Text = comboBox7.Text;
                MySqlCommand mycom = new MySqlCommand(komut, mysqlbaglan);
                MySqlDataAdapter adap = new MySqlDataAdapter(komut, mysqlbaglan);
                System.Data.DataTable dt = new System.Data.DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
                mysqlbaglan.Open();
                MySqlDataReader mydr = mycom.ExecuteReader();
                mysqlbaglan.Close();
                label18.Text = comboBox6.Text;
            }
            else
            {
                MessageBox.Show("Su borcu hesaplama başarısız oldu.");
                mysqlbaglan.Close();
            }
            button2.Enabled = true;
            button4.Enabled = true;
            button12.Enabled = true;
            button11.Enabled = true;
            button6.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button13.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox6.Text == "")
            {

                MessageBox.Show("Lütfen önce yan taraftan bir ay-yıl seçiniz.");
                return;
            }
            string komut = "select * from " + comboBox6.Text + "";
            MySqlCommand mycom = new MySqlCommand(komut, mysqlbaglan);
            MySqlDataAdapter adap = new MySqlDataAdapter(komut, mysqlbaglan);
            System.Data.DataTable dt = new System.Data.DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            mysqlbaglan.Open();
            MySqlDataReader mydr = mycom.ExecuteReader();
            mysqlbaglan.Close();
            label18.Text = comboBox6.Text;

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

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {


                if (comboBox7.Text == "")
                {
                    MessageBox.Show("Lütfen önce ay/yıl seçiniz");
                    return;
                }
                else if (textBox14.Text == "")
                {
                    MessageBox.Show("Lütfen önce doğalgaz faturası tutarı giriniz.");
                    return;
                }

                button2.Enabled = false;
                button4.Enabled = false;
                button12.Enabled = false;
                button11.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;



                string aa = "UPDATE ağustos2022 JOIN temmuz2022 ON ağustos2022.isim = temmuz2022.isim SET ağustos2022.OncekiAyGAZ = temmuz2022.sonrakiayGAZ";
                string bb = "UPDATE eylül2022 JOIN ağustos2022 ON eylül2022.isim = ağustos2022.isim SET eylül2022.OncekiAyGAZ = ağustos2022.sonrakiayGAZ";
                string cc = "UPDATE ekim2022 JOIN eylül2022 ON ekim2022.isim = eylül2022.isim SET ekim2022.OncekiAyGAZ = eylül2022.sonrakiayGAZ";
                string dd = "UPDATE kasim2022 JOIN ekim2022 ON kasim2022.isim = ekim2022.isim SET kasim2022.OncekiAyGAZ = ekim2022.sonrakiayGAZ";
                string ee = "UPDATE aralik2022 JOIN kasim2022 ON aralik2022.isim = kasim2022.isim SET aralik2022.OncekiAyGAZ = kasim2022.sonrakiayGAZ";
                string ff = "UPDATE ocak2023 JOIN aralik2022 ON ocak2023.isim = aralik2022.isim SET ocak2023.OncekiAyGAZ = aralik2022.sonrakiayGAZ";
                string gg = "UPDATE subat2023 JOIN ocak2023 ON subat2023.isim = ocak2023.isim SET subat2023.OncekiAyGAZ = ocak2023.sonrakiayGAZ";
                string hh = "UPDATE mart2023 JOIN subat2023 ON mart2023.isim = subat2023.isim SET mart2023.OncekiAyGAZ = subat2023.sonrakiayGAZ";
                string jj = "UPDATE nisan2023 JOIN mart2023 ON nisan2023.isim = mart2023.isim SET nisan2023.OncekiAyGAZ = mart2023.sonrakiayGAZ";
                string kk = "UPDATE mayis2023 JOIN nisan2023 ON mayis2023.isim = nisan2023.isim SET mayis2023.OncekiAyGAZ = nisan2023.sonrakiayGAZ";
                string ll = "UPDATE haziran2023 JOIN mayis2023 ON haziran2023.isim = mayis2023.isim SET haziran2023.OncekiAyGAZ = mayis2023.sonrakiayGAZ";
                string ww = "UPDATE temmuz2023 JOIN haziran2023 ON temmuz2023.isim = haziran2023.isim SET temmuz2023.OncekiAyGAZ = haziran2023.sonrakiayGAZ";
                string oo = "UPDATE ağustos2023 JOIN temmuz2023 ON ağustos2023.isim = temmuz2023.isim SET ağustos2023.OncekiAyGAZ = temmuz2023.sonrakiayGAZ";
                string rr = "UPDATE eylül2023 JOIN ağustos2023 ON eylül2023.isim = ağustos2023.isim SET eylül2023.OncekiAyGAZ = ağustos2023.sonrakiayGAZ";
                string tt = "UPDATE ekim2023 JOIN eylül2023 ON ekim2023.isim = eylül2023.isim SET ekim2023.OncekiAyGAZ = eylül2023.sonrakiayGAZ";
                string yy = "UPDATE kasim2023 JOIN ekim2023 ON kasim2023.isim = ekim2023.isim SET kasim2023.OncekiAyGAZ = ekim2023.sonrakiayGAZ";
                string uu = "UPDATE aralik2023 JOIN kasim2023 ON aralik2023.isim = kasim2023.isim SET aralik2023.OncekiAyGAZ = kasim2023.sonrakiayGAZ";
                mysqlbaglan.Open();
                MySqlCommand aq = new MySqlCommand(aa, mysqlbaglan);
                MySqlCommand bq = new MySqlCommand(bb, mysqlbaglan);
                MySqlCommand cq = new MySqlCommand(cc, mysqlbaglan);
                MySqlCommand dq = new MySqlCommand(dd, mysqlbaglan);
                MySqlCommand eq = new MySqlCommand(ee, mysqlbaglan);
                MySqlCommand fq = new MySqlCommand(ff, mysqlbaglan);
                MySqlCommand gq = new MySqlCommand(gg, mysqlbaglan);
                MySqlCommand hq = new MySqlCommand(hh, mysqlbaglan);
                MySqlCommand iq = new MySqlCommand(jj, mysqlbaglan);
                MySqlCommand kq = new MySqlCommand(kk, mysqlbaglan);
                MySqlCommand lq = new MySqlCommand(ll, mysqlbaglan);
                MySqlCommand mq = new MySqlCommand(ww, mysqlbaglan);
                MySqlCommand nq = new MySqlCommand(oo, mysqlbaglan);
                MySqlCommand oq = new MySqlCommand(rr, mysqlbaglan);
                MySqlCommand pq = new MySqlCommand(tt, mysqlbaglan);
                MySqlCommand rq = new MySqlCommand(yy, mysqlbaglan);
                MySqlCommand sq = new MySqlCommand(uu, mysqlbaglan);
                aq.ExecuteNonQuery();
                bq.ExecuteNonQuery();
                cq.ExecuteNonQuery();
                dq.ExecuteNonQuery();
                eq.ExecuteNonQuery();
                fq.ExecuteNonQuery();
                gq.ExecuteNonQuery();
                hq.ExecuteNonQuery();
                iq.ExecuteNonQuery();
                kq.ExecuteNonQuery();
                lq.ExecuteNonQuery();
                mq.ExecuteNonQuery();
                nq.ExecuteNonQuery();
                aq.ExecuteNonQuery();
                oq.ExecuteNonQuery();
                pq.ExecuteNonQuery();
                rq.ExecuteNonQuery();
                sq.ExecuteNonQuery();
                mysqlbaglan.Close();























                ///  GÜNCELLEME BÖLÜMÜ GAZ KWH GİBİ BİRŞEY HESAPLAMAK İÇİN
                string hesaplaa = "UPDATE " + comboBox7.Text + " SET gaztuketim = sonrakiayGAZ-oncekiayGAZ";  // TOPLAM GAZ TÜKETİMİNİ BULMAK İÇİN FARK BULUNUYOR
                string sifirati = "UPDATE " + comboBox7.Text + " SET gaztuketim = gaztuketim * 1000";  // ondalik sayıdan kurtarmak için 1000 ile çarpıyorum
                string yuvarla = "UPDATE " + comboBox7.Text + " SET gaztuketim = ROUND(gaztuketim,0)"; // sayıyı yuvarlıyorum ondalık sayıdan kurtarmak için

                mysqlbaglan.Open();
                MySqlCommand command22 = new MySqlCommand(hesaplaa, mysqlbaglan);
                MySqlCommand command27 = new MySqlCommand(sifirati, mysqlbaglan);
                MySqlCommand command26 = new MySqlCommand(yuvarla, mysqlbaglan);



                command22.ExecuteNonQuery();
                command27.ExecuteNonQuery();
                command26.ExecuteNonQuery();



                mysqlbaglan.Close();
                //


                // metre kareleri toplamak için
                string insertQuery = "SELECT SUM(metre2) from " + comboBox7.Text + "";

                mysqlbaglan.Open();
                MySqlCommand command11 = new MySqlCommand(insertQuery, mysqlbaglan);
                MySqlDataReader myReader;
                myReader = command11.ExecuteReader();
                while (myReader.Read())
                {
                    label28.Text = myReader[0].ToString();

                }

                Task.Delay(1000).Wait();
                mysqlbaglan.Close();



                //

                // gaztuketim toplamı hesaplama

                string insertQuery2 = "SELECT SUM(gaztuketim) from " + comboBox7.Text + "";
                mysqlbaglan.Open();
                MySqlCommand commandx = new MySqlCommand(insertQuery2, mysqlbaglan);
                MySqlDataReader myreader2;
                myreader2 = commandx.ExecuteReader();
                while (myreader2.Read())
                {
                    label5.Text = myreader2[0].ToString();
                }
                int toplamtuketimkwh = Convert.ToInt32(label5.Text);
                Task.Delay(1000).Wait();
                mysqlbaglan.Close();

                //



                // %30 sabit ısıtma hesaplama bölümü
                string dogalgazfaturasitoplami = "UPDATE " + comboBox7.Text + " SET toplamdogalgazfaturasi = " + textBox14.Text + "";
                mysqlbaglan.Open();
                MySqlCommand dogalgazfaturatoplamihesapla = new MySqlCommand(dogalgazfaturasitoplami, mysqlbaglan);
                dogalgazfaturatoplamihesapla.ExecuteNonQuery();
                mysqlbaglan.Close();

                double toplamgazfatura = Convert.ToDouble(textBox14.Text); // biz giriyoruz tablo sol üst   --22.000TL
                double ortaktuketim = toplamgazfatura * 30 / 100;     // tablo sol üst                     -- 6600TL
                int toplammetrekare = Convert.ToInt32(label28.Text);
                double sabittuketimbirimfiyati = ortaktuketim / toplammetrekare;      //tablo sağ üst          -- 1.1786
                string sabittuketimbirimfiyati2 = sabittuketimbirimfiyati.ToString().Replace(",", ".");

                string hesap1 = "UPDATE " + comboBox7.Text + " SET sabitisinmamasrafi = " + sabittuketimbirimfiyati2 + " * metre2";       //ortak masraf payını hesaplamak için   daireninmetrekaresi * sabittuketimbirimfiyati   120*1.1786 = 141.4
                mysqlbaglan.Open();
                MySqlCommand sabitmasrafhesapla = new MySqlCommand(hesap1, mysqlbaglan);
                sabitmasrafhesapla.ExecuteNonQuery();
                mysqlbaglan.Close();


                //%30 sabit ısıtma hesaplama bölümü bitiş



                // %70 sabit kişisel ısıtma hesaplama bölümü
                string dogalgazfaturasitoplami2 = "UPDATE " + comboBox7.Text + " SET toplamdogalgazfaturasi = " + textBox14.Text + "";
                mysqlbaglan.Open();
                MySqlCommand dogalgazfaturatoplamihesapla2 = new MySqlCommand(dogalgazfaturasitoplami2, mysqlbaglan);
                dogalgazfaturatoplamihesapla2.ExecuteNonQuery();
                mysqlbaglan.Close();

                double toplamgazfatura2 = Convert.ToDouble(textBox14.Text); // biz giriyoruz tablo sol üst   --22.000TL
                double kisiseltuketim = toplamgazfatura2 * 70 / 100;  // tablo sol üst                      -- 15400
                double kisiseltuketimbirim = kisiseltuketim / Convert.ToInt32(label5.Text);      //tablo sağ üst           -- 0.2165
                string kisiseltuketimbirim2 = kisiseltuketimbirim.ToString().Replace(",", ".");

                string hesap2 = "UPDATE " + comboBox7.Text + " SET kisiselisinmamasrafi = " + kisiseltuketimbirim2 + " * gaztuketim";                                                                 //ortak masraf payını hesaplamak için   daireninmetrekaresi * sabittuketimbirimfiyati   120*1.1786 = 141.4
                mysqlbaglan.Open();
                MySqlCommand kisiselmasrafhesapla = new MySqlCommand(hesap2, mysqlbaglan);
                kisiselmasrafhesapla.ExecuteNonQuery();
                mysqlbaglan.Close();

                //%70 sabit kişisel ısıtma hesaplama bölümü bitiş





                //  final borc topla yazdır


                string insertQuery5 = "UPDATE " + comboBox7.Text + " SET kalorifer = sabitisinmamasrafi + kisiselisinmamasrafi";

                mysqlbaglan.Open();
                MySqlCommand final = new MySqlCommand(insertQuery5, mysqlbaglan);
                final.ExecuteNonQuery();


                if (final.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Sonraki Ay - Önceki Ay  Hesaplandı.\n Ondalık Sayıdan kurtulmak için sonuçlar 1000 ile çarpıldı. \n Küsüratlı sonuçlar yuvarlandı. \n Toplam bina metre karesi hesaplandı: " + label28.Text + " \n Toplam bina gaz tüketimi hesaplandı: " + label5.Text + "\n Sabit tüketim tutarı hesaplanıyor: " + textBox14.Text + " * 30 / 100 = " + Convert.ToInt32(textBox14.Text) * 30 / 100 + " \n Sabit tüketim birim fiyatı hesaplanıyor: " + ortaktuketim + " / " + toplammetrekare + " = " + sabittuketimbirimfiyati + " \n Kişisel tüketim tutarı hesaplanıyor: " + textBox14.Text + " * 70 / 100 = " + Convert.ToInt32(textBox14.Text) * 70 / 100 + " \n Kişisel tüketim birim fiyatı hesaplanıyor: " + kisiseltuketim + " / " + Convert.ToInt32(label5.Text) + " = " + kisiseltuketimbirim + " \n    Kalorifer hesaplama İşlemi Başarılı!!!");
                    mysqlbaglan.Close();


                    string komut = "select * from " + comboBox7.Text + "";
                    comboBox6.Text = comboBox7.Text;
                    MySqlCommand mycom = new MySqlCommand(komut, mysqlbaglan);
                    MySqlDataAdapter adap = new MySqlDataAdapter(komut, mysqlbaglan);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adap.Fill(dt);
                    dataGridView1.DataSource = dt;
                    mysqlbaglan.Open();
                    MySqlDataReader mydr = mycom.ExecuteReader();
                    mysqlbaglan.Close();
                    label18.Text = comboBox6.Text;
                }
                else
                {
                    MessageBox.Show("Kalorifer borcu hesaplama başarısız oldu.");
                    mysqlbaglan.Close();
                }

                button2.Enabled = true;
                button4.Enabled = true;
                button12.Enabled = true;
                button11.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button13.Enabled = true;

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

        private void button9_Click_1(object sender, EventArgs e)
        {


            if (comboBox3.Text == "")
            {
                MessageBox.Show("Lütfen Ay/yıl seçiniz.");
                return;
            }

            else if (textBox9.Text == "")
            {
                MessageBox.Show("Lütfen blok no giriniz.");
                return;
            }

            else if (comboBox5.Text == "")
            {
                MessageBox.Show("Lütfen blok seçiniz.");
                return;
            }

            else if (textBox7.Text == "")
            {
                MessageBox.Show("Lütfen borç miktarı giriniz.");
                return;
            }

            int a;
            string insertQuery = "SELECT aidat FROM " + comboBox3.Text + " WHERE daire='" + this.textBox9.Text + "' and blok='" + this.comboBox5.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command11 = new MySqlCommand(insertQuery, mysqlbaglan);
            MySqlDataReader myReader;
            myReader = command11.ExecuteReader();
            while (myReader.Read())
            {
                label26.Text = myReader[0].ToString();

            }
            a = Convert.ToInt32(label26.Text) + Convert.ToInt32(textBox7.Text);
            Task.Delay(1000).Wait();
            mysqlbaglan.Close();






            string insertQuery11 = "update " + comboBox3.Text + " set aidat='" + a + "' where daire='" + this.textBox9.Text + "' and blok = '" + comboBox5.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command = new MySqlCommand(insertQuery11, mysqlbaglan);
            try
            {
                if (command.ExecuteNonQuery() >= 1)
                {
                    mysqlbaglan.Close();
                    MessageBox.Show("Aidat Borcu Başarılı Şekilde Eklendi.");
                }
                else
                {
                    MessageBox.Show("Aidat Borcu Ekleme Başarısız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mysqlbaglan.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (comboBox3.Text == "")
            {
                MessageBox.Show("Lütfen Ay/yıl seçiniz.");
                return;
            }

            else if (textBox9.Text == "")
            {
                MessageBox.Show("Lütfen blok no giriniz.");
                return;
            }

            else if (comboBox5.Text == "")
            {
                MessageBox.Show("Lütfen blok seçiniz.");
                return;
            }

            else if (textBox7.Text == "")
            {
                MessageBox.Show("Lütfen borç miktarı giriniz.");
                return;
            }


            int a;
            string insertQuery = "SELECT aidat FROM " + comboBox3.Text + " WHERE daire='" + this.textBox9.Text + "' and blok='" + this.comboBox5.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, mysqlbaglan);
            MySqlDataReader myReader;
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                label26.Text = myReader[0].ToString();

            }
            a = Convert.ToInt32(label26.Text) - Convert.ToInt32(textBox7.Text);
            Task.Delay(1000).Wait();
            mysqlbaglan.Close();


            string insertQuery1 = "update " + comboBox3.Text + " set aidat='" + a + "' where daire='" + this.textBox9.Text + "' and blok = '" + comboBox5.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command1 = new MySqlCommand(insertQuery1, mysqlbaglan);
            try
            {
                if (command1.ExecuteNonQuery() >= 1)
                {
                    mysqlbaglan.Close();
                    MessageBox.Show("Aidat Borcu Başarılı Şekilde SİLİNDİ!");
                }
                else
                {
                    MessageBox.Show("Aidat Borcu Ekleme Başarısız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mysqlbaglan.Close();
            }


        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.Text != "" && textBox7.Text != "")
                {
                    string asd = "UPDATE " + comboBox3.Text + " SET aidat = '" + textBox7.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand command = new MySqlCommand(asd, mysqlbaglan);
                    if (command.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Bütün dairelerin aylık aidat borcu güncellendi.");
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        MessageBox.Show("Aidat Borcu Ekleme Başarısız");
                        mysqlbaglan.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen önce ay-yıl ve tutarı girin.");
                }
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mysqlbaglan.Close();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();
                }
            }
            /* works
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);


            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            */

        }

        private void button12_Click_1(object sender, EventArgs e)
        {

            if (comboBox4.Text == "")
            {
                MessageBox.Show("Lütfen önce ay-yıl seçin.");
                return;
            }
            else if (textBox15.Text == "")
            {
                MessageBox.Show("Lütfen daire no giriniz.");
                return;
            }
            else if (comboBox8.Text == "")
            {
                MessageBox.Show("Lütfen önce blok seçiniz.");
                return;
            }
            else if (textBox8.Text == "")
            {
                MessageBox.Show("Lütfen önce borç tutarını giriniz.");
                return;
            }


            int a;
            string insertQuery = "SELECT ekborc FROM " + comboBox4.Text + " WHERE daire='" + this.textBox15.Text + "' and blok='" + this.comboBox8.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command11 = new MySqlCommand(insertQuery, mysqlbaglan);
            MySqlDataReader myReader;
            myReader = command11.ExecuteReader();
            while (myReader.Read())
            {
                label26.Text = myReader[0].ToString();

            }
            a = Convert.ToInt32(label26.Text) + Convert.ToInt32(textBox8.Text);
            Task.Delay(1000).Wait();
            mysqlbaglan.Close();



            string insertQuery11 = "update " + comboBox4.Text + " set ekborc='" + a + "' where daire='" + this.textBox15.Text + "' and blok = '" + comboBox8.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command = new MySqlCommand(insertQuery11, mysqlbaglan);
            try
            {
                if (command.ExecuteNonQuery() >= 1)
                {
                    mysqlbaglan.Close();
                    MessageBox.Show("EkBorç Borcu Başarılı Şekilde Eklendi.");
                }
                else
                {
                    MessageBox.Show("EkBorç Borcu Ekleme Başarısız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mysqlbaglan.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "")
            {
                MessageBox.Show("Lütfen önce ay-yıl seçin.");
                return;
            }
            else if (textBox15.Text == "")
            {
                MessageBox.Show("Lütfen daire no giriniz.");
                return;
            }
            else if (comboBox8.Text == "")
            {
                MessageBox.Show("Lütfen önce blok seçiniz.");
                return;
            }
            else if (textBox8.Text == "")
            {
                MessageBox.Show("Lütfen önce borç tutarını giriniz.");
                return;
            }


            int a;
            string insertQuery = "SELECT ekborc FROM " + comboBox4.Text + " WHERE daire='" + this.textBox15.Text + "' and blok='" + this.comboBox8.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, mysqlbaglan);
            MySqlDataReader myReader;
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                label26.Text = myReader[0].ToString();

            }
            a = Convert.ToInt32(label26.Text) - Convert.ToInt32(textBox8.Text);
            Task.Delay(1000).Wait();
            mysqlbaglan.Close();


            string insertQuery1 = "update " + comboBox4.Text + " set ekborc='" + a + "' where daire='" + this.textBox15.Text + "' and blok = '" + comboBox8.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command1 = new MySqlCommand(insertQuery1, mysqlbaglan);
            try
            {
                if (command1.ExecuteNonQuery() >= 1)
                {
                    mysqlbaglan.Close();
                    MessageBox.Show("Aidat Borcu Başarılı Şekilde Eklendi.");
                }
                else
                {
                    MessageBox.Show("Aidat Borcu Ekleme Başarısız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mysqlbaglan.Close();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Text = comboBox7.Text;
            comboBox3.Text = comboBox7.Text;
            comboBox9.Text = comboBox7.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox15.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                textBox15.Text = textBox15.Text.Remove(textBox15.Text.Length - 1);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox9.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                textBox9.Text = textBox9.Text.Remove(textBox9.Text.Length - 1);
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox10.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                textBox10.Text = textBox10.Text.Remove(textBox10.Text.Length - 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox9.Text == "")
            {
                MessageBox.Show("Lütfen önce AY-YIL seçiniz.");
                return;
            }
            else if (comboBox10.Text == "")
            {
                MessageBox.Show("Lütfen önce BLOK seçiniz");
                return;
            }
            else if (textBox18.Text == "")
            {
                MessageBox.Show("Lütfen daire numarası giriniz.");
                return;
            }








            string insertQuery1 = "update " + comboBox9.Text + " set oncekiayGAZ ='" + textBox19.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command1 = new MySqlCommand(insertQuery1, mysqlbaglan);
            try
            {
                if (command1.ExecuteNonQuery() >= 1)
                {
                    mysqlbaglan.Close();
                    MessageBox.Show("Güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarısız");
                    mysqlbaglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mysqlbaglan.Close();
            }




        }


        private void button13_Click_1(object sender, EventArgs e)
        {

            if (comboBox9.Text == "")
            {
                MessageBox.Show("Lütfen önce AY-YIL seçiniz.");
                return;
            }
            else if (comboBox10.Text == "")
            {
                MessageBox.Show("Lütfen önce BLOK seçiniz");
                return;
            }
            else if (textBox18.Text == "")
            {
                MessageBox.Show("Lütfen daire numarası giriniz.");
                return;
            }








            string insertQuery1 = "update " + comboBox9.Text + " set sonrakiayGAZ ='" + textBox20.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command1 = new MySqlCommand(insertQuery1, mysqlbaglan);
            try
            {
                if (command1.ExecuteNonQuery() >= 1)
                {
                    mysqlbaglan.Close();
                    textBox20.Clear();
                    MessageBox.Show("Güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarısız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mysqlbaglan.Close();
            }

            if (comboBox6.Text == "")
            {
                return;
            }
            else
            {
                string komut = "select * from " + comboBox6.Text + "";
                MySqlCommand mycom = new MySqlCommand(komut, mysqlbaglan);
                MySqlDataAdapter adap = new MySqlDataAdapter(komut, mysqlbaglan);
                System.Data.DataTable dt = new System.Data.DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
                mysqlbaglan.Open();
                MySqlDataReader mydr = mycom.ExecuteReader();
                mysqlbaglan.Close();
                label18.Text = comboBox6.Text;
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {



            if (comboBox9.Text == "")
            {
                MessageBox.Show("Lütfen önce AY-YIL seçiniz.");
                return;
            }
            else if (comboBox10.Text == "")
            {
                MessageBox.Show("Lütfen önce BLOK seçiniz");
                return;
            }
            else if (textBox18.Text == "")
            {
                MessageBox.Show("Lütfen daire numarası giriniz.");
                return;
            }








            string insertQuery1 = "update " + comboBox9.Text + " set oncekiaySu ='" + textBox22.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command1 = new MySqlCommand(insertQuery1, mysqlbaglan);
            try
            {
                if (command1.ExecuteNonQuery() >= 1)
                {
                    mysqlbaglan.Close();
                    MessageBox.Show("Güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarısız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mysqlbaglan.Close();
            }


        }

        private void button15_Click(object sender, EventArgs e)
        {


            if (comboBox9.Text == "")
            {
                MessageBox.Show("Lütfen önce AY-YIL seçiniz.");
                return;
            }
            else if (comboBox10.Text == "")
            {
                MessageBox.Show("Lütfen önce BLOK seçiniz");
                return;
            }
            else if (textBox18.Text == "")
            {
                MessageBox.Show("Lütfen daire numarası giriniz.");
                return;
            }








            string insertQuery1 = "update " + comboBox9.Text + " set sonrakiaySu ='" + textBox21.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command1 = new MySqlCommand(insertQuery1, mysqlbaglan);
            try
            {
                if (command1.ExecuteNonQuery() >= 1)
                {
                    mysqlbaglan.Close();
                    textBox21.Clear();
                    MessageBox.Show("Güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarısız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mysqlbaglan.Close();
            }

            if (comboBox6.Text == "")
            {
                return;
            }
            else
            {
                string komut = "select * from " + comboBox6.Text + "";
                MySqlCommand mycom = new MySqlCommand(komut, mysqlbaglan);
                MySqlDataAdapter adap = new MySqlDataAdapter(komut, mysqlbaglan);
                System.Data.DataTable dt = new System.Data.DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
                mysqlbaglan.Open();
                MySqlDataReader mydr = mycom.ExecuteReader();
                mysqlbaglan.Close();
                label18.Text = comboBox6.Text;
            }

        }

        private void button16_Click_1(object sender, EventArgs e)
        {



            if (comboBox9.Text == "")
            {
                MessageBox.Show("Lütfen önce AY-YIL seçiniz.");
                return;
            }
            else if (comboBox10.Text == "")
            {
                MessageBox.Show("Lütfen önce BLOK seçiniz");
                return;
            }
            else if (textBox18.Text == "")
            {
                MessageBox.Show("Lütfen daire numarası giriniz.");
                return;
            }








            string insertQuery1 = "UPDATE ocak2022 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery2 = "UPDATE subat2022 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery3 = "UPDATE mart2022 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery4 = "UPDATE nisan2022 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery5 = "UPDATE mayis2022 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery6 = "UPDATE haziran2022 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery7 = "UPDATE temmuz2022 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery8 = "UPDATE ağustos2022 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery9 = "UPDATE eylül2022 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery10 = "UPDATE ekim2022 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery11 = "UPDATE kasim2022 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery12 = "UPDATE aralik2022 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery13 = "UPDATE ocak2023 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery14 = "UPDATE subat2023 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery15 = "UPDATE mart2023 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery16 = "UPDATE nisan2023 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery17 = "UPDATE mayis2023 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery18 = "UPDATE haziran2023 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery19 = "UPDATE temmuz2023 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery20 = "UPDATE ağustos2023 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery21 = "UPDATE eylül2023 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery22 = "UPDATE ekim2023 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery23 = "UPDATE kasim2023 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            string insertQuery24 = "UPDATE aralik2023 set isim ='" + textBox23.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command1 = new MySqlCommand(insertQuery1, mysqlbaglan);
            MySqlCommand command2 = new MySqlCommand(insertQuery2, mysqlbaglan);
            MySqlCommand command3 = new MySqlCommand(insertQuery3, mysqlbaglan);
            MySqlCommand command4 = new MySqlCommand(insertQuery4, mysqlbaglan);
            MySqlCommand command5 = new MySqlCommand(insertQuery5, mysqlbaglan);
            MySqlCommand command6 = new MySqlCommand(insertQuery6, mysqlbaglan);
            MySqlCommand command7 = new MySqlCommand(insertQuery7, mysqlbaglan);
            MySqlCommand command8 = new MySqlCommand(insertQuery8, mysqlbaglan);
            MySqlCommand command9 = new MySqlCommand(insertQuery9, mysqlbaglan);
            MySqlCommand command10 = new MySqlCommand(insertQuery10, mysqlbaglan);
            MySqlCommand command11 = new MySqlCommand(insertQuery11, mysqlbaglan);
            MySqlCommand command12 = new MySqlCommand(insertQuery12, mysqlbaglan);
            MySqlCommand command13 = new MySqlCommand(insertQuery13, mysqlbaglan);
            MySqlCommand command14 = new MySqlCommand(insertQuery14, mysqlbaglan);
            MySqlCommand command15 = new MySqlCommand(insertQuery15, mysqlbaglan);
            MySqlCommand command16 = new MySqlCommand(insertQuery16, mysqlbaglan);
            MySqlCommand command17 = new MySqlCommand(insertQuery17, mysqlbaglan);
            MySqlCommand command18 = new MySqlCommand(insertQuery18, mysqlbaglan);
            MySqlCommand command19 = new MySqlCommand(insertQuery19, mysqlbaglan);
            MySqlCommand command20 = new MySqlCommand(insertQuery20, mysqlbaglan);
            MySqlCommand command21 = new MySqlCommand(insertQuery21, mysqlbaglan);
            MySqlCommand command22 = new MySqlCommand(insertQuery22, mysqlbaglan);
            MySqlCommand command23 = new MySqlCommand(insertQuery23, mysqlbaglan);
            MySqlCommand command24 = new MySqlCommand(insertQuery24, mysqlbaglan);
            command2.ExecuteNonQuery();
            command3.ExecuteNonQuery();
            command4.ExecuteNonQuery();
            command5.ExecuteNonQuery();
            command6.ExecuteNonQuery();
            command7.ExecuteNonQuery();
            command8.ExecuteNonQuery();
            command9.ExecuteNonQuery();
            command10.ExecuteNonQuery();
            command11.ExecuteNonQuery();
            command12.ExecuteNonQuery();
            command13.ExecuteNonQuery();
            command14.ExecuteNonQuery();
            command15.ExecuteNonQuery();
            command16.ExecuteNonQuery();
            command17.ExecuteNonQuery();
            command18.ExecuteNonQuery();
            command19.ExecuteNonQuery();
            command20.ExecuteNonQuery();
            command21.ExecuteNonQuery();
            command22.ExecuteNonQuery();
            command23.ExecuteNonQuery();
            command24.ExecuteNonQuery();
            try
            {
                if (command1.ExecuteNonQuery() >= 1)
                {
                    mysqlbaglan.Close();
                    MessageBox.Show("Güncellendi.");
                    guncelleme();
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarısız");
                    mysqlbaglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mysqlbaglan.Close();
            }




        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox18.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                textBox18.Text = textBox18.Text.Remove(textBox18.Text.Length - 1);
            }

            if (comboBox9.Text != "" && textBox18.Text != "" && comboBox10.Text != "")
            {

                textBox2.Text = textBox18.Text;
                comboBox1.Text = comboBox10.Text;


                string isimsorgu = "SELECT isim FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";
                string telsorgu = "SELECT tel FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";
                string toplamborcsorgu = "SELECT toplamborc FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";
                string katsorgu = "SELECT kat FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";




                //isim
                mysqlbaglan.Open();
                MySqlCommand command1 = new MySqlCommand(isimsorgu, mysqlbaglan);
                MySqlDataReader myreader;
                myreader = command1.ExecuteReader();
                if (myreader.Read() == true)
                {
                    textBox1.Text = myreader[0].ToString();
                }
                else
                {
                    textBox1.Text = "HATA";
                }
                mysqlbaglan.Close();


                //tel
                mysqlbaglan.Open();
                MySqlCommand command2 = new MySqlCommand(telsorgu, mysqlbaglan);
                MySqlDataReader myreader2;
                myreader2 = command2.ExecuteReader();
                if (myreader2.Read() == true)
                {
                    textBox3.Text = myreader2[0].ToString();
                }
                else
                {
                    textBox3.Text = "HATA";
                }
                mysqlbaglan.Close();

                //toplamboruc
                mysqlbaglan.Open();
                MySqlCommand command3 = new MySqlCommand(toplamborcsorgu, mysqlbaglan);
                MySqlDataReader myreader3;
                myreader3 = command3.ExecuteReader();
                if (myreader3.Read() == true)
                {
                    textBox5.Text = myreader3[0].ToString();
                }
                else
                {
                    textBox5.Text = "HATA";
                }
                mysqlbaglan.Close();


                //KATSORGU
                mysqlbaglan.Open();
                MySqlCommand command4 = new MySqlCommand(katsorgu, mysqlbaglan);
                MySqlDataReader myreader4;
                myreader4 = command4.ExecuteReader();

                if (myreader4.Read() == true)
                {
                    textBox4.Text = myreader4[0].ToString();
                }
                else
                {
                    textBox4.Text = "HATA";
                }
                mysqlbaglan.Close();





                if (comboBox9.Text == "subat2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ocak2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                }


                if (comboBox9.Text == "subat2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ocak2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "subat2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ocak2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "mart2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM subat2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "mart2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM subat2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "nisan2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM mart2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "nisan2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM mart2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "mayis2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM nisan2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "mayis2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM nisan2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "haziran2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM mayis2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "haziran2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM mayis2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "temmuz2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM haziran2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "temmuz2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM haziran2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "ağustos2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM temmuz2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ağustos2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM temmuz2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "eylül2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ağustos2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "eylül2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ağustos2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ekim2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM eylül2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ekim2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM eylül2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "kasim2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ekim2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "kasim2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ekim2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "aralik2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM kasim2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "aralik2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM kasim2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "ocak2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM aralik2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ocak2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM aralik2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "subat2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ocak2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "subat2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ocak2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "mart2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM subat2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "mart2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM subat2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "nisan2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM mart2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "nisan2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM mart2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "mayis2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM nisan2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "mayis2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM nisan2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "haziran2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM mayis2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "haziran2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM mayis2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "temmuz2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM haziran2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "temmuz2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM haziran2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "ağustos2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM temmuz2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ağustos2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM temmuz2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "eylül2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ağustos2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "eylül2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ağustos2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ekim2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM eylül2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ekim2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM eylül2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "kasim2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ekim2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "kasim2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ekim2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "aralik2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM kasim2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "aralik2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM kasim2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "ocak2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM aralik2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                //bitti sonunda :D
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string aa = "UPDATE ağustos2022 JOIN temmuz2022 ON ağustos2022.isim = temmuz2022.isim SET ağustos2022.devredenborc = temmuz2022.toplamborc";
            string bb = "UPDATE eylül2022 JOIN ağustos2022 ON eylül2022.isim = ağustos2022.isim SET eylül2022.devredenborc = ağustos2022.toplamborc";
            string cc = "UPDATE ekim2022 JOIN eylül2022 ON ekim2022.isim = eylül2022.isim SET ekim2022.devredenborc = eylül2022.toplamborc";
            string dd = "UPDATE kasim2022 JOIN ekim2022 ON kasim2022.isim = ekim2022.isim SET kasim2022.devredenborc = ekim2022.toplamborc";
            string ee = "UPDATE aralik2022 JOIN kasim2022 ON aralik2022.isim = kasim2022.isim SET aralik2022.devredenborc = kasim2022.toplamborc";
            string ff = "UPDATE ocak2023 JOIN aralik2022 ON ocak2023.isim = aralik2022.isim SET ocak2023.devredenborc = aralik2022.toplamborc";
            string gg = "UPDATE subat2023 JOIN ocak2023 ON subat2023.isim = ocak2023.isim SET subat2023.devredenborc = ocak2023.toplamborc";
            string hh = "UPDATE mart2023 JOIN subat2023 ON mart2023.isim = subat2023.isim SET mart2023.devredenborc = subat2023.toplamborc";
            string jj = "UPDATE nisan2023 JOIN mart2023 ON nisan2023.isim = mart2023.isim SET nisan2023.devredenborc = mart2023.toplamborc";
            string kk = "UPDATE mayis2023 JOIN nisan2023 ON mayis2023.isim = nisan2023.isim SET mayis2023.devredenborc = nisan2023.toplamborc";
            string ll = "UPDATE haziran2023 JOIN mayis2023 ON haziran2023.isim = mayis2023.isim SET haziran2023.devredenborc = mayis2023.toplamborc";
            string ww = "UPDATE temmuz2023 JOIN haziran2023 ON temmuz2023.isim = haziran2023.isim SET temmuz2023.devredenborc = haziran2023.toplamborc";
            string oo = "UPDATE ağustos2023 JOIN temmuz2023 ON ağustos2023.isim = temmuz2023.isim SET ağustos2023.devredenborc = temmuz2023.toplamborc";
            string rr = "UPDATE eylül2023 JOIN ağustos2023 ON eylül2023.isim = ağustos2023.isim SET eylül2023.devredenborc = ağustos2023.toplamborc";
            string tt = "UPDATE ekim2023 JOIN eylül2023 ON ekim2023.isim = eylül2023.isim SET ekim2023.devredenborc = eylül2023.toplamborc";
            string yy = "UPDATE kasim2023 JOIN ekim2023 ON kasim2023.isim = ekim2023.isim SET kasim2023.devredenborc = ekim2023.toplamborc";
            string uu = "UPDATE aralik2023 JOIN kasim2023 ON aralik2023.isim = kasim2023.isim SET aralik2023.devredenborc = kasim2023.toplamborc";
            mysqlbaglan.Open();
            MySqlCommand aq = new MySqlCommand(aa, mysqlbaglan);
            MySqlCommand bq = new MySqlCommand(bb, mysqlbaglan);
            MySqlCommand cq = new MySqlCommand(cc, mysqlbaglan);
            MySqlCommand dq = new MySqlCommand(dd, mysqlbaglan);
            MySqlCommand eq = new MySqlCommand(ee, mysqlbaglan);
            MySqlCommand fq = new MySqlCommand(ff, mysqlbaglan);
            MySqlCommand gq = new MySqlCommand(gg, mysqlbaglan);
            MySqlCommand hq = new MySqlCommand(hh, mysqlbaglan);
            MySqlCommand iq = new MySqlCommand(jj, mysqlbaglan);
            MySqlCommand kq = new MySqlCommand(kk, mysqlbaglan);
            MySqlCommand lq = new MySqlCommand(ll, mysqlbaglan);
            MySqlCommand mq = new MySqlCommand(ww, mysqlbaglan);
            MySqlCommand nq = new MySqlCommand(oo, mysqlbaglan);
            MySqlCommand oq = new MySqlCommand(rr, mysqlbaglan);
            MySqlCommand pq = new MySqlCommand(tt, mysqlbaglan);
            MySqlCommand rq = new MySqlCommand(yy, mysqlbaglan);
            MySqlCommand sq = new MySqlCommand(uu, mysqlbaglan);
            aq.ExecuteNonQuery();
            bq.ExecuteNonQuery();
            cq.ExecuteNonQuery();
            dq.ExecuteNonQuery();
            eq.ExecuteNonQuery();
            fq.ExecuteNonQuery();
            gq.ExecuteNonQuery();
            hq.ExecuteNonQuery();
            iq.ExecuteNonQuery();
            kq.ExecuteNonQuery();
            lq.ExecuteNonQuery();
            mq.ExecuteNonQuery();
            nq.ExecuteNonQuery();
            aq.ExecuteNonQuery();
            oq.ExecuteNonQuery();
            pq.ExecuteNonQuery();
            rq.ExecuteNonQuery();
            sq.ExecuteNonQuery();
            mysqlbaglan.Close();
            if (comboBox6.Text == "")
            {
                MessageBox.Show("Lütfen önce sol aşağı taraftan ay/yıl seçiniz.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("kalorifer - sıcaksu - ekborc - aidat - devredenborc hepsi toplanıp toplamborclar hesaplanacak", "Toplam Borçları Hesapla", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string insertQuery1 = "update " + comboBox6.Text + " set toplamborc =  sicaksu + kalorifer + aidat + ekborc + devredenborc";
                mysqlbaglan.Open();
                MySqlCommand command1 = new MySqlCommand(insertQuery1, mysqlbaglan);
                try
                {
                    if (command1.ExecuteNonQuery() >= 1)
                    {
                        mysqlbaglan.Close();
                        MessageBox.Show("Toplam Borç Hesaplandı.");
                    }
                    else
                    {
                        MessageBox.Show("Toplam Borç Hesaplaması BAŞARISIZ!");
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

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }



        //burdayım
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox9.Text != "" && textBox18.Text != "" && comboBox10.Text != "")
            {

                textBox2.Text = textBox18.Text;
                comboBox1.Text = comboBox10.Text;


                string isimsorgu = "SELECT isim FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";
                string telsorgu = "SELECT tel FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";
                string toplamborcsorgu = "SELECT toplamborc FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";
                string katsorgu = "SELECT kat FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";




                //isim
                mysqlbaglan.Open();
                MySqlCommand command1 = new MySqlCommand(isimsorgu, mysqlbaglan);
                MySqlDataReader myreader;
                myreader = command1.ExecuteReader();
                if (myreader.Read() == true)
                {
                    textBox1.Text = myreader[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox1.Text = "HATA";
                }
                mysqlbaglan.Close();


                //tel
                mysqlbaglan.Open();
                MySqlCommand command2 = new MySqlCommand(telsorgu, mysqlbaglan);
                MySqlDataReader myreader2;
                myreader2 = command2.ExecuteReader();
                if (myreader2.Read() == true)
                {
                    textBox3.Text = myreader2[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox3.Text = "HATA";
                }
                mysqlbaglan.Close();

                //toplamboruc
                mysqlbaglan.Open();
                MySqlCommand command3 = new MySqlCommand(toplamborcsorgu, mysqlbaglan);
                MySqlDataReader myreader3;
                myreader3 = command3.ExecuteReader();
                if (myreader3.Read() == true)
                {
                    textBox5.Text = myreader3[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox5.Text = "HATA";
                }
                mysqlbaglan.Close();


                //KATSORGU
                mysqlbaglan.Open();
                MySqlCommand command4 = new MySqlCommand(katsorgu, mysqlbaglan);
                MySqlDataReader myreader4;
                myreader4 = command4.ExecuteReader();

                if (myreader4.Read() == true)
                {
                    textBox4.Text = myreader4[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox4.Text = "HATA";
                }
                mysqlbaglan.Close();


                if (comboBox9.Text == "subat2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ocak2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                }


                if (comboBox9.Text == "subat2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ocak2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "subat2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ocak2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "mart2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM subat2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "mart2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM subat2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "nisan2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM mart2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "nisan2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM mart2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "mayis2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM nisan2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "mayis2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM nisan2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "haziran2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM mayis2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "haziran2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM mayis2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "temmuz2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM haziran2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "temmuz2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM haziran2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "ağustos2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM temmuz2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ağustos2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM temmuz2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "eylül2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ağustos2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "eylül2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ağustos2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ekim2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM eylül2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ekim2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM eylül2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "kasim2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ekim2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "kasim2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ekim2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "aralik2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM kasim2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "aralik2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM kasim2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "ocak2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM aralik2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ocak2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM aralik2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "subat2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ocak2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "subat2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ocak2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "mart2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM subat2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "mart2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM subat2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "nisan2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM mart2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "nisan2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM mart2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "mayis2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM nisan2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "mayis2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM nisan2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "haziran2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM mayis2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "haziran2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM mayis2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "temmuz2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM haziran2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "temmuz2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM haziran2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "ağustos2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM temmuz2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ağustos2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM temmuz2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "eylül2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ağustos2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "eylül2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ağustos2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ekim2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM eylül2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ekim2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM eylül2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "kasim2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ekim2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "kasim2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ekim2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "aralik2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM kasim2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "aralik2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM kasim2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "ocak2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM aralik2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                //bitti sonunda :D

            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox9.Text != "" && textBox18.Text != "" && comboBox10.Text != "")
            {

                textBox2.Text = textBox18.Text;
                comboBox1.Text = comboBox10.Text;


                string isimsorgu = "SELECT isim FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";
                string telsorgu = "SELECT tel FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";
                string toplamborcsorgu = "SELECT toplamborc FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";
                string katsorgu = "SELECT kat FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";




                //isim
                mysqlbaglan.Open();
                MySqlCommand command1 = new MySqlCommand(isimsorgu, mysqlbaglan);
                MySqlDataReader myreader;
                myreader = command1.ExecuteReader();
                if (myreader.Read() == true)
                {
                    textBox1.Text = myreader[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox1.Text = "HATA";
                }
                mysqlbaglan.Close();


                //tel
                mysqlbaglan.Open();
                MySqlCommand command2 = new MySqlCommand(telsorgu, mysqlbaglan);
                MySqlDataReader myreader2;
                myreader2 = command2.ExecuteReader();
                if (myreader2.Read() == true)
                {
                    textBox3.Text = myreader2[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox3.Text = "HATA";
                }
                mysqlbaglan.Close();

                //toplamboruc
                mysqlbaglan.Open();
                MySqlCommand command3 = new MySqlCommand(toplamborcsorgu, mysqlbaglan);
                MySqlDataReader myreader3;
                myreader3 = command3.ExecuteReader();
                if (myreader3.Read() == true)
                {
                    textBox5.Text = myreader3[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox5.Text = "HATA";
                }
                mysqlbaglan.Close();


                //KATSORGU
                mysqlbaglan.Open();
                MySqlCommand command4 = new MySqlCommand(katsorgu, mysqlbaglan);
                MySqlDataReader myreader4;
                myreader4 = command4.ExecuteReader();

                if (myreader4.Read() == true)
                {
                    textBox4.Text = myreader4[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox4.Text = "HATA";
                }
                mysqlbaglan.Close();



                //aklında bölümü
                //
                //
                //


                if (comboBox9.Text == "subat2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ocak2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "subat2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ocak2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "mart2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM subat2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "mart2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM subat2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "nisan2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM mart2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "nisan2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM mart2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "mayis2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM nisan2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "mayis2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM nisan2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "haziran2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM mayis2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "haziran2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM mayis2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "temmuz2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM haziran2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "temmuz2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM haziran2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "ağustos2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM temmuz2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ağustos2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM temmuz2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "eylül2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ağustos2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "eylül2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ağustos2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ekim2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM eylül2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ekim2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM eylül2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "kasim2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ekim2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "kasim2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ekim2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "aralik2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM kasim2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "aralik2022" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM kasim2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "ocak2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM aralik2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ocak2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM aralik2022 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "subat2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ocak2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "subat2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ocak2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "mart2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM subat2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "mart2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM subat2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "nisan2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM mart2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "nisan2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM mart2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "mayis2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM nisan2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "mayis2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM nisan2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "haziran2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM mayis2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "haziran2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM mayis2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "temmuz2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM haziran2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "temmuz2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM haziran2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "ağustos2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM temmuz2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ağustos2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM temmuz2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                if (comboBox9.Text == "eylül2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ağustos2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "eylül2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ağustos2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ekim2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM eylül2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "ekim2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM eylül2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "kasim2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM ekim2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "kasim2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM ekim2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }

                if (comboBox9.Text == "aralik2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM kasim2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }



                if (comboBox9.Text == "aralik2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiaySU FROM kasim2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox22.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox22.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }




                if (comboBox9.Text == "ocak2023" && textBox18.Text != "" && comboBox10.Text != "")
                {
                    string oncekiaykalorifer = "SELECT sonrakiayGAZ FROM aralik2023 WHERE daire = '" + textBox18.Text + "' AND blok = '" + comboBox10.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand a = new MySqlCommand(oncekiaykalorifer, mysqlbaglan);
                    MySqlDataReader reader1;
                    reader1 = a.ExecuteReader();

                    if (reader1.Read() == true)
                    {
                        textBox19.Text = reader1[0].ToString();
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        textBox19.Text = "HATA";
                    }
                    mysqlbaglan.Close();
                }


                //bitti sonunda :D




            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && textBox10.Text != "" && comboBox11.Text != "")
            {

                textBox2.Text = textBox10.Text;
                comboBox1.Text = comboBox11.Text;


                string isimsorgu = "SELECT isim FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";
                string telsorgu = "SELECT tel FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";
                string toplamborcsorgu = "SELECT toplamborc FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";
                string katsorgu = "SELECT kat FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";




                //isim
                mysqlbaglan.Open();
                MySqlCommand command1 = new MySqlCommand(isimsorgu, mysqlbaglan);
                MySqlDataReader myreader;
                myreader = command1.ExecuteReader();
                if (myreader.Read() == true)
                {
                    textBox1.Text = myreader[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox1.Text = "HATA";
                }
                mysqlbaglan.Close();


                //tel
                mysqlbaglan.Open();
                MySqlCommand command2 = new MySqlCommand(telsorgu, mysqlbaglan);
                MySqlDataReader myreader2;
                myreader2 = command2.ExecuteReader();
                if (myreader2.Read() == true)
                {
                    textBox3.Text = myreader2[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox3.Text = "HATA";
                }
                mysqlbaglan.Close();

                //toplamboruc
                mysqlbaglan.Open();
                MySqlCommand command3 = new MySqlCommand(toplamborcsorgu, mysqlbaglan);
                MySqlDataReader myreader3;
                myreader3 = command3.ExecuteReader();
                if (myreader3.Read() == true)
                {
                    textBox5.Text = myreader3[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox5.Text = "HATA";
                }
                mysqlbaglan.Close();


                //KATSORGU
                mysqlbaglan.Open();
                MySqlCommand command4 = new MySqlCommand(katsorgu, mysqlbaglan);
                MySqlDataReader myreader4;
                myreader4 = command4.ExecuteReader();

                if (myreader4.Read() == true)
                {
                    textBox4.Text = myreader4[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox4.Text = "HATA";
                }
                mysqlbaglan.Close();
            }
        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && textBox10.Text != "" && comboBox11.Text != "")
            {

                textBox2.Text = textBox10.Text;
                comboBox1.Text = comboBox11.Text;


                string isimsorgu = "SELECT isim FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";
                string telsorgu = "SELECT tel FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";
                string toplamborcsorgu = "SELECT toplamborc FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";
                string katsorgu = "SELECT kat FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";




                //isim
                mysqlbaglan.Open();
                MySqlCommand command1 = new MySqlCommand(isimsorgu, mysqlbaglan);
                MySqlDataReader myreader;
                myreader = command1.ExecuteReader();
                if (myreader.Read() == true)
                {
                    textBox1.Text = myreader[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox1.Text = "HATA";
                }
                mysqlbaglan.Close();


                //tel
                mysqlbaglan.Open();
                MySqlCommand command2 = new MySqlCommand(telsorgu, mysqlbaglan);
                MySqlDataReader myreader2;
                myreader2 = command2.ExecuteReader();
                if (myreader2.Read() == true)
                {
                    textBox3.Text = myreader2[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox3.Text = "HATA";
                }
                mysqlbaglan.Close();

                //toplamboruc
                mysqlbaglan.Open();
                MySqlCommand command3 = new MySqlCommand(toplamborcsorgu, mysqlbaglan);
                MySqlDataReader myreader3;
                myreader3 = command3.ExecuteReader();
                if (myreader3.Read() == true)
                {
                    textBox5.Text = myreader3[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox5.Text = "HATA";
                }
                mysqlbaglan.Close();


                //KATSORGU
                mysqlbaglan.Open();
                MySqlCommand command4 = new MySqlCommand(katsorgu, mysqlbaglan);
                MySqlDataReader myreader4;
                myreader4 = command4.ExecuteReader();

                if (myreader4.Read() == true)
                {
                    textBox4.Text = myreader4[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox4.Text = "HATA";
                }
                mysqlbaglan.Close();
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && textBox10.Text != "" && comboBox11.Text != "")
            {

                textBox2.Text = textBox10.Text;
                comboBox1.Text = comboBox11.Text;


                string isimsorgu = "SELECT isim FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";
                string telsorgu = "SELECT tel FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";
                string toplamborcsorgu = "SELECT toplamborc FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";
                string katsorgu = "SELECT kat FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";




                //isim
                mysqlbaglan.Open();
                MySqlCommand command1 = new MySqlCommand(isimsorgu, mysqlbaglan);
                MySqlDataReader myreader;
                myreader = command1.ExecuteReader();
                if (myreader.Read() == true)
                {
                    textBox1.Text = myreader[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox1.Text = "HATA";
                }
                mysqlbaglan.Close();


                //tel
                mysqlbaglan.Open();
                MySqlCommand command2 = new MySqlCommand(telsorgu, mysqlbaglan);
                MySqlDataReader myreader2;
                myreader2 = command2.ExecuteReader();
                if (myreader2.Read() == true)
                {
                    textBox3.Text = myreader2[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox3.Text = "HATA";
                }
                mysqlbaglan.Close();

                //toplamboruc
                mysqlbaglan.Open();
                MySqlCommand command3 = new MySqlCommand(toplamborcsorgu, mysqlbaglan);
                MySqlDataReader myreader3;
                myreader3 = command3.ExecuteReader();
                if (myreader3.Read() == true)
                {
                    textBox5.Text = myreader3[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox5.Text = "HATA";
                }
                mysqlbaglan.Close();


                //KATSORGU
                mysqlbaglan.Open();
                MySqlCommand command4 = new MySqlCommand(katsorgu, mysqlbaglan);
                MySqlDataReader myreader4;
                myreader4 = command4.ExecuteReader();

                if (myreader4.Read() == true)
                {
                    textBox4.Text = myreader4[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox4.Text = "HATA";
                }
                mysqlbaglan.Close();
            }
        }



        void guncelleme()
        {
            if (comboBox9.Text != "" && textBox18.Text != "" && comboBox10.Text != "")
            {

                textBox2.Text = textBox18.Text;
                comboBox1.Text = comboBox10.Text;


                string isimsorgu = "SELECT isim FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";
                string telsorgu = "SELECT tel FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";
                string toplamborcsorgu = "SELECT toplamborc FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";
                string katsorgu = "SELECT kat FROM " + comboBox9.Text + " WHERE daire = '" + textBox18.Text + "'AND blok = '" + comboBox10.Text + "'";




                //isim
                mysqlbaglan.Open();
                MySqlCommand command1 = new MySqlCommand(isimsorgu, mysqlbaglan);
                MySqlDataReader myreader;
                myreader = command1.ExecuteReader();
                if (myreader.Read() == true)
                {
                    textBox1.Text = myreader[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox1.Text = "HATA";
                }
                mysqlbaglan.Close();


                //tel
                mysqlbaglan.Open();
                MySqlCommand command2 = new MySqlCommand(telsorgu, mysqlbaglan);
                MySqlDataReader myreader2;
                myreader2 = command2.ExecuteReader();
                if (myreader2.Read() == true)
                {
                    textBox3.Text = myreader2[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox3.Text = "HATA";
                }
                mysqlbaglan.Close();

                //toplamboruc
                mysqlbaglan.Open();
                MySqlCommand command3 = new MySqlCommand(toplamborcsorgu, mysqlbaglan);
                MySqlDataReader myreader3;
                myreader3 = command3.ExecuteReader();
                if (myreader3.Read() == true)
                {
                    textBox5.Text = myreader3[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox5.Text = "HATA";
                }
                mysqlbaglan.Close();


                //KATSORGU
                mysqlbaglan.Open();
                MySqlCommand command4 = new MySqlCommand(katsorgu, mysqlbaglan);
                MySqlDataReader myreader4;
                myreader4 = command4.ExecuteReader();

                if (myreader4.Read() == true)
                {
                    textBox4.Text = myreader4[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox4.Text = "HATA";
                }
                mysqlbaglan.Close();
            }
        }






        private void button7_Click_1(object sender, EventArgs e)
        {
            if (comboBox9.Text == "")
            {
                MessageBox.Show("Lütfen önce AY-YIL seçiniz.");
                return;
            }
            else if (comboBox10.Text == "")
            {
                MessageBox.Show("Lütfen önce BLOK seçiniz");
                return;
            }
            else if (textBox18.Text == "")
            {
                MessageBox.Show("Lütfen daire numarası giriniz.");
                return;
            }

            string insertQuery1 = "update " + comboBox9.Text + " set tel ='" + textBox6.Text + "' where daire='" + this.textBox18.Text + "' and blok = '" + comboBox10.Text + "';";
            mysqlbaglan.Open();
            MySqlCommand command1 = new MySqlCommand(insertQuery1, mysqlbaglan);
            try
            {
                if (command1.ExecuteNonQuery() >= 1)
                {
                    mysqlbaglan.Close();
                    MessageBox.Show("Güncellendi.");
                    guncelleme();

                }
                else
                {
                    MessageBox.Show("Güncelleme Başarısız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mysqlbaglan.Close();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            if (comboBox2.Text == "")
            {
                MessageBox.Show("Lütfen Ay/yıl seçiniz.");
                return;
            }

            else if (textBox10.Text == "")
            {
                MessageBox.Show("Lütfen blok no giriniz.");
                return;
            }

            else if (comboBox11.Text == "")
            {
                MessageBox.Show("Lütfen blok seçiniz.");
                return;
            }

            else if (textBox11.Text == "")
            {
                MessageBox.Show("Lütfen borç miktarı giriniz.");
                return;
            }
            else
            {
                guncelleme2();
            }

            DialogResult dialogResult = MessageBox.Show("Toplam Borç Silenecek Emin misiniz?", "Toplam Borç Sil", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string insertQuery11 = "update " + comboBox2.Text + " set toplamborc = toplamborc - '" + textBox11.Text + "' where daire='" + this.textBox10.Text + "' and blok = '" + comboBox11.Text + "';";
                mysqlbaglan.Open();
                MySqlCommand command = new MySqlCommand(insertQuery11, mysqlbaglan);
                try
                {
                    if (command.ExecuteNonQuery() >= 1)
                    {
                        mysqlbaglan.Close();
                        MessageBox.Show("EkBorç Başarılı Şekilde SİLİNDİ!");
                        guncelleme2();
                    }
                    else
                    {
                        MessageBox.Show("EkBorç Ekleme Başarısız");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    mysqlbaglan.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }


          



        }




        void guncelleme2()
        {
            if (comboBox2.Text != "" && textBox10.Text != "" && comboBox11.Text != "")
            {

                textBox2.Text = textBox10.Text;
                comboBox1.Text = comboBox11.Text;


                string isimsorgu = "SELECT isim FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";
                string telsorgu = "SELECT tel FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";
                string toplamborcsorgu = "SELECT toplamborc FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";
                string katsorgu = "SELECT kat FROM " + comboBox2.Text + " WHERE daire = '" + textBox10.Text + "'AND blok = '" + comboBox11.Text + "'";




                //isim
                mysqlbaglan.Open();
                MySqlCommand command1 = new MySqlCommand(isimsorgu, mysqlbaglan);
                MySqlDataReader myreader;
                myreader = command1.ExecuteReader();
                if (myreader.Read() == true)
                {
                    textBox1.Text = myreader[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox1.Text = "HATA";
                }
                mysqlbaglan.Close();


                //tel
                mysqlbaglan.Open();
                MySqlCommand command2 = new MySqlCommand(telsorgu, mysqlbaglan);
                MySqlDataReader myreader2;
                myreader2 = command2.ExecuteReader();
                if (myreader2.Read() == true)
                {
                    textBox3.Text = myreader2[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox3.Text = "HATA";
                }
                mysqlbaglan.Close();

                //toplamboruc
                mysqlbaglan.Open();
                MySqlCommand command3 = new MySqlCommand(toplamborcsorgu, mysqlbaglan);
                MySqlDataReader myreader3;
                myreader3 = command3.ExecuteReader();
                if (myreader3.Read() == true)
                {
                    textBox5.Text = myreader3[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox5.Text = "HATA";
                }
                mysqlbaglan.Close();


                //KATSORGU
                mysqlbaglan.Open();
                MySqlCommand command4 = new MySqlCommand(katsorgu, mysqlbaglan);
                MySqlDataReader myreader4;
                myreader4 = command4.ExecuteReader();

                if (myreader4.Read() == true)
                {
                    textBox4.Text = myreader4[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox4.Text = "HATA";
                }
                mysqlbaglan.Close();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Lütfen Ay/yıl seçiniz.");
                return;
            }

            else if (textBox10.Text == "")
            {
                MessageBox.Show("Lütfen blok no giriniz.");
                return;
            }

            else if (comboBox11.Text == "")
            {
                MessageBox.Show("Lütfen blok seçiniz.");
                return;
            }

            else if (textBox11.Text == "")
            {
                MessageBox.Show("Lütfen borç miktarı giriniz.");
                return;
            }
            else
            {
                guncelleme2();
            }



            DialogResult dialogResult = MessageBox.Show("Toplam Borç Eklenecek Emin misiniz?", "Toplam Borç Ekle", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string insertQuery11 = "update " + comboBox2.Text + " set toplamborc = toplamborc + '" + textBox11.Text + "' where daire='" + this.textBox10.Text + "' and blok = '" + comboBox11.Text + "';";
                mysqlbaglan.Open();
                MySqlCommand command = new MySqlCommand(insertQuery11, mysqlbaglan);
                try
                {
                    if (command.ExecuteNonQuery() >= 1)
                    {
                        mysqlbaglan.Close();
                        MessageBox.Show("Aidat Borcu Başarılı Şekilde Eklendi.");
                        guncelleme2();
                    }
                    else
                    {
                        MessageBox.Show("Aidat Borcu Ekleme Başarısız");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    mysqlbaglan.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }






        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (comboBox6.Text == "")
            {

                MessageBox.Show("Lütfen önce yan taraftan bir ay-yıl seçiniz.");
                return;
            }
            string komut = "select isim,daire,aidat,sicaksu,kalorifer,ekborc,devredenborc,toplamborc from " + comboBox6.Text + "";
            MySqlCommand mycom = new MySqlCommand(komut, mysqlbaglan);
            MySqlDataAdapter adap = new MySqlDataAdapter(komut, mysqlbaglan);
            System.Data.DataTable dt = new System.Data.DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            mysqlbaglan.Open();
            MySqlDataReader mydr = mycom.ExecuteReader();
            mysqlbaglan.Close();
            label18.Text = comboBox6.Text;




            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            SiteYonetimSistemi.Form3 f3 = new SiteYonetimSistemi.Form3();
            f3.Show();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (comboBox12.Text == "" && textBox1.Text != null)
            {

                MessageBox.Show("Lütfen önce yan taraftan bir ay-yıl seçiniz.");
                return;
            }
           
            string komut = "select isim,daire,blok,aidat,sicaksu,kalorifer,ekborc,toplamborc FROM " + comboBox12.Text + " WHERE isim = '" + textBox1.Text + "'";
            MySqlCommand mycom = new MySqlCommand(komut, mysqlbaglan);
            MySqlDataAdapter adap = new MySqlDataAdapter(komut, mysqlbaglan);
            System.Data.DataTable dt = new System.Data.DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            mysqlbaglan.Open();
            MySqlDataReader mydr = mycom.ExecuteReader();
            mysqlbaglan.Close();
            label18.Text = comboBox12.Text;
            comboBox6.Text = comboBox12.Text;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();
                }
            }

        }

        private void textBox12_TextChanged_2(object sender, EventArgs e)
        {
            if (textBox12.Text != "" && comboBox12.Text != "")
            {
                string isim = "SELECT isim FROM " + comboBox12.Text + " WHERE isim LIKE '%" + textBox12.Text + "%'";
                string daire = "SELECT daire FROM " + comboBox12.Text + " WHERE isim LIKE '%" + textBox12.Text + "%'";
                string telsorgu = "SELECT tel FROM " + comboBox12.Text + " WHERE isim LIKE '%" + textBox12.Text + "%'";
                string toplamborcsorgu = "SELECT toplamborc FROM " + comboBox12.Text + " WHERE isim LIKE '%" + textBox12.Text + "%'";
                string katsorgu = "SELECT kat FROM " + comboBox12.Text + " WHERE isim LIKE '%" + textBox12.Text + "%'";
                string bloksorgu = "SELECT blok FROM " + comboBox12.Text + " WHERE isim LIKE '%" + textBox12.Text + "%'";
                string metre2sorgu = "SELECT metre2 FROM " + comboBox12.Text + " WHERE isim LIKE '%" + textBox12.Text + "%'";

                mysqlbaglan.Open();
                textBox3.Text = daire;
                MySqlCommand command1 = new MySqlCommand(daire, mysqlbaglan);
                MySqlDataReader myreader;
                myreader = command1.ExecuteReader();
                if (myreader.Read() == true)
                {
                    textBox2.Text = myreader[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox2.Text = "HATA";
                }
                mysqlbaglan.Close();



                mysqlbaglan.Open();
                MySqlCommand command2 = new MySqlCommand(telsorgu, mysqlbaglan);
                MySqlDataReader myreader2;
                myreader2 = command2.ExecuteReader();
                if (myreader2.Read() == true)
                {
                    textBox3.Text = myreader2[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox3.Text = "HATA";
                }
                mysqlbaglan.Close();


                mysqlbaglan.Open();
                MySqlCommand command44 = new MySqlCommand(isim, mysqlbaglan);
                MySqlDataReader myreader44;
                myreader44 = command44.ExecuteReader();
                if (myreader44.Read() == true)
                {
                    textBox1.Text = myreader44[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox1.Text = "HATA";
                }
                mysqlbaglan.Close();



                mysqlbaglan.Open();
                MySqlCommand command7 = new MySqlCommand(metre2sorgu, mysqlbaglan);
                MySqlDataReader myreader7;
                myreader7 = command7.ExecuteReader();
                if (myreader7.Read() == true)
                {
                    textBox16.Text = myreader7[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox16.Text = "HATA";
                }
                mysqlbaglan.Close();


                mysqlbaglan.Open();
                MySqlCommand command3 = new MySqlCommand(toplamborcsorgu, mysqlbaglan);
                MySqlDataReader myreader3;
                myreader3 = command3.ExecuteReader();
                if (myreader3.Read() == true)
                {
                    textBox5.Text = myreader3[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox5.Text = "HATA";
                }
                mysqlbaglan.Close();




                mysqlbaglan.Open();
                MySqlCommand command6 = new MySqlCommand(bloksorgu, mysqlbaglan);
                MySqlDataReader myreader6;
                myreader6 = command6.ExecuteReader();
                if (myreader6.Read() == true)
                {
                    comboBox1.Text = myreader6[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    comboBox1.Text = "HATA";
                }
                mysqlbaglan.Close();



                mysqlbaglan.Open();
                MySqlCommand command4 = new MySqlCommand(katsorgu, mysqlbaglan);
                MySqlDataReader myreader4;
                myreader4 = command4.ExecuteReader();

                if (myreader4.Read() == true)
                {
                    textBox4.Text = myreader4[0].ToString();
                    mysqlbaglan.Close();
                }
                else
                {
                    textBox4.Text = "HATA";
                }
                mysqlbaglan.Close();

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(comboBox4.Text != "" && textBox8.Text != "")
                {
                    string asd = "UPDATE " + comboBox4.Text + " SET ekborc = '" + textBox8.Text + "'";
                    mysqlbaglan.Open();
                    MySqlCommand command = new MySqlCommand(asd, mysqlbaglan);

                    if (command.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Bütün dairelerin aylık aidat borcu güncellendi.");
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        MessageBox.Show("Aidat Borcu Ekleme Başarısız");
                        mysqlbaglan.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen önce ay-yıl ve tutarı girin.");
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mysqlbaglan.Close();
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (comboBox6.Text != "" && comboBox13.Text != "")
            {

                DialogResult dialogResult = MessageBox.Show(comboBox6.Text + " ayın sicaksu ve kalorifer verileri " + comboBox13.Text + " ayın verilerine aktarılacak?", "Veri aktarımı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string asd = "UPDATE " + comboBox13.Text + " JOIN " + comboBox6.Text + " ON " + comboBox13.Text + ".daire = " + comboBox6.Text + ".daire SET " + comboBox13.Text + ".oncekiaySu = " + comboBox6.Text + ".sonrakiaySu";
                    string asd2 = "UPDATE " + comboBox13.Text + " JOIN " + comboBox6.Text + " ON " + comboBox13.Text + ".daire = " + comboBox6.Text + ".daire SET " + comboBox13.Text + ".oncekiayGAZ = " + comboBox6.Text + ".sonrakiayGAZ";
                    mysqlbaglan.Open();
                    MySqlCommand command = new MySqlCommand(asd, mysqlbaglan);
                    MySqlCommand command2 = new MySqlCommand(asd2, mysqlbaglan);
                    command2.ExecuteNonQuery();

                    if (command.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Veriler başarılı bir şekilde aktarıldı.");
                        mysqlbaglan.Close();
                    }
                    else
                    {
                        MessageBox.Show("Veri aktarımı Başarısız");
                        mysqlbaglan.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce en soldan ay-yıl ve sağından ay-yıl seçin");
            }

        }

    }
}
