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
    public partial class gonderiGuncelle : Form
    {
        int takipNOO;
        string islemiYapanYetkiliTC;
        public gonderiGuncelle(int takipNo, string islemiYapan)
        {
            InitializeComponent();


            takipNOO = takipNo;


            DataRow gonderi = db.kargoIslemleri.kargoyuGetir(takipNo);
            lblTakipNo.Text = gonderi["Takip No"].ToString();
            tbGonderenTCNo.Text = gonderi["Gönderici Kimlik No"].ToString();
            tbGonderenAdSoyad.Text = gonderi["Gönderici Bilgisi"].ToString();
            tbGonderenTelNo.Text = gonderi["Gönderici Tel"].ToString();
            tbgSehir.Text = gonderi["Gönderici Şehir"].ToString();
                       
             tbgilce.Text = gonderi["Gönderici İlçe"].ToString();
            tbGonderenAdres.Text = gonderi["Gönderici Adres"].ToString();
            tbGonderenPK.Text = gonderi["Gönderici PK"].ToString();
          cbGonderenMusteriTuru.Text= gonderi["Gönderici Türü"].ToString();


            tbAliciTCNo.Text = gonderi["Alıcı Kimlik No"].ToString();
            tbAliciAdSoyad.Text = gonderi["Alıcı Bilgisi"].ToString();
            tbAliciTelNo.Text = gonderi["Alıcı Tel"].ToString();
            tbASehir.Text = gonderi["Alıcı Şehir"].ToString();
            tbAilce.Text = gonderi["Alıcı İlçe"].ToString();
            tbAliciAdres.Text = gonderi["Alıcı Adres"].ToString();
            tbAliciPK.Text = gonderi["Alıcı PK"].ToString();
            cbAliciMusteriTuru.Text = gonderi["Alıcı Türü"].ToString();


            tbCikisSubesi.Text= gonderi["Çıkış Şubesi"].ToString();
            tbTeslimSubesi.Text = gonderi["Teslimat Şubesi"].ToString();
            cbOdeyenTaraf.Text = gonderi["Ücret Tahsil"].ToString();
            cbTeslimatSekli.Text = gonderi["Teslimat Türü"].ToString();
            cbOdemeTuru.Text = gonderi["Ödeme Türü"].ToString();
            cbGonderiTuru.Text = gonderi["Kargo Türü"].ToString();
            tbDesi.Text = gonderi["Desi"].ToString();
            tbUcret.Text= gonderi["Ücret"].ToString();
            tbAlimZamani.Text = gonderi["Kargo Alım Tarihi"].ToString();
            cbDurum.Text = gonderi["Durum"].ToString();
           
            islemiYapanYetkiliTC = islemiYapan;

  
            cbDurum.DataSource = db.kargoIslemleri.durumlariGetir();
            cbDurum.ValueMember = "Durum No";
            cbDurum.DisplayMember = "Durum Açıklaması";

        }

        private void gonderiGuncelle_Load(object sender, EventArgs e)
        {
           
        
           


        }
        

        private void btnIslemiTamamla_Click(object sender, EventArgs e)
        {

       

            if (cbDurum.Text == "Teslim Edildi")


            {


                DateTime suankiTarih = DateTime.Now;
                string teslimZamani = suankiTarih.ToString("yyyy-MM-dd HH:mm:ss");
                db.ucretIslem.faturaOdendiGuncelle(takipNOO);
                db.kargoIslemleri.kargoTeslimGuncelle(Convert.ToInt16(cbDurum.SelectedValue), teslimZamani, islemiYapanYetkiliTC, Convert.ToInt16(lblTakipNo.Text), tbTeslimAlan.Text);
            }

            else
            {
                db.kargoIslemleri.kargoDurumuGuncelle(Convert.ToInt16(cbDurum.SelectedValue), Convert.ToInt16(lblTakipNo.Text));
            }
            DialogResult secenek = MessageBox.Show("Gönderi Güncellendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (secenek == DialogResult.OK) this.Close();
        }

        private void cbDurum_TextChanged(object sender, EventArgs e)
        {
            if (cbDurum.Text == "Teslim Edildi")


            {
                lblTeslimAlan.Visible = true;
                tbTeslimAlan.Visible = true;
            }

            else
            {
                lblTeslimAlan.Visible = false;
                tbTeslimAlan.Visible = false;
            }


        }

        private void gb_Gonderen_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void tbTeslimAlan_TextChanged(object sender, EventArgs e)
        {
            if (tbTeslimAlan.TextLength > 6)
            { tickTeslimAlan.Visible = true; }
            else tickTeslimAlan.Visible = false;
        }

        private void lblTakipNo_Click(object sender, EventArgs e)
        {

        }

        private void cbAliciSehir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
