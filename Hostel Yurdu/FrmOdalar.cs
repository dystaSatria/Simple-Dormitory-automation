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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1J38SV0\\SQLEXPRESS;Initial Catalog=AhmedPasa;Integrated Security=True");

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            //Oda1
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda1", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda1.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda1.Text != "1" && BtnOda1.Text != " ")
            {
                BtnOda1.BackColor = Color.Red;
                //BtnOda1.Enabled = false;

            }
            else
            {
                BtnOda1.Text = "1";
            }




            //Oda2
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda2", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda2.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda2.Text != "2" && BtnOda2.Text != " ")
            {
                BtnOda2.BackColor = Color.Red;
                //BtnOda2.Enabled = false;

            }
            else
            {
                BtnOda2.Text = "2";
            }


            //Oda3
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda3", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda3.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda3.Text != "3" && BtnOda3.Text != " ")
            {
                BtnOda3.BackColor = Color.Red;
                //BtnOda3.Enabled = false;

            }
            else
            {
                BtnOda3.Text = "3";
            }


            //Oda4
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda4", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda4.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda4.Text != "4" && BtnOda4.Text != " ")
            {
                BtnOda4.BackColor = Color.Red;
                //BtnOda4.Enabled = false;

            }
            else
            {
                BtnOda4.Text = "4";
            }


            //Oda5
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda5", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda5.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda5.Text != "5" && BtnOda5.Text != " ")
            {
                BtnOda5.BackColor = Color.Red;
                //BtnOda5.Enabled = false;
            }
            else
            {
                BtnOda5.Text = "5";
            }


            //Oda6
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda6", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda6.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }

            baglanti.Close();

            if (BtnOda6.Text != "6" && BtnOda6.Text != " ")
            {
                BtnOda6.BackColor = Color.Red;
                //BtnOda6.Enabled = false;

            }
            else
            {
                BtnOda6.Text = "6";
            }


            //Oda7
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda7", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda7.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda7.Text != "7" && BtnOda7.Text != " ")
            {
                BtnOda7.BackColor = Color.Red;
                //BtnOda7.Enabled = false;

            }
            else
            {
                BtnOda7.Text = "7";
            }


            //Oda8
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda8", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda8.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }

            baglanti.Close();

            if (BtnOda8.Text != "8" && BtnOda8.Text != " ")
            {
                BtnOda8.BackColor = Color.Red;
                //BtnOda8.Enabled = false;

            }
            else
            {
                BtnOda8.Text = "8";
            }


            //Oda9
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda9", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda9.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda9.Text != "9" && BtnOda9.Text != " ")
            {
                BtnOda9.BackColor = Color.Red;
                //BtnOda9.Enabled = false;
            }
            else
            {
                BtnOda9.Text = "9";
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }

        

        private void BtnOda1_Click_1(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle where OdaNo=1", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                
                
                MessageBox.Show("No :"+ oku["Musteriid"].ToString()+"\n" +"Adi:   " + oku["Adi"].ToString()+ "\n"+ "Soyadi:  " + oku["Soyadi"].ToString()+ "\n" +"Cinsiyet:  "+ oku["Cinsiyet"].ToString() + "\n" +"Telefon Numarasi: " + oku["Telefon"].ToString() + "\n" +"Mail:  " + oku["Mail"].ToString() + "\n"+"TC Numarasi"+ oku["TC"].ToString() + "\n"+"Oda Numarasi:  "+ oku["OdaNo"].ToString()+ "\n"+"Ucreti:  "+ oku["Ucret"].ToString()+"  TL" +"\n"+"Giris Tarihi:  "+ oku["GirisTarihi"].ToString() + "\n"+"Cikis Tarihi:  "+ oku["CikisTarihi"].ToString() );

            }
            baglanti.Close();
        }

        private void BtnOda2_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle where OdaNo=2", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


                MessageBox.Show("No :" + oku["Musteriid"].ToString() + "\n" + "Adi:   " + oku["Adi"].ToString() + "\n" + "Soyadi:  " + oku["Soyadi"].ToString() + "\n" + "Cinsiyet:  " + oku["Cinsiyet"].ToString() + "\n" + "Telefon Numarasi: " + oku["Telefon"].ToString() + "\n" + "Mail:  " + oku["Mail"].ToString() + "\n" + "TC Numarasi" + oku["TC"].ToString() + "\n" + "Oda Numarasi:  " + oku["OdaNo"].ToString() + "\n" + "Ucreti:  " + oku["Ucret"].ToString() + "  TL" + "\n" + "Giris Tarihi:  " + oku["GirisTarihi"].ToString() + "\n" + "Cikis Tarihi:  " + oku["CikisTarihi"].ToString());

            }
            baglanti.Close();
        }

        private void BtnOda3_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle where OdaNo=3", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


                MessageBox.Show("No :" + oku["Musteriid"].ToString() + "\n" + "Adi:   " + oku["Adi"].ToString() + "\n" + "Soyadi:  " + oku["Soyadi"].ToString() + "\n" + "Cinsiyet:  " + oku["Cinsiyet"].ToString() + "\n" + "Telefon Numarasi: " + oku["Telefon"].ToString() + "\n" + "Mail:  " + oku["Mail"].ToString() + "\n" + "TC Numarasi" + oku["TC"].ToString() + "\n" + "Oda Numarasi:  " + oku["OdaNo"].ToString() + "\n" + "Ucreti:  " + oku["Ucret"].ToString() + "  TL" + "\n" + "Giris Tarihi:  " + oku["GirisTarihi"].ToString() + "\n" + "Cikis Tarihi:  " + oku["CikisTarihi"].ToString());

            }
            baglanti.Close();
        }

        private void BtnOda4_Click(object sender, EventArgs e)
        {
          
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle where OdaNo=4", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


                MessageBox.Show("No :" + oku["Musteriid"].ToString() + "\n" + "Adi:   " + oku["Adi"].ToString() + "\n" + "Soyadi:  " + oku["Soyadi"].ToString() + "\n" + "Cinsiyet:  " + oku["Cinsiyet"].ToString() + "\n" + "Telefon Numarasi: " + oku["Telefon"].ToString() + "\n" + "Mail:  " + oku["Mail"].ToString() + "\n" + "TC Numarasi" + oku["TC"].ToString() + "\n" + "Oda Numarasi:  " + oku["OdaNo"].ToString() + "\n" + "Ucreti:  " + oku["Ucret"].ToString() + "  TL" + "\n" + "Giris Tarihi:  " + oku["GirisTarihi"].ToString() + "\n" + "Cikis Tarihi:  " + oku["CikisTarihi"].ToString());

            }
            baglanti.Close();
        }

        private void BtnOda5_Click(object sender, EventArgs e)
        {
          
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle where OdaNo=5", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


                MessageBox.Show("No :" + oku["Musteriid"].ToString() + "\n" + "Adi:   " + oku["Adi"].ToString() + "\n" + "Soyadi:  " + oku["Soyadi"].ToString() + "\n" + "Cinsiyet:  " + oku["Cinsiyet"].ToString() + "\n" + "Telefon Numarasi: " + oku["Telefon"].ToString() + "\n" + "Mail:  " + oku["Mail"].ToString() + "\n" + "TC Numarasi" + oku["TC"].ToString() + "\n" + "Oda Numarasi:  " + oku["OdaNo"].ToString() + "\n" + "Ucreti:  " + oku["Ucret"].ToString() + "  TL" + "\n" + "Giris Tarihi:  " + oku["GirisTarihi"].ToString() + "\n" + "Cikis Tarihi:  " + oku["CikisTarihi"].ToString());

            }
            baglanti.Close();
        }

        private void BtnOda6_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle where OdaNo=6", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


                MessageBox.Show("No :" + oku["Musteriid"].ToString() + "\n" + "Adi:   " + oku["Adi"].ToString() + "\n" + "Soyadi:  " + oku["Soyadi"].ToString() + "\n" + "Cinsiyet:  " + oku["Cinsiyet"].ToString() + "\n" + "Telefon Numarasi: " + oku["Telefon"].ToString() + "\n" + "Mail:  " + oku["Mail"].ToString() + "\n" + "TC Numarasi" + oku["TC"].ToString() + "\n" + "Oda Numarasi:  " + oku["OdaNo"].ToString() + "\n" + "Ucreti:  " + oku["Ucret"].ToString() + "  TL" + "\n" + "Giris Tarihi:  " + oku["GirisTarihi"].ToString() + "\n" + "Cikis Tarihi:  " + oku["CikisTarihi"].ToString());

            }
            baglanti.Close();
        }

        private void BtnOda7_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle where OdaNo=7", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


                MessageBox.Show("No :" + oku["Musteriid"].ToString() + "\n" + "Adi:   " + oku["Adi"].ToString() + "\n" + "Soyadi:  " + oku["Soyadi"].ToString() + "\n" + "Cinsiyet:  " + oku["Cinsiyet"].ToString() + "\n" + "Telefon Numarasi: " + oku["Telefon"].ToString() + "\n" + "Mail:  " + oku["Mail"].ToString() + "\n" + "TC Numarasi" + oku["TC"].ToString() + "\n" + "Oda Numarasi:  " + oku["OdaNo"].ToString() + "\n" + "Ucreti:  " + oku["Ucret"].ToString() + "  TL" + "\n" + "Giris Tarihi:  " + oku["GirisTarihi"].ToString() + "\n" + "Cikis Tarihi:  " + oku["CikisTarihi"].ToString());

            }
            baglanti.Close();
        }

        private void BtnOda8_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle where OdaNo=8", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


                MessageBox.Show("No :" + oku["Musteriid"].ToString() + "\n" + "Adi:   " + oku["Adi"].ToString() + "\n" + "Soyadi:  " + oku["Soyadi"].ToString() + "\n" + "Cinsiyet:  " + oku["Cinsiyet"].ToString() + "\n" + "Telefon Numarasi: " + oku["Telefon"].ToString() + "\n" + "Mail:  " + oku["Mail"].ToString() + "\n" + "TC Numarasi" + oku["TC"].ToString() + "\n" + "Oda Numarasi:  " + oku["OdaNo"].ToString() + "\n" + "Ucreti:  " + oku["Ucret"].ToString() + "  TL" + "\n" + "Giris Tarihi:  " + oku["GirisTarihi"].ToString() + "\n" + "Cikis Tarihi:  " + oku["CikisTarihi"].ToString());

            }
            baglanti.Close();
        }

        private void BtnOda9_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle where OdaNo=9", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


                MessageBox.Show("No :" + oku["Musteriid"].ToString() + "\n" + "Adi:   " + oku["Adi"].ToString() + "\n" + "Soyadi:  " + oku["Soyadi"].ToString() + "\n" + "Cinsiyet:  " + oku["Cinsiyet"].ToString() + "\n" + "Telefon Numarasi: " + oku["Telefon"].ToString() + "\n" + "Mail:  " + oku["Mail"].ToString() + "\n" + "TC Numarasi" + oku["TC"].ToString() + "\n" + "Oda Numarasi:  " + oku["OdaNo"].ToString() + "\n" + "Ucreti:  " + oku["Ucret"].ToString() + "  TL" + "\n" + "Giris Tarihi:  " + oku["GirisTarihi"].ToString() + "\n" + "Cikis Tarihi:  " + oku["CikisTarihi"].ToString());

            }
            baglanti.Close();
        }

        //private void veriGoster()
        //{


        //}


    }
}
