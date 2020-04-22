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
    public partial class subeGuncelle : Form
    {
        public subeGuncelle(int guncellenecekSubeNo)
        {
            InitializeComponent();




            cbSubeSehir.DataSource = db.subeIslem.sehirGetir();
            cbSubeSehir.ValueMember = "SehirId";
            cbSubeSehir.DisplayMember = "SehirAdi";
            cbSubeSehir.SelectedIndex = 0;


            DataRow sube = db.subeIslem.subeGetir(guncellenecekSubeNo) ;
            mtbSubeNo.Text = sube["Şube No"].ToString();
           tbsubeAdi.Text= sube["Şube Adı"].ToString();
            mtbSubeTel.Text= sube["Tel No"].ToString();




            string yetkili = sube["Şube Yöneticisi"].ToString();

            

            string sehir=sube["Şehir"].ToString();
            cbSubeSehir.SelectedIndex = cbSubeSehir.FindStringExact(sehir);

            string semt = sube["İlçe"].ToString();
            cbSubeIlce.SelectedIndex = cbSubeIlce.FindStringExact(semt);

            tbSubeAdres.Text= sube["Adres"].ToString();





        }

        private void subeGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void cbSubeSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cbSubeIlce.ValueMember = "ilceID";
            cbSubeIlce.DisplayMember = "IlceAdi";

            int sehirid;
            bool parseOK = Int32.TryParse(cbSubeSehir.SelectedValue.ToString(), out sehirid);

            cbSubeIlce.DataSource = db.subeIslem.ilceGetir(sehirid);
        }

        private void tbsubeAdi_TextChanged(object sender, EventArgs e)
        {
            if (tbsubeAdi.Text.Length > 3) pb_tick_subeAdi.Visible = true;
            else pb_tick_subeAdi.Visible = false;
        }

        private void mtbSubeTel_TextChanged(object sender, EventArgs e)
        {
            if (mtbSubeTel.Text.Length > 9) pb_tick_subeTel.Visible = true;
            else pb_tick_subeTel.Visible = false;
        }

        private void mtbSubeNo_TextChanged(object sender, EventArgs e)
        {
            if (mtbSubeNo.Text.Length > 0) pb_tick_subeNo.Visible = true;
            else pb_tick_subeNo.Visible = false;
        }

       

        private void cbSubeIlce_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbSubeIlce.Text != "İlçe Seçiniz...")

            { pb_tick_SubeIlce.Visible = true; }

            else { pb_tick_SubeIlce.Visible = false; }
        }

        private void tbSubeAdres_TextChanged(object sender, EventArgs e)
        {
            if (tbSubeAdres.Text.Length > 15) pb_tick_subeAdres.Visible = true;
            else pb_tick_subeAdres.Visible = false;
        }

        private void btn_subeEkle_Click(object sender, EventArgs e)
        {
            try { 

            if (pb_tick_subeAdi.Visible && pb_tick_subeAdres.Visible &&  pb_tick_subeNo.Visible &&  pb_tick_subeTel.Visible)
           {
                    int ilceid;
                    bool parseOK = Int32.TryParse(cbSubeIlce.SelectedValue.ToString(), out ilceid);

                    db.subeIslem.subeGuncelle(Convert.ToInt16(mtbSubeNo.Text), tbsubeAdi.Text, ilceid, tbSubeAdres.Text, mtbSubeTel.Text);
                MessageBox.Show("Şube Güncellendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



                this.Close();

          }



            else { MessageBox.Show("Bir yada birden fazla bilgi girişi eksik yapıldı, lütfen düzeltin", "Eksik Giriş Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }


            catch (Exception)// 
            {
                MessageBox.Show("Bir hata oluştu, lütfen tekrar deneyin..", "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



}













    }
}
