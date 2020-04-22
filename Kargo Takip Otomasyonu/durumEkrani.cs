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
    public partial class durumEkrani : Form
    {
        public durumEkrani()
        {
            InitializeComponent();
        }

        private void btn_yetkili_ekle_Click(object sender, EventArgs e)
        {
            db.kargoIslemleri.durumEkle(tb_durum.Text);
            MessageBox.Show("Durum başarıyla eklendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



            this.Close();


        }

        private void lbl_cinsiyet_Click(object sender, EventArgs e)
        {

        }

        private void tb_durum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void durumEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
