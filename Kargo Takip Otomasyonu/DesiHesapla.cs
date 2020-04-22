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
    public partial class DesiHesapla : Form
    {
        public DesiHesapla()
        {
            InitializeComponent();
        }

        private void DesiHesapla_Load(object sender, EventArgs e)
        {

        }





        private void btnHesapla_Click(object sender, EventArgs e)
        {


            string desiHesap;
            double agirlik, yukseklik, en, boy, desi, agirlikKG;
            int desiTam, agirlikTam;
            en = Convert.ToDouble(tbEn.Text);
            boy = Convert.ToDouble(tbBoy.Text);
            yukseklik = Convert.ToDouble(tbYukseklik.Text);
            agirlik = Convert.ToDouble(tbAgirlik.Text);

            agirlikKG = Math.Round(agirlik / 1000);
            desi = Math.Round((en * boy * yukseklik) / 3000);

            agirlikTam = Convert.ToInt16(agirlikKG);
            desiTam = Convert.ToInt16(desi);

            if (desiTam > agirlikTam)
            { desiHesap = desi.ToString(); }

            else
            {
                desiHesap = agirlikKG.ToString();
            }



            gonderiYap.DesiHesapla = desiHesap;


            this.Close();



        }

        private void tbEn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbEn_TextChanged(object sender, EventArgs e)
        {

            if (tbAgirlik.TextLength > 0 && tbBoy.TextLength > 0 && tbEn.TextLength > 0 && tbYukseklik.TextLength > 0)
            {


                btnHesapla.Enabled = true;

            }
            else btnHesapla.Enabled = false;

        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }
    }
}
