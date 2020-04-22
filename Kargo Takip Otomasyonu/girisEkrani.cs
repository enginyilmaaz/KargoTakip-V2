using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class girisEkrani : Form
    {
        public girisEkrani()
        {
            InitializeComponent();
        }

        private void girisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiUnuttum s = new sifremiUnuttum();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
        }

        private void btn_Giris_Yap_Click(object sender, EventArgs e)
        {


            DataTable dt = db.uyeIslemleri.girisKontrolu(tb_yetkili_TC.Text, tb_yetkili_Sifre.Text);

            if (dt.Rows.Count > 0)
            {
                int yetki_turu = Convert.ToInt16(dt.Rows[0]["prsYetkiID"]);
                string prsAdSoyad = dt.Rows[0]["prsAdSoyad"].ToString();
                string personelKimlikNo = dt.Rows[0]["prsKimlikNo"].ToString();
                string subeAdi = dt.Rows[0]["subeAdi"].ToString();
                string yetkiAciklama= dt.Rows[0]["YetkiAciklamasi"].ToString();

                if (yetkiAciklama=="Şube Personeli" || yetkiAciklama == "Şube Yöneticisi")

                {
            
                    string FormAdi = yetkiAciklama + " Ekranı";
                    tb_yetkili_TC.Clear();
                    tb_yetkili_Sifre.Clear();
                    subeEkrani s = new subeEkrani(personelKimlikNo, prsAdSoyad, yetkiAciklama, FormAdi,subeAdi);
                    this.Visible = false;
                    s.ShowDialog();
                    this.Visible = true;
                }


                if (yetkiAciklama == "Sistem Yöneticisi")
                {
                   
                    tb_yetkili_TC.Clear();
                    tb_yetkili_Sifre.Clear();
                    sistemYoneticisiEkrani s = new sistemYoneticisiEkrani(personelKimlikNo);
                    this.Visible = false;
                    s.ShowDialog();
                    this.Visible = true;
                }


            }



            else
            {
             
                lbl_Giris_Hata.Visible = true;
                pb_hata_resim.Visible = true;

            }











        }

        private void tb_yetkili_Sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))  // şifre textboxında enter tuşuna basılınca giriş yap butonu görevi görür
            {
                btn_Giris_Yap_Click(sender, e);
            }
        }

        private void tb_yetkili_Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))    // eposta adresi textboxında enter tuşuna basılınca giriş yap butonu görevi görür
            {
                btn_Giris_Yap_Click(sender, e);  }



            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }

        private void tb_yetkili_Mail_TextChanged(object sender, EventArgs e)
        {
            lbl_Giris_Hata.Visible = false;
            pb_hata_resim.Visible = false;
        }

        private void pb_sifreyi_goster_MouseMove(object sender, MouseEventArgs e)
        {
            tb_yetkili_Sifre.PasswordChar = '\0';
        }

        private void pb_sifreyi_goster_MouseLeave(object sender, EventArgs e)
        {
            tb_yetkili_Sifre.PasswordChar = '●';
        }

        private void girisEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz?", "Çıkış Mesajı!", MessageBoxButtons.YesNo);

            if (x == DialogResult.Yes)
            { Environment.Exit(0); }

            else if (x == DialogResult.No)
            { e.Cancel = true; }
        }
    }
    }
