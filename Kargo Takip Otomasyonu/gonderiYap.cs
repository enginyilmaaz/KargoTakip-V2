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
    public partial class gonderiYap : Form
    {


        int gonderiTuru;
        decimal Desi;
        decimal FiyatBelirle;
        public static string DesiHesapla;
        bool yeniMusteriG = false;
        bool yeniMusteriA = false;
        bool yeniAdresG = false;
        bool yeniAdresA = false;
        int AliciAdresNo;
        int GonderenAdresNo;
        string aliciMusteriNo;
        string gonderenMusteriNo;
        string AliciMusteri;
     
        string IslemiYapanTCNO; //tckno
        string cikisSubesi;  // cikis subeAdı
        int cikisSubeNo;


        int teslimatSekli;

        public gonderiYap(string tcno)
        {
            InitializeComponent();

            IslemiYapanTCNO = tcno;

            DataRow yetkili = db.uyeIslemleri.YetkiliGetir(tcno);
            cikisSubesi = yetkili["Şube Adı"].ToString();
            cikisSubeNo = Convert.ToInt16(yetkili["Şube No"]);


        }

      
    

        private void gonderiYap_Load(object sender, EventArgs e)
        {
            tbCikisSubesi.Text = cikisSubesi;
            cbGonderenSehir.DataSource = db.subeIslem.sehirGetir();
            cbGonderenSehir.ValueMember = "SehirId";
            cbGonderenSehir.DisplayMember = "SehirAdi";

            cbAliciSehir.DataSource = db.subeIslem.sehirGetir();
            cbAliciSehir.ValueMember = "SehirId";
            cbAliciSehir.DisplayMember = "SehirAdi";

        }

        private void cbGonderenSehir_SelectedIndexChanged(object sender, EventArgs e)
        {


         

            int sehirid;
            bool parseOK = Int32.TryParse(cbGonderenSehir.SelectedValue.ToString(), out sehirid);
            cbGonderenIlce.ValueMember = "ilceID";
            cbGonderenIlce.DisplayMember = "IlceAdi";
            cbGonderenIlce.DataSource = db.subeIslem.ilceGetir(sehirid);




        }

     


        private void cbAliciSehir_SelectedIndexChanged(object sender, EventArgs e)
        {


            int sehirid;
            bool parseOK = Int32.TryParse(cbAliciSehir.SelectedValue.ToString(), out sehirid);

            cbAliciIlce.DataSource = db.subeIslem.ilceGetir(sehirid);
            cbAliciIlce.ValueMember = "ilceID";
            cbAliciIlce.DisplayMember = "IlceAdi";

        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

       





        private void cbAliciSehir_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DesiHesapla s = new DesiHesapla();

            s.ShowDialog();

            tbDesi.Text = DesiHesapla;
        }

    




        public void UcretHesapla()
        {


            decimal BirimUcret=1;

            if (tbDesi.TextLength > 0)

            {
                
               
                if (cbGonderiTuru.Text == "Dosya") gonderiTuru = 0;
                else if (cbGonderiTuru.Text == "Paket") gonderiTuru = 1;


              DataTable Gond = db.ucretIslem.ucretGetirKimlikNosunaGore(gonderiTuru,tbGonderenTCNo.Text);

                Desi = Convert.ToDecimal(tbDesi.Text);

                if (Gond.Rows.Count > 0)
                {
                   BirimUcret = Convert.ToDecimal(Gond.Rows[0]["birimUcret"]);

                }

                else
                {
                    if (cbGonderenMusteriTuru.Text == "Bireysel" && cbGonderiTuru.Text == "Dosya") BirimUcret = 7;
                    if (cbGonderenMusteriTuru.Text == "Bireysel" && cbGonderiTuru.Text == "Paket") BirimUcret = 4;
                    if (cbGonderenMusteriTuru.Text == "Kurumsal" && cbGonderiTuru.Text == "Dosya") BirimUcret = 4;
                    if (cbGonderenMusteriTuru.Text == "Kurumsal" && cbGonderiTuru.Text == "Paket") BirimUcret = 2;
                }




                FiyatBelirle = Desi * BirimUcret;
                tbUcret.Text = FiyatBelirle.ToString();
            }

            else tbUcret.Clear();


        }


     

        private void cbGonderiTuru_TextChanged(object sender, EventArgs e)
        {
            if (cbGonderiTuru.Text != "Seçiniz...")
            { tickGonderiTuru.Visible = true; }
            else tickGonderiTuru.Visible = false;


            UcretHesapla();
        }



        private void tbDesi_TextChanged(object sender, EventArgs e)
        {
            if (tbDesi.TextLength > 0)
            { tickDesi.Visible = true; }
            else tickDesi.Visible = false;
            UcretHesapla();




        }



        private void tbGonderenAdSoyad_TextChanged(object sender, EventArgs e)
        {
            if (tbGonderenAdSoyad.TextLength > 6)
            { tickGonderenAd.Visible = true; }
            else tickGonderenAd.Visible = false;
        }



        private void tbAliciAdSoyad_TextChanged(object sender, EventArgs e)
        {
            if (tbAliciAdSoyad.TextLength > 6)
            { tickAliciAd.Visible = true; }
            else tickAliciAd.Visible = false;
        }





        private void tbGonderenTCNo_TextChanged_1(object sender, EventArgs e)
        {
            if (tbGonderenTCNo.TextLength > 10)
            {
                tickGonderenTC.Visible = true;

               
                DataTable GonderenAdresKontrol = db.adresIslem.adresleriGetir(tbGonderenTCNo.Text);

                if (GonderenAdresKontrol.Rows.Count > 0)
                {
                    cbGonderenKayitliAdres.Enabled = true;
                    
                    cbGonderenKayitliAdres.DataSource = GonderenAdresKontrol;
                    cbGonderenKayitliAdres.ValueMember = "adresNO";
                    cbGonderenKayitliAdres.DisplayMember = "IlceAdi";
    
                }

                else
                {
                    cbGonderenKayitliAdres.Enabled = false;
                   


                }


            }

            else {
             


                tbGonderenAdSoyad.Text = "";
                tbGonderenTelNo.Text = "";

                cbGonderenSehir.SelectedIndex = 0;

                cbGonderenIlce.SelectedIndex = 0;
                tbGonderenAdres.Text = "";
                tbGonderenPK.Text = "";

                cbGonderenMusteriTuru.SelectedIndex = 0;

                tickGonderenTC.Visible = false;
                cbGonderenKayitliAdres.Enabled = false;
               
                cbGonderenKayitliAdres.DataSource = null;
            }




        }


        private void tbAliciTCNo_TextChanged(object sender, EventArgs e)
        {

            if (tbAliciTCNo.TextLength > 10)
            {
                tickAliciTC.Visible = true;
               
                DataTable AliciadresKontrol = db.adresIslem.adresleriGetir(tbAliciTCNo.Text);


                if (AliciadresKontrol.Rows.Count > 0)
                {
                    cbAliciKayitliAdres.Enabled = true;
                    
                    cbAliciKayitliAdres.DataSource = AliciadresKontrol;
                    cbAliciKayitliAdres.ValueMember = "adresNO";
                    cbAliciKayitliAdres.DisplayMember = "IlceAdi";
                }

                else
                {
                    cbAliciKayitliAdres.Enabled = false;
                   


                }


            }



            else {


                tbAliciAdSoyad.Text = "";
                tbAliciTelNo.Text = "";

                cbAliciSehir.SelectedIndex = 0;

                cbAliciIlce.SelectedIndex = 0;
                tbAliciAdres.Text = "";
                tbAliciPK.Text = "";

                cbAliciMusteriTuru.SelectedIndex = 0;

                tickAliciTC.Visible = false;
                cbAliciKayitliAdres.Enabled = false;
               
                cbAliciKayitliAdres.DataSource = null;


            }
        }

        private void tbAliciTelNo_TextChanged(object sender, EventArgs e)
        {
            if (tbAliciTelNo.TextLength > 9)
            { tickAliciTelNo.Visible = true; }
            else tickAliciTelNo.Visible = false;
        }

        private void tbGonderenTelNo_TextChanged(object sender, EventArgs e)
        {
            if (tbGonderenTelNo.TextLength > 9)
            { tickGonderenTelNo.Visible = true; }
            else tickGonderenTelNo.Visible = false;
        }

        private void tbGonderenAdres_TextChanged(object sender, EventArgs e)
        {
            if (tbGonderenAdres.TextLength > 15)
            { tickGonderenAdres.Visible = true; }
            else tickGonderenAdres.Visible = false;
        }

        private void tbAliciAdres_TextChanged(object sender, EventArgs e)
        {
            if (tbAliciAdres.TextLength > 15)
            { tickAliciAdres.Visible = true; }
            else tickAliciAdres.Visible = false;
        }

        private void tbGonderenPK_TextChanged(object sender, EventArgs e)
        {

            if (tbGonderenPK.TextLength > 4)
            { tickGonderenPK.Visible = true; }
            else tickGonderenPK.Visible = false;
        }

        private void tbAliciPK_TextChanged(object sender, EventArgs e)
        {
            if (tbAliciPK.TextLength > 4)
            { tickAliciPK.Visible = true; }
            else tickAliciPK.Visible = false;
        }

        

        private void cbAliciMusteriTuru_TextChanged(object sender, EventArgs e)
        {
            if (cbAliciMusteriTuru.Text != "Seçiniz...")
            { tickAliciMusTuru.Visible = true; }
            else tickAliciMusTuru.Visible = false;
        }

        private void cbGonderenMusteriTuru_TextUpdate(object sender, EventArgs e)
        {

        }

        private void cbGonderenMusteriTuru_TextChanged(object sender, EventArgs e)
        {
            if (cbGonderenMusteriTuru.Text != "Seçiniz...")
            { tickGonderenMusTuru.Visible = true; }
            else tickGonderenMusTuru.Visible = false;
        }

        private void tbGonderenTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbGonderenPK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbTeslimSubesi_TextChanged(object sender, EventArgs e)
        {
            if(cbTeslimSubesi.Text != "Seçiniz...")
            { tickTeslimAubesi.Visible = true; }
            else tickTeslimAubesi.Visible = false;
        }

        private void cbOdeyenTaraf_TextChanged(object sender, EventArgs e)
        {
            if (cbOdeyenTaraf.Text != "Seçiniz...")
            { tickUcretKimden.Visible = true; }
            else tickUcretKimden.Visible = false;
        }

        private void cbTeslimatSekli_TextChanged(object sender, EventArgs e)
        {
            if (cbTeslimatSekli.Text != "Seçiniz...")
            { tickTeslimatSekli.Visible = true; }
            else tickTeslimatSekli.Visible = false;
        }

        private void tbUcret_TextChanged(object sender, EventArgs e)
        {
            if (tbUcret.TextLength > 0)
            { tickUcret.Visible = true; }
            else tickUcret.Visible = false;
        }







        private void btnIslemiTamamla_Click(object sender, EventArgs e)
        {


              try
               {






            if (tickGonderenTC.Visible && tickGonderenAd.Visible && tickGonderenTelNo.Visible && tickGonderenSehir.Visible &&

            tickGonderenIlce.Visible && tickGonderenAdres.Visible && tickGonderenPK.Visible && tickGonderenMusTuru.Visible &&

            tickAliciTC.Visible && tickAliciAd.Visible && tickAliciTelNo.Visible && tickAliciSehir.Visible &&

            tickAliciIlce.Visible && tickAliciAdres.Visible && tickAliciPK.Visible && tickAliciMusTuru.Visible &&

            tickCikisSubesi.Visible && tickTeslimAubesi.Visible && tickUcretKimden.Visible && tickTeslimatSekli.Visible &&

            tickGonderiTuru.Visible && tickDesi.Visible && tickUcret.Visible)


            {
                bool odemeDurumu;
                bool odeyen = false;
                if (cbOdeyenTaraf.Text == "Alıcıdan") odeyen = false; odemeDurumu = false;
                if (cbOdeyenTaraf.Text == "Göndericiden") odeyen = true; odemeDurumu = true; ;

                bool odemesekli = false;
                if (cbOdemeSekli.Text == "Kredi Kartı") odeyen = false;
                if (cbOdemeSekli.Text == "Nakit") odeyen = true;




                db.ucretIslem.faturaOlustur(odeyen, odemesekli, FiyatBelirle, odemeDurumu, IslemiYapanTCNO); //fatura oluştur

                DataRow faturaIDal = db.ucretIslem.sonEklenenFaturaID(IslemiYapanTCNO); // son eklenen fatura
                int faturaID = Convert.ToInt16(faturaIDal["FaturaID"]);



                if (yeniMusteriG == true)  //müşteri yoksa oluştur
                {

                    int musTur = 0; ;
                    if (cbGonderenMusteriTuru.Text == "Bireysel") musTur = 0;
                    if (cbGonderenMusteriTuru.Text == "Kurumsal") musTur = 1;

                    db.musteriIslemleri.musteriEkle(tbGonderenTCNo.Text,tbGonderenAdSoyad.Text, musTur);  // müşteriyi ekler

                    DataTable GonderenMusteriKontrol = db.musteriIslemleri.musteriGetir(tbGonderenTCNo.Text);
                    if (GonderenMusteriKontrol.Rows.Count > 0)  //eklenen müşteri noyu çeker
                    {

                        gonderenMusteriNo = GonderenMusteriKontrol.Rows[0]["musteriNO"].ToString(); //müşteri no yu global değişkene aktarır



                    }

                    //daha sonra adresi oulştur


                    int GondILCEID;
                    bool parseOKK = Int32.TryParse(cbGonderenIlce.SelectedValue.ToString(), out GondILCEID); //gönderen ilçe id sını değişkene aktarır
                    db.adresIslem.adresEkle(gonderenMusteriNo, tbGonderenAdres.Text, GondILCEID, tbGonderenPK.Text, tbGonderenTelNo.Text);
                    //adres eklemek için




                    DataRow gonAdresNOGetir = db.adresIslem.adresiGetiradresBilgisineGore(tbGonderenAdres.Text, GondILCEID); //kaydedilen adresNo bilgisini çeker

                    GonderenAdresNo = Convert.ToInt16(gonAdresNOGetir["aadresNO"]); //adresno bilgisini aldık gönderici için


                }

                else //müşteri varsa adres kontrolü yap

                {
                    if (yeniAdresG == true) //kayıtlı adres yoksa yada olup da kullanılmayacksa girilen adresi kaydet

                    {
                        DataTable GonderenMusteriKontrol = db.musteriIslemleri.musteriBilgiGetir(tbGonderenTCNo.Text);
                        gonderenMusteriNo = GonderenMusteriKontrol.Rows[0]["musteriNO"].ToString(); //müşteri no yu global değişkene aktarır

                        int GondIlceid;
                        bool parseOK = Int32.TryParse(cbGonderenIlce.SelectedValue.ToString(), out GondIlceid);

                        db.adresIslem.adresEkle(gonderenMusteriNo, tbGonderenAdres.Text, GondIlceid, tbGonderenPK.Text, tbGonderenTelNo.Text);
                        //adres eklemek için

                        int GondILCEID;
                        bool parseOKK = Int32.TryParse(cbGonderenIlce.SelectedValue.ToString(), out GondILCEID); //gönderen ilçe id sını değişkene aktarır
                        DataRow gonAdresNOGetir = db.adresIslem.adresiGetiradresBilgisineGore(tbGonderenAdres.Text, GondILCEID); //kaydedilen adresNo bilgisini çeker

                        GonderenAdresNo = Convert.ToInt16(gonAdresNOGetir["aadresNO"]);  //adresno yu global değişkene aktarır


                    }

                    else // kayıtlı adres varsa onu kullan


                    {
                        int gonderenadresNo;
                        bool parseOK = Int32.TryParse(cbGonderenKayitliAdres.SelectedValue.ToString(), out gonderenadresNo); //kayıtlı gönderici için adresNo yu aktarır
                        GonderenAdresNo = gonderenadresNo;
                    }

                }


                if (yeniMusteriA == true)  //müşteri yoksa oluştur
                {

                    int musTur = 0; ;
                    if (cbAliciMusteriTuru.Text == "Bireysel") musTur = 0;
                    if (cbAliciMusteriTuru.Text == "Kurumsal") musTur = 1;

                    db.musteriIslemleri.musteriEkle( tbAliciTCNo.Text, tbAliciAdSoyad.Text, musTur);  // müşteriyi ekler

                    DataTable aliciMusteriKontrol = db.musteriIslemleri.musteriBilgiGetir(tbAliciTCNo.Text);
                    if (aliciMusteriKontrol.Rows.Count > 0)  //eklenen müşteri noyu çeker
                    {

                        aliciMusteriNo = aliciMusteriKontrol.Rows[0]["musteriNO"].ToString(); //müşteri no yu global değişkene aktarır



                    }

                    //daha sonra adresi oulştur


                    int aILCEID;
                    bool parseOKK = Int32.TryParse(cbAliciIlce.SelectedValue.ToString(), out aILCEID); //gönderen ilçe id sını değişkene aktarır
                    db.adresIslem.adresEkle(aliciMusteriNo, tbAliciAdres.Text,aILCEID, tbAliciPK.Text, tbAliciTelNo.Text);
                    //adres eklemek için




                    DataRow aAdresNOGetir = db.adresIslem.adresiGetiradresBilgisineGore(tbAliciAdres.Text, aILCEID); //kaydedilen adresNo bilgisini çeker

                   AliciAdresNo = Convert.ToInt16(aAdresNOGetir["aadresNO"]); //adresno bilgisini aldık gönderici için


                }

                else //müşteri varsa adres kontrolü yap

                {
                    if (yeniAdresA == true) //kayıtlı adres yoksa yada olup da kullanılmayacksa girilen adresi kaydet

                    {
                        DataTable aliciMusteriKontrol = db.musteriIslemleri.musteriBilgiGetir(tbAliciTCNo.Text);
                        aliciMusteriNo = aliciMusteriKontrol.Rows[0]["musteriNO"].ToString(); //müşteri no yu global değişkene aktarır

                        int aILCEID;
                        bool parseOK = Int32.TryParse(cbAliciIlce.SelectedValue.ToString(), out aILCEID);

                        db.adresIslem.adresEkle(aliciMusteriNo, tbAliciAdres.Text, aILCEID, tbAliciPK.Text, tbAliciTelNo.Text);
                        //adres eklemek için

                       
                        DataRow aAdresNOGetir = db.adresIslem.adresiGetiradresBilgisineGore(tbAliciAdres.Text, aILCEID); //kaydedilen adresNo bilgisini çeker

                        AliciAdresNo = Convert.ToInt16(aAdresNOGetir["aadresNO"]);  //adresno yu global değişkene aktarır


                    }

                    else // kayıtlı adres varsa onu kullan


                    {
                        int aliciadresNo;
                        bool parseOK = Int32.TryParse(cbAliciKayitliAdres.SelectedValue.ToString(), out aliciadresNo); //kayıtlı gönderici için adresNo yu aktarır
                        AliciAdresNo = aliciadresNo;
                    }

                }




              


                if (cbGonderiTuru.Text == "Dosya") gonderiTuru = 0;
                else if (cbGonderiTuru.Text == "Paket") gonderiTuru = 1;


                if (cbTeslimatSekli.Text == "Adrese Teslim") teslimatSekli = 0;
                else if (cbTeslimatSekli.Text == "Şubeden Teslim") teslimatSekli = 1;

                

                DateTime suankiTarih = DateTime.Now;
                string kargoAlimZamani = suankiTarih.ToString("yyyy-MM-dd HH:mm:ss");
       

                
                db.kargoIslemleri.gonderiYap(GonderenAdresNo, AliciAdresNo, gonderiTuru, Convert.ToInt16(tbDesi.Text),faturaID,
                    teslimatSekli, cikisSubeNo,
                     Convert.ToInt16(cbTeslimSubesi.SelectedValue), kargoAlimZamani, IslemiYapanTCNO);





               DataRow gonderiTakip = db.kargoIslemleri.kargoGetir(kargoAlimZamani, GonderenAdresNo, AliciAdresNo);



               string gonderiTakipNo = gonderiTakip["gonderi_takip_no"].ToString();







               DialogResult secenek = MessageBox.Show("Kargo girişi başarılı.. \nGönderi Takip No:" + gonderiTakipNo, "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

              if (secenek == DialogResult.OK) this.Close();


            }





                else { MessageBox.Show("Bir yada birden fazla bilgi girişi eksik yapıldı, lütfen düzeltin", "Eksik Giriş Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }
        

       catch (Exception)// 
          {
            MessageBox.Show("Bir hata oluştu, lütfen tekrar deneyin..", "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

      }




        }  // işlemi tamamla sonu







        private void tbGonderenAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }



    






        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tbGonderenTCNo.TextLength == 11 && cbGonderenKayitliAdres.DataSource!=null)
            {
                int adresNO;
                bool parseOK = Int32.TryParse(cbGonderenKayitliAdres.SelectedValue.ToString(), out adresNO);

                string gonderenMusteri;
                DataRow adresiGetir = db.adresIslem.adresiGetir(adresNO);
                tbGonderenAdSoyad.Text = adresiGetir["musAdSoyad"].ToString();
                tbGonderenTelNo.Text = adresiGetir["adresTelefon"].ToString();
                string gonderenSehir = adresiGetir["SehirAdi"].ToString();
                cbGonderenSehir.SelectedIndex = cbGonderenSehir.FindStringExact(gonderenSehir);
                string gonderenIlce = adresiGetir["IlceAdi"].ToString();
                cbGonderenIlce.SelectedIndex = cbGonderenIlce.FindStringExact(gonderenIlce);
                tbGonderenAdres.Text = adresiGetir["adresBilgi"].ToString();
                tbGonderenPK.Text = adresiGetir["adresPK"].ToString();
                int gonderenMusteriTuru = Convert.ToInt16(adresiGetir["musTur"]);
                if (gonderenMusteriTuru == 0) gonderenMusteri = "Bireysel";
                else gonderenMusteri = "Kurumsal";
                cbGonderenMusteriTuru.SelectedIndex = cbGonderenMusteriTuru.FindStringExact(gonderenMusteri);


            }
        }







        private void pbAliciAdresGetir_Click(object sender, EventArgs e)
        {
            if (tbAliciTCNo.TextLength == 11 && cbAliciKayitliAdres.DataSource != null)
            {
                int adresNO;
                bool parseOK = Int32.TryParse(cbAliciKayitliAdres.SelectedValue.ToString(), out adresNO);


                DataRow adresiGetir = db.adresIslem.adresiGetir(adresNO);
                tbAliciAdSoyad.Text = adresiGetir["musAdSoyad"].ToString();
                tbAliciTelNo.Text = adresiGetir["adresTelefon"].ToString();
                string AliciSehir = adresiGetir["SehirAdi"].ToString();
                cbAliciSehir.SelectedIndex = cbAliciSehir.FindStringExact(AliciSehir);
                string AliciIlce = adresiGetir["IlceAdi"].ToString();
                cbAliciIlce.SelectedIndex = cbAliciIlce.FindStringExact(AliciIlce);
                tbAliciAdres.Text = adresiGetir["adresBilgi"].ToString();
                tbAliciPK.Text = adresiGetir["adresPK"].ToString();
                int AliciMusteriTuru = Convert.ToInt16(adresiGetir["musTur"]);
                if (AliciMusteriTuru == 0) AliciMusteri = "Bireysel";
                else AliciMusteri = "Kurumsal";
                cbAliciMusteriTuru.SelectedIndex = cbAliciMusteriTuru.FindStringExact(AliciMusteri);


            }
        }









        private void pbGondYeniAdres_Click(object sender, EventArgs e)
        {
            yeniAdresG = false;
            cbGonderenKayitliAdres.DataSource = null;
            tbGonderenAdSoyad.Text = "";
            tbGonderenTelNo.Text = "";
            cbGonderenSehir.SelectedIndex = 0;

            cbGonderenIlce.SelectedIndex = 0;
            tbGonderenAdres.Text = "";
            tbGonderenPK.Text = "";

            cbGonderenMusteriTuru.SelectedIndex = 0;

        }










        private void pbAliciYeniAdres_Click(object sender, EventArgs e)
        {
            yeniAdresA = false;
            cbAliciKayitliAdres.DataSource = null;
            tbAliciAdSoyad.Text = "";
            tbAliciTelNo.Text = "";
           
            cbAliciSehir.SelectedIndex = 0;

            cbAliciIlce.SelectedIndex = 0;
            tbAliciAdres.Text = "";
            tbAliciPK.Text = "";

            cbAliciMusteriTuru.SelectedIndex = 0;
        }








        private void cbAliciIlce_SelectedIndexChanged(object sender, EventArgs e)
        {

            int ilceID;
            bool parseOK = Int32.TryParse(cbAliciIlce.SelectedValue.ToString(), out ilceID);
            cbTeslimSubesi.DataSource = db.subeIslem.teslimSubeleriGetir(ilceID);
            cbTeslimSubesi.DisplayMember = "subeAdi";
            cbTeslimSubesi.ValueMember = "subeNo";
        }

        private void tbGonderenTCNo_TextChanged(object sender, EventArgs e)
        {
            UcretHesapla();
            if (tbGonderenTCNo.TextLength > 10)
            {
                tickGonderenTC.Visible = true;

                DataTable GonderenMusteriKontrol = db.musteriIslemleri.musteriGetir(tbGonderenTCNo.Text); //müşteri kontrol sql sorgusunu çalıştırır

                if (GonderenMusteriKontrol.Rows.Count > 0)  // müşteri varsa çalışır
                { 
                    yeniMusteriG = false;  // girilen müşterin kayıtlı olduğunu belirtir
                    gonderenMusteriNo = GonderenMusteriKontrol.Rows[0]["musteriNO"].ToString(); //müşteri no yu global değişkene aktarır


                    DataTable GonderenAdresKontrol = db.adresIslem.adresleriGetir(tbGonderenTCNo.Text); // girilen tc no ile ilişkili adres varsa datatable'a aktarır

                    if (GonderenAdresKontrol.Rows.Count > 0)  // varolan müşterinin adresleri varsa aşağısı çalışır
                    {
                        cbGonderenKayitliAdres.Enabled = true; // adres seçimi aktif olur

                        cbGonderenKayitliAdres.DataSource = GonderenAdresKontrol; 
                        cbGonderenKayitliAdres.ValueMember = "adresNO";
                        cbGonderenKayitliAdres.DisplayMember = "IlceAdi";
                        
                    }

                    else  // müşterinin adresi yoksa aşağısı çalışır
                    {
                        cbGonderenKayitliAdres.Enabled = false;
                      
                        yeniAdresG = true;

                    }



                }
                else //müşteri bilgisi yoksa aşağı çalışır

                {
                    yeniMusteriG = true; }




           

            }

            else {



                tbGonderenAdSoyad.Text = "";
                tbGonderenTelNo.Text = "";

                cbGonderenSehir.SelectedIndex = 0;

                cbGonderenIlce.SelectedIndex = 0;
                tbGonderenAdres.Text = "";
                tbGonderenPK.Text = "";

                cbGonderenMusteriTuru.SelectedIndex = 0;

                tickGonderenTC.Visible = false;
                cbGonderenKayitliAdres.Enabled = false;

                cbGonderenKayitliAdres.DataSource = null;
            }

        }

        private void tbAliciTCNo_TextChanged_1(object sender, EventArgs e)
        {
            if (tbAliciTCNo.TextLength > 10)
            {
                tickAliciTC.Visible = true;

                DataTable aliciMusteriKontrol = db.musteriIslemleri.musteriGetir(tbAliciTCNo.Text); //müşteri kontrol sql sorgusunu çalıştırır

                if (aliciMusteriKontrol.Rows.Count > 0)  // müşteri varsa çalışır
                {
                    yeniMusteriA = false;  // girilen müşterin kayıtlı olduğunu belirtir
                    aliciMusteriNo = aliciMusteriKontrol.Rows[0]["musteriNO"].ToString(); //müşteri no yu global değişkene aktarır


                    DataTable aliciAdresKontrol = db.adresIslem.adresleriGetir(tbAliciTCNo.Text); // girilen tc no ile ilişkili adres varsa datatable'a aktarır

                    if (aliciAdresKontrol.Rows.Count > 0)  // varolan müşterinin adresleri varsa aşağısı çalışır
                    {
                        cbAliciKayitliAdres.Enabled = true; // adres seçimi aktif olur

                        cbAliciKayitliAdres.DataSource = aliciAdresKontrol;
                        cbAliciKayitliAdres.ValueMember = "adresNO";
                        cbAliciKayitliAdres.DisplayMember = "IlceAdi";

                    }

                    else  // müşterinin adresi yoksa aşağısı çalışır
                    {
                        cbAliciKayitliAdres.Enabled = false;

                        yeniAdresA = true;

                    }



                }
                else //müşteri bilgisi yoksa aşağı çalışır

                {
                    yeniMusteriA = true;
                }


            }



            else {


                tbAliciAdSoyad.Text = "";
                tbAliciTelNo.Text = "";

                cbAliciSehir.SelectedIndex = 0;

                cbAliciIlce.SelectedIndex = 0;
                tbAliciAdres.Text = "";
                tbAliciPK.Text = "";

                cbAliciMusteriTuru.SelectedIndex = 0;

                tickAliciTC.Visible = false;
                cbAliciKayitliAdres.Enabled = false;

                cbAliciKayitliAdres.DataSource = null;


            }
        }

        private void cbGonderenMusteriTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcretHesapla();
        }

        private void cbGonderiTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcretHesapla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int GondILCEID;
            bool parseOKK = Int32.TryParse(cbGonderenIlce.SelectedValue.ToString(), out GondILCEID); //gönderen ilçe id sını değişkene aktarır

            DataRow gonAdresNOGetir = db.adresIslem.adresiGetiradresBilgisineGore(tbGonderenAdres.Text, GondILCEID); //kaydedilen adresNo bilgisini çeker

            tbAliciAdres.Text = gonAdresNOGetir["aadresNO"].ToString(); //adresno bilgisini aldık gönderici için
        }
    }
}