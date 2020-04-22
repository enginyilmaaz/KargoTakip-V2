using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class sifremiUnuttum : Form
    {
        public sifremiUnuttum()
        {
            InitializeComponent();
        }


       



        private void tb_yetkili_Mail_TextChanged(object sender, EventArgs e)
        {
            lbl_Yanlis_Eposta.Visible = false;
            pb_hata_resim.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = db.uyeIslemleri.sifremiUnuttum(tb_yetkili_Mail.Text);

            if (dt.Rows.Count > 0)
            {
                gb_Adim3.Visible = false;
                gb_Adim2.Visible = true;
                gb_Adim1.Visible = false;

              
                string yetkili_Gizli_Soru = dt.Rows[0]["prsGizliSoru"].ToString();
                lbl_Gizli_Soru.Text = yetkili_Gizli_Soru +"?";
                lbl_Gizli_Soru.Visible = true;
             

            }



            else
            {
                pb_hata_resim.Visible = true;
                lbl_Yanlis_Eposta.Visible = true;
               
            }



        }



        private void btn_Cevapla_Click(object sender, EventArgs e)
        {


            DataTable dt = db.uyeIslemleri.sifremiUnuttum(tb_yetkili_Mail.Text);

            string yetkili_Gizli_Cevap = dt.Rows[0]["prsGizliSoruCevap"].ToString();
                if (tb_Gizli_Soru_Yanit.Text == yetkili_Gizli_Cevap)
                {
                    gb_Adim2.Visible = false;
                    gb_Adim1.Visible = false;
                    gb_Adim3.Visible = true;

                
            }


                else
            {
                pb_hata_gizli_soru.Visible = true;
                lbl_Gizli_Soru_Hatasi.Visible = true;
            }
        }

        private void sifremiUnuttum_Load(object sender, EventArgs e)
        {

         

        }

        private void btn_Degistir_Click(object sender, EventArgs e)
        {

            try
            {
                db.uyeIslemleri.sifreDegistir(tb_Yeni_Sifre.Text, tb_yetkili_Mail.Text);//Yapılacak işlemler

                MessageBox.Show("Şifreniz başarıyla değiştirildi..", "İşlem Başarılı", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)// Exception kısmında oluşabilecek hatalar exception yazarsak bütün hatalarda bunu tekrarlar
            {

                MessageBox.Show("Bir hata oluştu, lütfen tekrar deneyin..", "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }


          
        }

        private void gb_Adim3_Enter(object sender, EventArgs e)
        {

        }

        private void tb_Yeni_Sifre_TextChanged(object sender, EventArgs e)
        {
            if (tb_Yeni_Sifre.Text.Length > 5 && tb_Yeni_Sifre.Text==tb_Yeni_Sifre_Tekrar.Text)
            {
                btn_Degistir.Enabled = true;

            }

            else
            {
                btn_Degistir.Enabled = false;
            }

        }

        private void tb_yetkili_Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13))) 
            {
                button1_Click(sender, e);
            }
        }

        private void tb_Gizli_Soru_Yanit_TextChanged(object sender, EventArgs e)
        {

            pb_hata_resim.Visible = false;
            lbl_Gizli_Soru_Hatasi.Visible = false;

            if (tb_Gizli_Soru_Yanit.Text.Length > 2)
            { btn_Cevapla.Enabled = true; }

            else { btn_Cevapla.Enabled =false;  }
        }

        private void gb_Adim2_Enter(object sender, EventArgs e)
        {

        }

        private void tb_Gizli_Soru_Yanit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_Gizli_Soru_Yanit.Text.Length > 2) { 
                if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btn_Cevapla_Click(sender, e);
            }
            }
        }

        private void tb_Yeni_Sifre_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (tb_Yeni_Sifre.Text.Length > 5 && tb_Yeni_Sifre.Text == tb_Yeni_Sifre_Tekrar.Text)
            {
                if (e.KeyChar.Equals(Convert.ToChar(13)))
                {
                    btn_Degistir_Click(sender, e);
                }

            }
           
        }

        private void tb_Yeni_Sifre_Click(object sender, EventArgs e)
        {
            tb_Yeni_Sifre.Clear();
        }

        private void tb_Yeni_Sifre_Tekrar_Click(object sender, EventArgs e)
        {
            tb_Yeni_Sifre_Tekrar.Clear();
        }

     

        private void pb_sifreyi_goster_MouseMove(object sender, MouseEventArgs e)
        {
            tb_Yeni_Sifre.PasswordChar = '\0';
        }

        private void pb_sifreyi_goster_MouseLeave(object sender, EventArgs e)
        {
            tb_Yeni_Sifre.PasswordChar = '●';
        }

        private void pb_tekrar_sifreyi_goster_MouseLeave(object sender, EventArgs e)
        {
            tb_Yeni_Sifre_Tekrar.PasswordChar = '●';
        }

        private void pb_tekrar_sifreyi_goster_MouseMove(object sender, MouseEventArgs e)
        {
            tb_Yeni_Sifre_Tekrar.PasswordChar = '\0';
        }
    }
}
