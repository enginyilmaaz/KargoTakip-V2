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
    public partial class subeEkrani : Form
    {
        string subeNo;
        string subeAdi;
        string tckno;
        string ara;

        public subeEkrani(string tcno, string adsoyad, string yetkiAciklamasi, string FormAdi,string subeAd)
        {
            InitializeComponent();
           
            if (yetkiAciklamasi == "Şube Personeli")
            {

                
                btnPersonelListesi.Enabled = false;
                            btnSubeDegistir.Enabled = false;
                btnRapolar.Enabled = false;
            }


            DataRow yetkili = db.uyeIslemleri.YetkiliGetir(tcno);
            tckno = yetkili["Kimlik NO"].ToString();
            string yetkiliadSoyad = yetkili["Ad Soyad"].ToString();
            subeNo = yetkili["Şube No"].ToString();
            subeAdi = yetkili["Şube Adı"].ToString();


            lbl_yetkili_adi.Text = yetkiliadSoyad + ", TC No: " + tcno + ", Şube: " + subeAdi;
        }

        private void subeYoneticisi_Load(object sender, EventArgs e)
        {
            cbRaporlar.SelectedIndex = 0;
            Main_Grid.DataSource = db.subeIslem.subeyiListele(Convert.ToInt16(subeNo));
            Main_Grid.AutoResizeColumns();
             Main_Grid.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
        }

         private void btnPersonelListesi_Click(object sender, EventArgs e)
        {
            lblRapor.Visible = false;
            lbl_ara.Visible = true;
            cbRaporlar.Visible = false;
            ara = "yetkililer";
            lblRapor.Visible = false;
            lbl_ara.Visible = true;
            cbRaporlar.Visible = false;
            Main_Grid.DataSource = db.uyeIslemleri.seciliSubeninYetkilileriGetir(Convert.ToInt16(subeNo));
            Main_Grid.ContextMenuStrip = contextMenuStripPersoneller;
            Main_Grid.AutoResizeColumns();
             Main_Grid.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSubeListele_Click(object sender, EventArgs e)
        {
            lblRapor.Visible = false;
            lbl_ara.Visible = true;
            cbRaporlar.Visible = false;
            subeGuncelle s = new subeGuncelle(Convert.ToInt16(subeNo));
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.subeIslem.subeyiListele(Convert.ToInt16(subeNo));
            Main_Grid.AutoResizeColumns();
             Main_Grid.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void personelGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ara = "personeller";
            DataGridViewRow seciliYetkili = Main_Grid.CurrentRow;
            string yetkiliTC = seciliYetkili.Cells["Kimlik NO"].Value.ToString();
            yetkiliGuncelle s = new yetkiliGuncelle(yetkiliTC,false);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
            Main_Grid.DataSource = db.uyeIslemleri.seciliSubeninYetkilileriGetir(Convert.ToInt16(subeNo));
            Main_Grid.ContextMenuStrip = contextMenuStripPersoneller;
            Main_Grid.AutoResizeColumns();
             Main_Grid.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ara = "personeller";
            DialogResult sonuc;
            sonuc = MessageBox.Show("Bu işlem geri alınamaz.... \n Seçili kullancıyı silmek istediğinizden emin misiniz? ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.OK)
            {

                DataGridViewRow seciliYetkili = Main_Grid.CurrentRow;
                string yetkiliTC = seciliYetkili.Cells["Kimlik No"].Value.ToString();

                db.uyeIslemleri.yetkiliSil(yetkiliTC);

                MessageBox.Show("Silme işlemi başarılı..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main_Grid.DataSource = db.uyeIslemleri.seciliSubeninYetkilileriGetir(Convert.ToInt16(subeNo));
                Main_Grid.ContextMenuStrip = contextMenuStripPersoneller;
                Main_Grid.AutoResizeColumns();
                 Main_Grid.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
            }


        }

        private void btnGonderiYap_Click(object sender, EventArgs e)
        {
            ara = "kargolar";
            lblRapor.Visible = false;
            lbl_ara.Visible = true;
            cbRaporlar.Visible = false;
            gonderiYap s = new gonderiYap(tckno);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;
           Main_Grid.DataSource = db.kargoIslemleri.kargolariGetir();
           Main_Grid.ContextMenuStrip = contextMenuStripKargolar;
           Main_Grid.AutoResizeColumns();
            Main_Grid.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnKargolariListele_Click(object sender, EventArgs e)
        {
            lblRapor.Visible = false;
            lbl_ara.Visible = true;
            cbRaporlar.Visible = false;
            ara = "kargolar";
            Main_Grid.DataSource = db.kargoIslemleri.SubeyeGorekargolariGetir(Convert.ToInt16(subeNo));
            Main_Grid.ContextMenuStrip = contextMenuStripKargolar;
            Main_Grid.AutoResizeColumns();
             Main_Grid.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnMusterileriListele_Click(object sender, EventArgs e)
        {
            lblRapor.Visible = false;
            lbl_ara.Visible = true;
            cbRaporlar.Visible = false;
            ara = "musteriler";
            Main_Grid.DataSource = db.musteriIslemleri.musterileriGetir();
            Main_Grid.ContextMenuStrip = null;
            Main_Grid.AutoResizeColumns();
             Main_Grid.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
        }

    

        private void gönderiyiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ara = "kargolar";
            DataGridViewRow seciliGonderi = Main_Grid.CurrentRow;
            int takipNo = Convert.ToInt16(seciliGonderi.Cells["Takip No"].Value);



            gonderiGuncelle s = new gonderiGuncelle(takipNo, tckno);
            this.Visible = false;
            s.ShowDialog();
            this.Visible = true;

            Main_Grid.DataSource = db.kargoIslemleri.kargolariGetir();
            Main_Grid.ContextMenuStrip = contextMenuStripKargolar;
            Main_Grid.AutoResizeColumns();
             Main_Grid.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.AllCells;

        }

       



      

        private void şubeyeGöreOrtalamaÜcretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.kargoIslemleri.subeyeGoreOrtalamaUcret(Convert.ToInt16(subeNo));
        }

        private void teslimEdilenKargoSayısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void şubeToplamKargoSayısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Grid.DataSource = db.kargoIslemleri.subeyeToplamKargoSayisi(Convert.ToInt16(subeNo));      }

        private void Main_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ara == "kargolar")
            {
               
                DataGridViewRow seciliGonderi = Main_Grid.CurrentRow;
                int takipNo = Convert.ToInt16(seciliGonderi.Cells["Takip No"].Value);



                gonderiGuncelle s = new gonderiGuncelle(takipNo, tckno);
                this.Visible = false;
                s.ShowDialog();
                this.Visible = true;

                Main_Grid.DataSource = db.kargoIslemleri.kargolariGetir();
                Main_Grid.ContextMenuStrip = contextMenuStripKargolar;
                Main_Grid.AutoResizeColumns();
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
        }

        private void btnRapolar_Click(object sender, EventArgs e)
        {

            lbl_ara.Visible = false;
            lblRapor.Visible = true;
            cbRaporlar.Visible = true;
        }

        private void btnFaturaListele_Click(object sender, EventArgs e)
        {
            ara = "faturalar";
            Main_Grid.DataSource = db.ucretIslem.faturalariGetirSube(Convert.ToInt16(subeNo));
            Main_Grid.ContextMenuStrip = null;
            Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdresler_Click(object sender, EventArgs e)
        {
            lblRapor.Visible = false;
            lbl_ara.Visible = true;
            cbRaporlar.Visible = false;
            ara = "adresler";
            Main_Grid.DataSource = db.adresIslem.TUMadresleriGetir();
            Main_Grid.ContextMenuStrip = null;
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



                if (ara == "faturalar")
                {
                    Main_Grid.DataSource = db.ucretIslem.faturaAra(Convert.ToInt16(tb_ara.Text));
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }



            else if (tb_ara.TextLength <= 0)

            {
                if (ara == "yetkililer")

                {
                    Main_Grid.DataSource = db.uyeIslemleri.YetkilileriGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


           

                if (ara == "kargolar")

                {
                    Main_Grid.DataSource = db.kargoIslemleri.kargolariGetir();
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

                

                if (ara == "faturalar")
                {
                    Main_Grid.DataSource = db.ucretIslem.faturalariGetir();
                    Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }
        }

        private void cbRaporlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secili = cbRaporlar.SelectedIndex;
            if (secili == 1)
            {
                Main_Grid.DataSource = db.kargoIslemleri.subeyeGoreOrtalamaUcret(Convert.ToInt16(subeNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (secili == 2)
            {
                Main_Grid.DataSource = db.kargoIslemleri.subegenelToplamUcret(Convert.ToInt16(subeNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (secili == 3)
            {
                Main_Grid.DataSource = db.kargoIslemleri.subetoplamGonderiSayisi(Convert.ToInt16(subeNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (secili == 4)
            {
                Main_Grid.DataSource = db.kargoIslemleri.subeyeGoreTeslimEdilenListesi(Convert.ToInt16(subeNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }


            else if (secili == 5)
            {
                Main_Grid.DataSource = db.kargoIslemleri.subeyeGoreTeslimEdilmeyenListesi(Convert.ToInt16(subeNo));
                Main_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

        }
    }
    }