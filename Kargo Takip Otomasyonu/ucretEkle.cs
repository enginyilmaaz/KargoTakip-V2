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
    public partial class fiyatEkle : Form
    {
        int musteriNO;
        public fiyatEkle()
        {
            InitializeComponent();
        }

        private void btn_yetkili_ekle_Click(object sender, EventArgs e)
        {
            bool gonderiTuru= false;

            if (cb_gonderiTuru.Text == "Dosya") gonderiTuru = false;
            else if (cb_gonderiTuru.Text == "Paket") gonderiTuru = true;
            int BirimFiyat = Convert.ToInt16(tbBirimFiyat.Text);
        
           db.ucretIslem.ucretEkle(gonderiTuru, BirimFiyat, musteriNO);
            MessageBox.Show("Ücret başarıyla eklendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void uucretEkle_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbMusKimlikNO.TextLength > 10)
            {


                DataTable dt = db.musteriIslemleri.musteriGetir(tbMusKimlikNO.Text);

                if (dt.Rows.Count > 0)
                {

                    tbMusBilgi.Text = dt.Rows[0]["musAdSoyad"].ToString();

                    musteriNO = Convert.ToInt16(dt.Rows[0]["musteriNO"]);
                }
                else
                    tbMusBilgi.Text = "Müşteri bulunamadı!";



            }
            }
    }
}
