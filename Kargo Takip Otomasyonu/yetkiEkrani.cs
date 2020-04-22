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
    public partial class yetkiEkrani : Form
    {
        public yetkiEkrani()
        {
            InitializeComponent();
        }

        private void btn_yetkili_ekle_Click(object sender, EventArgs e)
        {
            db.uyeIslemleri.yetkiEkle(tb_yetki.Text);
            MessageBox.Show("Yetki başarıyla eklendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



            this.Close();
        }
    }
}
