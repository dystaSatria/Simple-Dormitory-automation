using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hostel_Yurdu
{
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1J38SV0\SQLEXPRESS;Initial Catalog=AhmedPasa;Integrated Security=True"); 


        private void veriGoster()
        {
            listView1.Items.Clear();//Tekrar yazilmaycak basinca
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            veriGoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlik.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOda.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut= new SqlCommand ("update MusteriEkle set Adi='"+ TxtAdi.Text+"', Soyadi = '"+TxtSoyadi.Text+"',Cinsiyet= '"+comboBox1.Text+"',Telefon='"+MskTxtTelefon.Text+"',Mail= '"+TxtMail.Text+"',TC='"+TxtKimlik.Text+"',OdaNo='"+ TxtOda.Text+"',Ucret='"+TxtUcret.Text+"',GirisTarihi='"+ DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='"+ DtpCikisTarihi.Value.ToString("yyyy-MM-dd") +"'where Musteriid="+id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriGoster();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ") ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriGoster();

            if (TxtOda.Text == "1")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda1", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                veriGoster();
            }

            if (TxtOda.Text == "2")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda2", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                veriGoster();
            }

            if (TxtOda.Text == "3")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda3", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                veriGoster();
            }

            if (TxtOda.Text == "4")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda4", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                veriGoster();
            }

            if (TxtOda.Text == "5")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda5", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                veriGoster();
            }

            if (TxtOda.Text == "6")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda6", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                veriGoster();
            }

            if (TxtOda.Text == "7")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda7", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                veriGoster();
            }

            if (TxtOda.Text == "8")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda8", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                veriGoster();
            }

            if (TxtOda.Text == "9")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda9", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                veriGoster();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Text = "";
            TxtKimlik.Clear();
            TxtOda.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();//Tekrar yazilmaycak basinca
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle where Adi like '%"+ textBox1.Text+"%'" , baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }
    }
}

//            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ") ", baglanti);

//Data Source=DESKTOP-1J38SV0\SQLEXPRESS;Initial Catalog=AhmedPasa;Integrated Security=True