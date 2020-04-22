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
    public partial class ucretGuncelle : Form
    {
       int musteriNUM ,gonderiiTuru; //global değişkenler
        public ucretGuncelle(int gonderiTuru, int musteriNO)
        {
            InitializeComponent();

            gonderiiTuru = gonderiTuru;
           musteriNUM = musteriNO;

            DataRow ucretler = db.ucretIslem.ucretGetir(gonderiTuru,musteriNO);

           bool GondTuru = Convert.ToBoolean(ucretler["gonderiTuru"]);
                  if (GondTuru ==false) tbGonderiTuru.Text = "Dosya";
           else tbGonderiTuru.Text = "Paket";


            tbBirimFiyat.Text = ucretler["birimUcret"].ToString();
            tbMusBilgi.Text = ucretler["musAdSoyad"].ToString();
            tbMusKimlikNO.Text = ucretler["musKimlikNO"].ToString();
        
        }

      
        private void ucrettEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
           

            db.ucretIslem.ucretGuncelle(gonderiiTuru, tbBirimFiyat.Text, musteriNUM);
            MessageBox.Show("Ücret başarıyla güncellendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
