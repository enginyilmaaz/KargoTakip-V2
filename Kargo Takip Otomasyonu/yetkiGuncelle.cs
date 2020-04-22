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
    public partial class yetkiGuncelle : Form
    {
        int yetkiiID;
        public yetkiGuncelle(int yetkiID)
        {
            InitializeComponent();

            DataRow durum = db.uyeIslemleri.yetkiyiGetir(yetkiID);
            tbSimdikiYetkiAciklamasi.Text = durum["Yetki Açıklaması"].ToString();
            yetkiiID= Convert.ToInt16(durum["Yetki No"]);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {


            db.uyeIslemleri.yetkiGuncelle(tb_yeniYetkiAciklamasi.Text, yetkiiID);
            MessageBox.Show("Durum başarıyla güncellendi..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



            this.Close();

        }

        private void yetkiGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
