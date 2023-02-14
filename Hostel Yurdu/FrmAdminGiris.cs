﻿using System;
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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1J38SV0\\SQLEXPRESS;Initial Catalog=AhmedPasa;Integrated Security=True");


        private void BtnGirisYapAdm_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = " select * from AdminGiris where Kullanici=@KullaniciAdi AND Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi",TxtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", TxtAdmSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);

                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hatali Giris");
            }
        }
    }
}
