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
    public partial class sistemYoneticisiEkrani : Form
    {
        public sistemYoneticisiEkrani(string tcNo)
        {
            InitializeComponent();

            
            lbl_yetkili_adi.Text = tcNo;
           

        }

        string ara = "subeler";



        private void Form1_Load(object sender, EventArgs e)
        {
            cbRaporlar.SelectedIndex=0;
            Main_Grid.DataSource = db.subeIslem.subeleriGetir();
            Main_Grid.ContextMenuStrip = contextMenuStripSubeler;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           yetkiliEkle s = new yetkiliEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
        }

      

        private void yeniKullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yetkiliEkle s = new yetkiliEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
        }

     

        private void sistemYoneticisiEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz?", "Çıkış Mesajı!", MessageBoxButtons.YesNo);

            if (x == DialogResult.Yes)
            { Environment.Exit(0);  } 

            else if (x == DialogResult.No)
            {  e.Cancel = true; }

            }

        private void button3_Click(object sender, EventArgs e)
        {
            subeEkle s = new subeEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
        }

        private void btnYetkiliListesi_Click(object sender, EventArgs e)
        {

            Main_Grid.DataSource = db.uyeIslemleri.YetkilileriGetir();
            Main_Grid.ContextMenuStrip = contextMenuStripYetkililer;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "yetkililer";
            tb_ara.Enabled =true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;



        }

        private void btnSubeListele_Click(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.subeIslem.subeleriGetir();
            Main_Grid.ContextMenuStrip = contextMenuStripSubeler;
            Main_Grid.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
            ara = "subeler";
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;
        }

        private void btnSubeEkle_Click(object sender, EventArgs e)
        {
            subeEkle s = new subeEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.subeIslem.subeleriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;

            ara = "subeler";

        }



        private void btnYetkiliEkle_Click(object sender, EventArgs e)
        {

            yetkiliEkle s = new yetkiliEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.uyeIslemleri.YetkilileriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ara = "subeler";
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;

        }

        private void cms_Sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Bu işlem geri alınamaz.... \n Seçili kullancıyı silmek istediğinizden emin misiniz? ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.OK)
            {

                DataGridViewRow seciliYetkili = Main_Grid.CurrentRow;
                string yetkiliTC = seciliYetkili.Cells["Kimlik No"].Value.ToString();

                db.uyeIslemleri.yetkiliSil(yetkiliTC);

                MessageBox.Show("Silme işlemi başarılı..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Main_Grid.DataSource = db.uyeIslemleri.YetkilileriGetir();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void cMS_Guncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliYetkili = Main_Grid.CurrentRow;
            string yetkiliTC = seciliYetkili.Cells["Kimlik NO"].Value.ToString();
            yetkiliGuncelle s = new yetkiliGuncelle(yetkiliTC,true);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.uyeIslemleri.YetkilileriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }  

        private void cms_yetkiliEkle_Click(object sender, EventArgs e)
        {
            yetkiliEkle s = new yetkiliEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.uyeIslemleri.YetkilileriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void yeniŞubeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subeEkle s = new subeEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.subeIslem.subeleriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void şubeyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Bu işlem geri alınamaz.... \n Seçili şubeyi silmek istediğinizden emin misiniz? ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.OK)
            {

                DataGridViewRow seciliSube = Main_Grid.CurrentRow;
                int subeNo = Convert.ToInt16(seciliSube.Cells["Şube No"].Value);

                db.subeIslem.subeSil(subeNo);

                MessageBox.Show("Silme işlemi başarılı..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Main_Grid.DataSource = db.subeIslem.subeleriGetir();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void şubeyiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliSube = Main_Grid.CurrentRow;
            int subeNo = Convert.ToInt16(seciliSube.Cells["Şube No"].Value);
            subeGuncelle s = new subeGuncelle(subeNo);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.subeIslem.subeleriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUcretlerListesi_Click(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.ucretIslem.ucretleriGetir();
            Main_Grid.ContextMenuStrip = contextMenuStripUcretler;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "ucretler";
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;

        }



        private void ücretGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliUcret = Main_Grid.CurrentRow;
            int musteriNO = Convert.ToInt16(seciliUcret.Cells["Müşteri No"].Value);
           string gonderiTuru = seciliUcret.Cells["Gönderi Türü"].Value.ToString();
        
           int gonderiTur;
            if (gonderiTuru == "Dosya") gonderiTur = 0;
            else gonderiTur = 1;

            ucretGuncelle s = new ucretGuncelle(gonderiTur,musteriNO);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.ucretIslem.ucretleriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }





        private void tb_ara_TextChanged(object sender, EventArgs e)
        {
            if (tb_ara.TextLength > 0)

            {
                if (ara == "yetkililer")
                {
                    Main_Grid.DataSource = db.uyeIslemleri.yetkiliAra(tb_ara.Text);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

               

               if (ara == "subeler")

                {
                    string subeara = tb_ara.Text.ToString();
                    if (System.Text.RegularExpressions.Regex.IsMatch(tb_ara.Text, "^[0-9]*$"))
                    {
                        Main_Grid.DataSource = db.subeIslem.subeAraNo(subeara);
                        Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }

                    else Main_Grid.DataSource = null;


                }

                if (ara == "kargolar")
                {
                    Main_Grid.DataSource = db.kargoIslemleri.kargoAra(tb_ara.Text);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

                if (ara == "musteriler")
                {
                    Main_Grid.DataSource = db.musteriIslemleri.musteriAra(tb_ara.Text);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                if (ara == "adresler")
                {
                    Main_Grid.DataSource = db.adresIslem.adresAra(tb_ara.Text);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


                if (ara == "yetkiler")
                {
                    Main_Grid.DataSource = db.uyeIslemleri.yetkiAra(tb_ara.Text);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


                if (ara == "durumlar")
                {
                    Main_Grid.DataSource = db.kargoIslemleri.durumAra(tb_ara.Text);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                if (ara == "ucretler")
                {
                    Main_Grid.DataSource = db.ucretIslem.ucretAra(tb_ara.Text);
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


                if (ara == "faturalar")
                {
                    Main_Grid.DataSource = db.ucretIslem.faturaAra(Convert.ToInt16(tb_ara.Text));
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }



            else if (tb_ara.TextLength<=0)

            {
                if (ara == "yetkililer")

                { Main_Grid.DataSource = db.uyeIslemleri.YetkilileriGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


                if (ara == "subeler")

                { Main_Grid.DataSource = db.subeIslem.subeleriGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


                if (ara == "kargolar")

                { Main_Grid.DataSource = db.kargoIslemleri.kargolariGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

                if (ara == "musteriler")
                {
                    Main_Grid.DataSource = db.musteriIslemleri.musterileriGetir();
                  
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                if (ara == "adresler")
                {
                    Main_Grid.DataSource = db.adresIslem.TUMadresleriGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


                if (ara == "yetkiler")
                {
                    Main_Grid.DataSource = db.uyeIslemleri.yetkileriGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


                if (ara == "durumlar")
                {
                    Main_Grid.DataSource = db.kargoIslemleri.durumlariGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                if (ara == "ucretler")
                {
                    Main_Grid.DataSource = db.ucretIslem.ucretleriGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


                if (ara == "faturalar")
                {
                    Main_Grid.DataSource = db.ucretIslem.faturalariGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }









        }

        private void şubelerGöreYetkililerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void şubelereGöreYetkililerToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

            Main_Grid.DataSource= db.uyeIslemleri.subelereGoreYetkililer();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            tb_ara.Enabled = false;
        }

        private void şubelereGöreKargolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.kargoIslemleri.cikisSubesineGoreKargolar();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tb_ara.Enabled = false;
        }

        private void btnKargolariListele_Click(object sender, EventArgs e)
        {
            ara = "kargolar";
            Main_Grid.DataSource =db.kargoIslemleri.kargolariGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
             Main_Grid.ContextMenuStrip = null;
            cbRaporlar.Visible = false;

            lbl_ara.Visible = true;
            lblRapor.Visible = false;
        }

     
      

        private void Main_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.uyeIslemleri.yetkileriGetir();
            Main_Grid.ContextMenuStrip = contextMenuStripYetkiler;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "yetkiler";
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;

        }

        private void btn_durumEkrani_Click(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.kargoIslemleri.durumlariGetir();
            Main_Grid.ContextMenuStrip = contextMenuStripDurumlar;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "durumlar";
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnYetkiEkle_Click(object sender, EventArgs e)
        {
            yetkiEkrani s = new yetkiEkrani();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.ContextMenuStrip = contextMenuStripDurumlar;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "durumlar";
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnDurumEkle_Click(object sender, EventArgs e)
        {
            durumEkrani s = new durumEkrani();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.kargoIslemleri.durumlariGetir();
            Main_Grid.ContextMenuStrip = contextMenuStripDurumlar;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "durumlar";
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;

        }

        private void seçiliDurmuGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow secili = Main_Grid.CurrentRow;
            int durumNo = Convert.ToInt16(secili.Cells["Durum No"].Value);
            durumGuncelle s = new durumGuncelle(durumNo);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.kargoIslemleri.durumlariGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void yeniDurumEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumEkrani s = new durumEkrani();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.kargoIslemleri.durumlariGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Main_Grid.ContextMenuStrip = contextMenuStripDurumlar;
            ara = "durumlar";
            tb_ara.Enabled = true;
        }

        private void seçiliDurumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Bu işlem geri alınamaz.... \n Seçili durumu silmek istediğinizden emin misiniz? ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.OK)
            {

                DataGridViewRow secili = Main_Grid.CurrentRow;
                int durumNo = Convert.ToInt16(secili.Cells["Durum No"].Value);

                db.kargoIslemleri.durumSil(durumNo);
                MessageBox.Show("Silme işlemi başarılı..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Main_Grid.DataSource = db.kargoIslemleri.durumlariGetir();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void seçiliYetkiyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Bu işlem geri alınamaz.... \n Seçili personeli silmek istediğinizden emin misiniz? ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
           if (sonuc == DialogResult.OK)
            {
                DataGridViewRow secili = Main_Grid.CurrentRow;
                int kNo = Convert.ToInt16(secili.Cells["Kimlik No"].Value);
                 db.uyeIslemleri.yetkiSil(kNo);
                MessageBox.Show("Silme işlemi başarılı..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  Main_Grid.DataSource = db.uyeIslemleri.YetkilileriGetir();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void ucretEkle_Click(object sender, EventArgs e)
        {
            fiyatEkle s = new fiyatEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.ucretIslem.ucretleriGetir();
           Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ara = "ucretler";
            tb_ara.Enabled = true;
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;


        }






        private void ücretSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult sonuc;
            sonuc = MessageBox.Show("Bu işlem geri alınamaz.... \n Seçili ücreti silmek istediğinizden emin misiniz? ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.OK)
            {
                int gonderiTuruu;
                DataGridViewRow secili = Main_Grid.CurrentRow;
                int mNo = Convert.ToInt16(secili.Cells["Müşteri No"].Value);
                string gTuru= secili.Cells["Gönderi Türü"].Value.ToString();

                if (gTuru == "Dosya") gonderiTuruu = 0; else gonderiTuruu = 1;

                db.ucretIslem.ucretSil(gonderiTuruu, mNo);
                MessageBox.Show("Silme işlemi başarılı..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Main_Grid.DataSource = db.ucretIslem.ucretleriGetir();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }












        private void ücretEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fiyatEkle s = new fiyatEkle();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.ucretIslem.ucretleriGetir();
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ara = "ucretler";
            tb_ara.Enabled = true;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.adresIslem.TUMadresleriGetir();
            Main_Grid.ContextMenuStrip = contextMenuAdresler;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "adresler";
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;

        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.musteriIslemleri.musterileriGetir();
            Main_Grid.ContextMenuStrip = null;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "musteriler";
            lbl_ara.Visible = true;
            lblRapor.Visible = false;
            cbRaporlar.Visible = false;

        }

        private void btnFaturaListele_Click(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.ucretIslem.faturalariGetir();
            Main_Grid.ContextMenuStrip = null;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "faturalar";
            cbRaporlar.Visible = false;

            lbl_ara.Visible = true;
            lblRapor.Visible = false;

        }

        private void yeniYetkiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yetkiEkrani s = new yetkiEkrani();
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.ContextMenuStrip = contextMenuStripDurumlar;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ara = "durumlar";
            tb_ara.Enabled = true;
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void adresiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Bu işlem geri alınamaz.... \n Seçili adresi silmek istediğinizden emin misiniz? ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.OK)
            {
                DataGridViewRow secili = Main_Grid.CurrentRow;
                int aNo = Convert.ToInt16(secili.Cells["Adres No"].Value);
                db.adresIslem.adresiSil(aNo);
                MessageBox.Show("Silme işlemi başarılı..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main_Grid.DataSource = db.adresIslem.TUMadresleriGetir();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnRapolar_Click(object sender, EventArgs e)
        {
            lbl_ara.Visible = false;
            lblRapor.Visible = true;
            cbRaporlar.Visible = true;
        }

        private void cbRaporlar_SelectedIndexChanged(object sender, EventArgs e)
        { int secili = cbRaporlar.SelectedIndex;
            if (secili == 1)
            {
                Main_Grid.DataSource = db.kargoIslemleri.cikisSubesineGoreKargolar();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if(secili == 2)
            {
                Main_Grid.DataSource = db.uyeIslemleri.subelereGoreYetkililer();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (secili == 3)
            {
                Main_Grid.DataSource = db.kargoIslemleri.subelereGoreOrtalamaUcret();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (secili == 4)
            {
                Main_Grid.DataSource = db.kargoIslemleri.subelereGoretoplamKazanc();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            else if (secili == 5)
            {
                Main_Grid.DataSource = db.kargoIslemleri.genelToplamUcret();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }



            else if (secili == 6)
            {
                Main_Grid.DataSource = db.subeIslem.toplamSubeSayisi();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }



            else if (secili == 7)
            {
                Main_Grid.DataSource = db.uyeIslemleri.toplamPersonelSayisi();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            else if (secili == 8)
            {
                Main_Grid.DataSource = db.kargoIslemleri.toplamGonderiSayisi();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            else if (secili == 9)
            {
                Main_Grid.DataSource = db.kargoIslemleri.subeyeGoreTeslimEdilenler();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            else if (secili == 10)
            {
                Main_Grid.DataSource = db.kargoIslemleri.subeyeGoreTeslimEdilmeyenler();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }



        }
    }

    internal class RegEx
    {
        private string v;

        public RegEx(string v)
        {
            this.v = v;
        }
    }
}
