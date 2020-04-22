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
    public partial class durumGuncelle : Form
    {
        int dID;
        public durumGuncelle(int durumID)
        {

            InitializeComponent();
            DataRow durum = db.kargoIslemleri.durumuGetir(durumID);
            tbSimdikiDurum.Text = durum["Durum Açıklaması"].ToString();
            dID= Convert.ToInt16(durum["Durum No"]);



        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            db.kargoIslemleri.durumGuncelle(tb_durum.Text,dID);
            MessageBox.Show("Durum başarıyla güncellendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



            this.Close();
        }

        private void durumGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cinsiyet_Click(object sender, EventArgs e)
        {

        }

        private void tbSimdikiDurum_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_durum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
