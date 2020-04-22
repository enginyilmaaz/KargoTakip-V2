using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class yetkiliGuncelle : Form
    {
        public yetkiliGuncelle(string guncellenecek_yetkili_tc_no, bool sistemYoneticisi)
        {
            InitializeComponent();
           
            DataRow yetkili = db.uyeIslemleri.YetkiliGetir(guncellenecek_yetkili_tc_no);
            mtb_tc_no.Text = yetkili["Kimlik NO"].ToString();
            tb_ad_soyad.Text = yetkili["Ad Soyad"].ToString();
            mtb_telefon_no.Text = yetkili["Telefon No"].ToString();
           
            tb_eposta.Text = yetkili["Eposta"].ToString();
            tb_sifre.Text = yetkili["Şifre"].ToString();
            tb_sifre_tekrar.Text = yetkili["Şifre"].ToString();
            cb_gizli_soru.Text = yetkili["Gizli Soru"].ToString();
            tb_gizli_soru_cevabi.Text = yetkili["Cevap"].ToString();
          
            string sube = yetkili["Şube Adı"].ToString();
            string yetki = yetkili["Yetkisi"].ToString();

            cb_yetki_turu.DataSource = db.uyeIslemleri.yetkileriGetir();
            cb_yetki_turu.ValueMember = "Yetki No";
            cb_yetki_turu.DisplayMember = "Yetki Açıklaması";
            cbSube.DataSource = db.subeIslem.subeleriGetir();
            cbSube.DisplayMember = "Şube Adı";
            cbSube.ValueMember = "Şube No";
   

            cbSube.SelectedIndex = cbSube.FindStringExact(sube);
            cb_yetki_turu.SelectedIndex = cb_yetki_turu.FindStringExact(yetki);

            tbCinsiyet.Text = yetkili["Cinsiyet"].ToString();
              
            if (sistemYoneticisi == false)  // yöneticis değilse yetki ve şube değişimi yapmasın
            {
            //    cbSube.Enabled = false;
                cb_yetki_turu.Enabled = false;
                cbSube.Enabled = false;

            }

           



        }

        private void yetkiliGuncelle_Load(object sender, EventArgs e)
        {
           
           
        }

        private void btn_yetkili_ekle_Click(object sender, EventArgs e)
        {
            try { 
           
                if (pb_tick_tcno.Visible && pb_tick_cinsiyet.Visible && pb_tick_adsoyad.Visible && pb_tick_telefonno.Visible &&  pb_tick_yetkituru.Visible && pb_tick_eposta.Visible && pb_tick_sifre.Visible && pb_tick_sifretekrar.Visible && pb_tick_gizlisoru.Visible && pb_tick_gizlisorucevabi.Visible && pb_tick_susbe.Visible)
            {
                    int yetkiID, subeNO;
                   
                    bool parseOK = Int32.TryParse(cb_yetki_turu.SelectedValue.ToString(), out yetkiID);
                    parseOK = Int32.TryParse(cbSube.SelectedValue.ToString(), out subeNO);
                    db.uyeIslemleri.yetkiliGuncelle(tb_ad_soyad.Text, mtb_tc_no.Text,yetkiID,subeNO,  mtb_telefon_no.Text, tb_eposta.Text, tb_sifre.Text, cb_gizli_soru.Text, tb_gizli_soru_cevabi.Text);


                MessageBox.Show("Güncellendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Close();


            }

          else { MessageBox.Show("Bir yada birden fazla bilgi girişi eksik yapıldı, lütfen düzeltin", "Eksik Giriş Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }


          catch (Exception)// 
         {
             MessageBox.Show("Bir hata oluştu, lütfen tekrar deneyin..", "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);


           }









}

private void mtb_tc_no_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_ad_soyad_TextChanged(object sender, EventArgs e)
        {
            if (tb_ad_soyad.Text.Length > 6) pb_tick_adsoyad.Visible = true;
            else pb_tick_adsoyad.Visible = false;
        }

        private void mtb_telefon_no_TextChanged(object sender, EventArgs e)
        {
            if (mtb_telefon_no.Text.Length >9) pb_tick_telefonno.Visible = true;
            else pb_tick_telefonno.Visible = false;
        }

   

        private void cb_yetki_turu_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tb_eposta_TextChanged(object sender, EventArgs e)
        {
            bool kontrol = db.uyeIslemleri.EmailKontrol(tb_eposta.Text);
            if (kontrol) { pb_tick_eposta.Visible = true; }
            else { pb_tick_eposta.Visible = false; }
        }

        private void tb_sifre_TextChanged(object sender, EventArgs e)
        {

            if (tb_sifre.Text.Length > 5)

            {
                pb_tick_sifre.Visible = true;
            }

            else {
                pb_tick_sifre.Visible = false;
            }
        }

        private void tb_sifre_tekrar_TextChanged(object sender, EventArgs e)
        {
            if (tb_sifre.Text.Length > 5 && tb_sifre.Text == tb_sifre_tekrar.Text)
            {
                pb_tick_sifretekrar.Visible = true;
            }

            else { pb_tick_sifretekrar.Visible = false; }
        }

        private void tb_gizli_soru_cevabi_TextChanged(object sender, EventArgs e)
        {
            if (tb_gizli_soru_cevabi.Text.Length > 2)

            {
                pb_tick_gizlisorucevabi.Visible = true;
            }

            else {
                pb_tick_gizlisorucevabi.Visible = false;
            }
        }

        private void pb_sifreyi_goster_MouseLeave(object sender, EventArgs e)
        {
            tb_sifre.PasswordChar = '●';
        }

        private void pb_sifreyi_goster_MouseMove(object sender, MouseEventArgs e)
        {
            tb_sifre.PasswordChar = '\0';
        }

        private void pb_sifre_tekrar_MouseLeave(object sender, EventArgs e)
        {
            tb_sifre_tekrar.PasswordChar = '●';
        }

        private void pb_sifre_tekrar_MouseMove(object sender, MouseEventArgs e)
        {
            tb_sifre_tekrar.PasswordChar = '\0';

        }

        private void pb_gizli_soru_cevabi_MouseLeave(object sender, EventArgs e)
        {
            tb_gizli_soru_cevabi.PasswordChar = '●';
        }

        private void pb_gizli_soru_cevabi_MouseMove(object sender, MouseEventArgs e)
        {
            tb_gizli_soru_cevabi.PasswordChar = '\0';
        }

        private void tb_ad_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void cb_gizli_soru_TextChanged(object sender, EventArgs e)
        {

            if (cb_gizli_soru.Text != "Seçiniz...")
            {

                if (cb_gizli_soru.Text.Length > 4)
                { pb_tick_gizlisoru.Visible = true; }
                else { pb_tick_gizlisoru.Visible = false; }

            }

            else { pb_tick_gizlisoru.Visible = false; }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //tb_ad_soyad.Text = cbSube.SelectedValue.ToString();
        }

        private void mtb_tc_no_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbCinsiyet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
