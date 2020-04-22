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

    public partial class subeEkle : Form
    {
       
        public subeEkle()
           
        {
            
            InitializeComponent(); 
        }

        private void subeEkle_Load(object sender, EventArgs e)
        {
            
            
          
            cbSubeSehir.DataSource=db.subeIslem.sehirGetir();
            cbSubeSehir.ValueMember = "SehirId";
            cbSubeSehir.DisplayMember = "SehirAdi";
            cbSubeSehir.SelectedIndex = 0;

        }



        private void cbSubeSehir_SelectedIndexChanged(object sender, EventArgs e)
        {

           

           
           cbIlceID.Enabled = true;

            cbIlceID.ValueMember = "ilceID";
            cbIlceID.DisplayMember = "IlceAdi";

            int sehirid;
            bool parseOK = Int32.TryParse(cbSubeSehir.SelectedValue.ToString(), out sehirid);

            cbIlceID.DataSource = db.subeIslem.ilceGetir(sehirid);

           
            


           

         



          





        }

        private void button2_Click(object sender, EventArgs e)
        {
            //tbtt.Text = cbSubeYoneticisi.SelectedValue.ToString();
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


   
        private void tbSubeAdres_TextChanged(object sender, EventArgs e)
        {
            if (tbSubeAdres.Text.Length > 15) pb_tick_subeAdres.Visible = true; 
            else pb_tick_subeAdres.Visible = false;
        }

        private void btn_subeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (pb_tick_subeAdi.Visible && pb_tick_subeAdres.Visible && pb_tick_SubeIlce.Visible &&  pb_tick_subeSehir.Visible && pb_tick_subeTel.Visible )
                {


                    int ilceid;
                    bool parseOK = Int32.TryParse(cbIlceID.SelectedValue.ToString(), out ilceid);

                    db.subeIslem.subeEkle( tbsubeAdi.Text,ilceid, tbSubeAdres.Text, mtbSubeTel.Text);
                MessageBox.Show("Şube başarıyla eklendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    this.Close();

                   

                }

                 else { MessageBox.Show("Bir yada birden fazla bilgi girişi eksik yapıldı, lütfen düzeltin", "Eksik Giriş Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }


            catch (Exception)// 
            {
                MessageBox.Show("Bir hata oluştu, lütfen tekrar deneyin..", "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



}

        private void mtbSubeTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }
    }
}
