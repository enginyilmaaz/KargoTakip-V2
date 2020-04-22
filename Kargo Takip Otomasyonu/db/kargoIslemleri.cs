using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.db
{
    class kargoIslemleri
    {



        public static DataTable kargolariGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select gonderi_takip_no as [Takip No],
durumAciklama as [Durum],
f.FaturaID as [Fatura No],
case when kargoTuru=0 then 'Dosya' else 'Paket' end as [Kargo Türü] ,
mAlici.musKimlikNO as [Alıcı Kimlik No]  ,
mAlici.musAdSoyad as [Alıcı Bilgisi],
a.adresTelefon as [Alıcı Tel],
teslimat.subeAdi as [Teslimat Şubesi], 
a.adresBilgi as [Alıcı Adres],
ai.IlceAdi as [Alıcı İlçe], 
ash.SehirAdi as [Alıcı Şehir],  
a.adresPK as [Alıcı PK],
case when mAlici.musTur=0 then 'Bireysel' else 'Kurumsal' end as [Alıcı Türü] ,
case when teslimatSekli=0 then 'Adrese Teslim' else 'Şubeden Teslim' end as [Teslimat Türü] ,
k.kargoDesi as [Desi],
f.faturaTutari as [Ücret],
case when odeyenTaraf=0 then 'Alıcıdan' else 'Göndericiden' end as [Ücret Tahsil] ,
case when odemeSekli=0 then 'Bireysel' else 'Kurumsal' end as [Ödeme Türü] ,
mGond.musKimlikNO as [Gönderici Kimlik No]  ,
mGond.musAdSoyad as [Gönderici Bilgisi],
cikis.subeAdi as [Çıkış Şubesi], 
gond.adresTelefon as [Gönderici Tel],
gond.adresBilgi as [Gönderici Adres],
gi.IlceAdi as [Gönderici İlçe],
gsh.SehirAdi as [Gönderici Şehir],  
gond.adresPK [Gönderici PK],
case when mGond.musTur=0 then 'Bireysel' else 'Kurumsal' end as [Gönderici Türü] ,
kGiris.prsKimlikNo as [Kargo Girişi Yapan],
sistemeGirisZamani as [Kargo Alım Tarihi],
tEden.prsKimlikNo as [Teslim Eden],
teslimTarihi as [Teslim Tarihi],
teslimAlan as [Teslim Alan]
 from Kargolar as k 
join Adresler as a on k.aliciAdresNo=a.adresNO 
join Adresler as gond on k.gonderenAdresNo=gond.adresNO 
join Musteriler as mAlici on mAlici.musteriNO=a.musteriNO
join Musteriler as mGond on mGond.musteriNO=gond.musteriNO
join Subeler as teslimat on k.cikisSubeNo=teslimat.subeNo 
 join Subeler as cikis on k.teslimatSubeNo=cikis.subeNo
join Ilceler as ai on a.IlceID=ai.ilceID
join Ilceler as gi on gond.IlceID=gi.ilceID
join Sehirler as ash on  ai.SehirID=ash.SehirId
join Sehirler as gsh on gi.SehirID=gsh.SehirId
 join Personel as kGiris on k.girisYapanPrsKNO=kGiris.prsKimlikNo
 join Durumlar as d on k.durumID=d.durumID
 join Faturalar as f on k.FaturaID=f.FaturaID
left outer join Personel as tEden on k.teslimEdenPrsKNO=tEden.prsKimlikNo

";

            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable durumlariGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select 
durumID as [Durum No],
durumAciklama as [Durum Açıklaması] from durumlar where isActive=1 and durumID>1   ";
            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static void durumEkle(string durumAciklama)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Durumlar (durumAciklama)
                                            VALUES (@durumAciklama)";
            cmd.Parameters.AddWithValue("@durumAciklama", durumAciklama);
           

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }

        public static DataRow durumuGetir(int durumID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select 
durumID as [Durum No],
durumAciklama as [Durum Açıklaması] from durumlar  
where durumID=@durumID";
            cmd.Parameters.AddWithValue("@durumID", durumID);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }


        public static DataTable durumAra(string durum)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select durumID as [Durum No],
durumAciklama as [Durum Açıklaması] from durumlar where isActive=1 and durumID>1 and durumAciklama like @durum";
            cmd.Parameters.AddWithValue("@durum", "%" + durum + "%");
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static void durumGuncelle(string durumAciklama,int durumID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update  Durumlar set durumAciklama=@durumAciklama where durumID=@durumID";
            cmd.Parameters.AddWithValue("@durumAciklama", durumAciklama);
            cmd.Parameters.AddWithValue("@durumID", durumID);


            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }




        public static void durumSil(int durumID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update durumlar set isActive=0 wHERE durumID=@durumID";
            cmd.Parameters.AddWithValue("@durumID", durumID);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }








        public static DataTable SubeyeGorekargolariGetir(int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select 
gonderi_takip_no as [Takip No],
durumAciklama as [Durum],
f.FaturaID as [Fatura No],
case when kargoTuru=0 then 'Dosya' else 'Paket' end as [Kargo Türü] ,
mAlici.musKimlikNO as [Alıcı Kimlik No]  ,
mAlici.musAdSoyad as [Alıcı Bilgisi],
a.adresTelefon as [Alıcı Tel],
teslimat.subeAdi as [Teslimat Şubesi], 
a.adresBilgi as [Alıcı Adres],
ai.IlceAdi [Alıcı İlçe], 
ash.SehirAdi as [Alıcı Şehir],  
a.adresPK [Alıcı PK],
case when mAlici.musTur=0 then 'Bireysel' else 'Kurumsal' end as [Alıcı Türü] ,
case when teslimatSekli=0 then 'Adrese Teslim' else 'Şubeden Teslim' end as [Teslimat Türü] ,
k.kargoDesi as [Desi],
f.faturaTutari as [Ücret],
case when odeyenTaraf=0 then 'Alıcıdan' else 'Göndericiden' end as [Ücret Tahsil] ,
case when odemeSekli=0 then 'Bireysel' else 'Kurumsal' end as [Ödeme Türü] ,
mGond.musKimlikNO as [Gönderici Kimlik No]  ,
mGond.musAdSoyad as [Gönderici Bilgisi],
cikis.subeAdi as [Çıkış Şubesi], 
gond.adresTelefon as [Gönderici Tel],
gond.adresBilgi [Gönderici Adres],
gi.IlceAdi [Gönderici İlçe],
gsh.SehirAdi as [Gönderici Şehir],  
gond.adresPK [Gönderici PK],
case when mGond.musTur=0 then 'Bireysel' else 'Kurumsal' end as [Gönderici Türü] ,
kGiris.prsKimlikNo as [Kargo Girişi Yapan],
sistemeGirisZamani as [Kargo Alım Tarihi],
tEden.prsKimlikNo as [Teslim Eden],
teslimTarihi as [Teslim Tarihi],
teslimAlan as [Teslim Alan]
 from Kargolar as k 
join Adresler as a on k.aliciAdresNo=a.adresNO 
join Adresler as gond on k.gonderenAdresNo=gond.adresNO 
join Musteriler as mAlici on mAlici.musteriNO=a.musteriNO
join Musteriler as mGond on mGond.musteriNO=gond.musteriNO
join Subeler as teslimat on k.cikisSubeNo=teslimat.subeNo 
 join Subeler as cikis on k.teslimatSubeNo=cikis.subeNo
join Ilceler as ai on a.IlceID=ai.ilceID
join Ilceler as gi on gond.IlceID=gi.ilceID
join Sehirler as ash on  ai.SehirID=ash.SehirId
join Sehirler as gsh on gi.SehirID=gsh.SehirId
 join Personel as kGiris on k.girisYapanPrsKNO=kGiris.prsKimlikNo
 join Durumlar as d on k.durumID=d.durumID
 join Faturalar as f on k.FaturaID=f.FaturaID
left outer join Personel as tEden on k.teslimEdenPrsKNO=tEden.prsKimlikNo

where teslimat.SubeNo=@teslimSubesi or cikis.SubeNo=@cikisSubesi";

            cmd.Parameters.AddWithValue("@teslimSubesi", subeNo);
            cmd.Parameters.AddWithValue("@cikisSubesi", subeNo);

            return dbislem.SelectSorgusuCalistir(cmd);
        }



   











        public static DataRow kargoyuGetir(int TakipNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select gonderi_takip_no as [Takip No],
durumAciklama as [Durum],  f.FaturaID as [Fatura No],
case when kargoTuru=0 then 'Dosya' else 'Paket' end as [Kargo Türü] ,
mAlici.musKimlikNO as [Alıcı Kimlik No]  ,mAlici.musAdSoyad as [Alıcı Bilgisi],
a.adresTelefon as [Alıcı Tel],  teslimat.subeAdi as [Teslimat Şubesi], a.adresBilgi as [Alıcı Adres], 
ai.IlceAdi [Alıcı İlçe],  ash.SehirAdi as [Alıcı Şehir],  a.adresPK [Alıcı PK],
case when mAlici.musTur=0 then 'Bireysel' else 'Kurumsal' end as [Alıcı Türü] ,
case when teslimatSekli=0 then 'Adrese Teslim' else 'Şubeden Teslim' end as [Teslimat Türü] ,
k.kargoDesi as [Desi],  f.faturaTutari as [Ücret],
case when odeyenTaraf=0 then 'Alıcıdan' else 'Göndericiden' end as [Ücret Tahsil] ,
case when odemeSekli=0 then 'Bireysel' else 'Kurumsal' end as [Ödeme Türü] ,
mGond.musKimlikNO as [Gönderici Kimlik No]  ,mGond.musAdSoyad as [Gönderici Bilgisi],
cikis.subeAdi as [Çıkış Şubesi], gond.adresTelefon as [Gönderici Tel],gond.adresBilgi [Gönderici Adres],
gi.IlceAdi [Gönderici İlçe],gsh.SehirAdi as [Gönderici Şehir],  gond.adresPK [Gönderici PK],
case when mGond.musTur=0 then 'Bireysel' else 'Kurumsal' end as [Gönderici Türü] ,
kGiris.prsKimlikNo as [Kargo Girişi Yapan],sistemeGirisZamani as [Kargo Alım Tarihi],
tEden.prsKimlikNo as [Teslim Eden],teslimTarihi as [Teslim Tarihi],teslimAlan as [Teslim Alan]
from Kargolar as k 
join Adresler as a on k.aliciAdresNo=a.adresNO  join Adresler as gond on k.gonderenAdresNo=gond.adresNO 
join Musteriler as mAlici on mAlici.musteriNO=a.musteriNO join Musteriler as mGond on mGond.musteriNO=gond.musteriNO
join Subeler as teslimat on k.cikisSubeNo=teslimat.subeNo join Subeler as cikis on k.teslimatSubeNo=cikis.subeNo
join Ilceler as ai on a.IlceID=ai.ilceID   join Ilceler as gi on gond.IlceID=gi.ilceID
join Sehirler as ash on  ai.SehirID=ash.SehirId   join Sehirler as gsh on gi.SehirID=gsh.SehirId
join Personel as kGiris on k.girisYapanPrsKNO=kGiris.prsKimlikNo join Durumlar as d on k.durumID=d.durumID
 join Faturalar as f on k.FaturaID=f.FaturaID  left outer join Personel as tEden on k.teslimEdenPrsKNO=tEden.prsKimlikNo
where gonderi_takip_no=@gonderi_takip_no";
 cmd.Parameters.AddWithValue("@gonderi_takip_no", TakipNo);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }



        public static void gonderiYap(int gonderenAdresNo, int aliciAdresNo, int kargoTuru,
        int kargoDesi, int faturaID,int teslimatSekli, int cikisSubeNo, 
        int teslimatSubeNo, string kargoAlimZamani, string kargoGirisi_yetkiliTCNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Kargolar

   (gonderenAdresNo, aliciAdresNo, kargoTuru,  kargoDesi, FaturaID, durumID, teslimatSekli,  teslimatSubeNo,
cikisSubeNo, sistemeGirisZamani, girisYapanPrsKNO)  VALUES 
   (@gonderenAdresNo, @aliciAdresNo, @kargoTuru, @kargoDesi, @faturaID, 1,@teslimatSekli, 
@teslimatSubeNo, @cikisSubeNo, @kargoAlimZamani, @kargoGirisi_yetkiliTCNo)";


            cmd.Parameters.AddWithValue("@gonderenAdresNo", gonderenAdresNo);
            cmd.Parameters.AddWithValue("@aliciAdresNo", aliciAdresNo);
            cmd.Parameters.AddWithValue("@kargoTuru", kargoTuru);
            cmd.Parameters.AddWithValue("@kargoDesi", kargoDesi);
            cmd.Parameters.AddWithValue("@faturaID", faturaID);
            cmd.Parameters.AddWithValue("@teslimatSekli", teslimatSekli);
            cmd.Parameters.AddWithValue("@cikisSubeNo", cikisSubeNo);
            cmd.Parameters.AddWithValue("@teslimatSubeNo", teslimatSubeNo);
            cmd.Parameters.AddWithValue("@kargoAlimZamani", kargoAlimZamani);
            cmd.Parameters.AddWithValue("@kargoGirisi_yetkiliTCNo", kargoGirisi_yetkiliTCNo);

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }








        public static DataRow kargoGetir(string kargoAlimZamani, int gonderenAdresNo, int aliciAdresNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"

select * from Kargolar
where sistemeGirisZamani=@kargoAlimZamani and aliciAdresNo=@aliciAdresNo and gonderenAdresNo=@gonderenAdresNo";

            cmd.Parameters.AddWithValue("@kargoAlimZamani", kargoAlimZamani);
            cmd.Parameters.AddWithValue("@aliciAdresNo", aliciAdresNo);
            cmd.Parameters.AddWithValue("@gonderenAdresNo", gonderenAdresNo);



            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }



        public static void kargoDurumuGuncelle(int durumID, int gonderiTakipNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Kargolar set   durumID=@durumID
                             where gonderi_takip_no=@gonderiTakipNo";
            cmd.Parameters.AddWithValue("@durumID", durumID);
            cmd.Parameters.AddWithValue("@gonderiTakipNo", gonderiTakipNo);
           
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }




        public static void kargoTeslimGuncelle(int durumID, string teslimTarihi, string teslimEden, int gonderiTakipNo, string teslimAlan)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Kargolar set  durumID=@durumID, teslimEdenPrsKNO=@teslimEden, 
      teslimTarihi=@teslimTarihi , teslimAlan=@teslimAlan
                             where gonderi_takip_no=@gonderiTakipNo";
            cmd.Parameters.AddWithValue("@durumID", durumID);
            cmd.Parameters.AddWithValue("@gonderiTakipNo", gonderiTakipNo);
            cmd.Parameters.AddWithValue("@teslimTarihi", teslimTarihi);
            cmd.Parameters.AddWithValue("@teslimEden", teslimEden);
            cmd.Parameters.AddWithValue("@teslimAlan", teslimAlan);
         

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }











        public static DataTable kargoAra(string kargoAra)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select 
gonderi_takip_no as [Takip No],
durumAciklama as [Durum],
f.FaturaID as [Fatura No],
case when kargoTuru=0 then 'Dosya' else 'Paket' end as [Kargo Türü] ,
mAlici.musKimlikNO as [Alıcı Kimlik No]  ,
mAlici.musAdSoyad as [Alıcı Bilgisi],
a.adresTelefon as [Alıcı Tel],
teslimat.subeAdi as [Teslimat Şubesi], 
a.adresBilgi as [Alıcı Adres],
ai.IlceAdi [Alıcı İlçe], 
ash.SehirAdi as [Alıcı Şehir],  
a.adresPK [Alıcı PK],
case when mAlici.musTur=0 then 'Bireysel' else 'Kurumsal' end as [Alıcı Türü] ,
case when teslimatSekli=0 then 'Adrese Teslim' else 'Şubeden Teslim' end as [Teslimat Türü] ,
k.kargoDesi as [Desi],
f.faturaTutari as [Ücret],
case when odeyenTaraf=0 then 'Alıcıdan' else 'Göndericiden' end as [Ücret Tahsil] ,
case when odemeSekli=0 then 'Bireysel' else 'Kurumsal' end as [Ödeme Türü] ,
mGond.musKimlikNO as [Gönderici Kimlik No]  ,
mGond.musAdSoyad as [Gönderici Bilgisi],
cikis.subeAdi as [Çıkış Şubesi], 
gond.adresTelefon as [Gönderici Tel],
gond.adresBilgi [Gönderici Adres],
gi.IlceAdi [Gönderici İlçe],
gsh.SehirAdi as [Gönderici Şehir],  
gond.adresPK [Gönderici PK],
case when mGond.musTur=0 then 'Bireysel' else 'Kurumsal' end as [Gönderici Türü] ,
kGiris.prsKimlikNo as [Kargo Girişi Yapan],
sistemeGirisZamani as [Kargo Alım Tarihi],
tEden.prsKimlikNo as [Teslim Eden],
teslimTarihi as [Teslim Tarihi],
teslimAlan as [Teslim Alan]
 from Kargolar as k 
join Adresler as a on k.aliciAdresNo=a.adresNO 
join Adresler as gond on k.gonderenAdresNo=gond.adresNO 
join Musteriler as mAlici on mAlici.musteriNO=a.musteriNO
join Musteriler as mGond on mGond.musteriNO=gond.musteriNO
join Subeler as teslimat on k.cikisSubeNo=teslimat.subeNo 
 join Subeler as cikis on k.teslimatSubeNo=cikis.subeNo
join Ilceler as ai on a.IlceID=ai.ilceID
join Ilceler as gi on gond.IlceID=gi.ilceID
join Sehirler as ash on  ai.SehirID=ash.SehirId
join Sehirler as gsh on gi.SehirID=gsh.SehirId
 join Personel as kGiris on k.girisYapanPrsKNO=kGiris.prsKimlikNo
 join Durumlar as d on k.durumID=d.durumID
 join Faturalar as f on k.FaturaID=f.FaturaID
left outer join Personel as tEden on k.teslimEdenPrsKNO=tEden.prsKimlikNo
where a.adresTelefon like @aliciTelefon  or mAlici.musKimlikNO like @aliciKimlikNo or gonderi_takip_no=@takipno";
           
            string kAra = kargoAra.ToString();
            cmd.Parameters.AddWithValue("@aliciTelefon", "%" + kAra + "%");
            cmd.Parameters.AddWithValue("@aliciKimlikNo", "%" + kAra + "%");

            double takipNo = Convert.ToDouble(Regex.Match(kargoAra, "\\d+").Value);
            cmd.Parameters.AddWithValue("@takipno", takipNo);


            return dbislem.SelectSorgusuCalistir(cmd);
        }





















        public static DataTable cikisSubesineGoreKargolar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"  select 
subeAdi as [Şube Adı], count(*) [Kargo Sayısı]
 from kargolar as k left join Subeler as s on k.cikisSubeNo=s.subeNo group by subeAdi
         ";
            return dbislem.SelectSorgusuCalistir(cmd);
        }


     




        public static DataTable subelereGoretoplamKazanc()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"    select
subeAdi[Şube Adı], sum(faturaTutari)[Toplam Kazanç]
        from kargolar as k
        join Subeler as s on k.cikisSubeNo = s.subeNo

        join Faturalar as f on f.FaturaID = k.FaturaID

         group by subeAdi

         ";
            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable subelereGoreOrtalamaUcret()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"  select
subeAdi [Şube Adı], avg(faturaTutari) [Ortalama Gönderi Ücreti]
        from kargolar as k
		join Subeler as s on k.cikisSubeNo=s.subeNo 
		join Faturalar as f on f.FaturaID=k.FaturaID
		 group by subeAdi
         ";
            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable toplamGonderiSayisi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select
count(*) [Toplam Gönderi Sayısı]
        from kargolar ";
            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static DataTable subetoplamGonderiSayisi(int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select
count(*) [Toplam Gönderi Sayısı]
        from kargolar where cikisSubeNo=@subeNo or teslimatSubeNo=@subeNo";
            cmd.Parameters.AddWithValue("@subeNo", subeNo);
            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable subeyeGoreOrtalamaUcret(int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select avg(faturaTutari) [Ortalama Gönderi Ücreti]
        from kargolar as k
		join Subeler as s on k.cikisSubeNo=s.subeNo 
		join Faturalar as f on f.FaturaID=k.FaturaID where subeNo=@subeNo";
           cmd.Parameters.AddWithValue("@subeNo", subeNo);
            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable genelToplamUcret()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select sum(faturaTutari) [Genel Toplam Kazanç]
        from kargolar as k
		join Subeler as s on k.cikisSubeNo=s.subeNo 
		join Faturalar as f on f.FaturaID=k.FaturaID";
            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static DataTable subegenelToplamUcret(int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select sum(faturaTutari) [Genel Toplam Kazanç]
        from kargolar as k
		join Subeler as s on k.cikisSubeNo=s.subeNo 
		join Faturalar as f on f.FaturaID=k.FaturaID where subeNo=@subeNo";
            cmd.Parameters.AddWithValue("@subeNo", subeNo);
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable subeyeGoreTeslimEdilenler()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select
s.subeAdi [Şube Adı], count(k.teslimatSubeNo) [Bu Şubeden Teslim Edilen Kargo Sayısı]
        from kargolar as k left join Subeler as s on k.teslimatSubeNo=s.subeNo 
		join durumlar as d on d.durumID=k.durumID  where  k.durumID=1 group by subeAdi";

    
            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static DataTable subeyeGoreTeslimEdilmeyenler()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select
s.subeAdi [Şube Adı], count(k.teslimatSubeNo) [Bu Şubeden Teslim Edilmeyi Bekleyen Kargo Sayısı]
        from kargolar as k left join Subeler as s on k.teslimatSubeNo=s.subeNo 
		join durumlar as d on d.durumID=k.durumID  where  k.durumID>1 group by subeAdi";


            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable subeyeGoreTeslimEdilmeyenListesi(int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select 
gonderi_takip_no as [Takip No],
durumAciklama as [Durum],
f.FaturaID as [Fatura No],
case when kargoTuru=0 then 'Dosya' else 'Paket' end as [Kargo Türü] ,
mAlici.musKimlikNO as [Alıcı Kimlik No]  ,
mAlici.musAdSoyad as [Alıcı Bilgisi],
a.adresTelefon as [Alıcı Tel],
teslimat.subeAdi as [Teslimat Şubesi], 
a.adresBilgi as [Alıcı Adres],
ai.IlceAdi [Alıcı İlçe], 
ash.SehirAdi as [Alıcı Şehir],  
a.adresPK [Alıcı PK],
case when mAlici.musTur=0 then 'Bireysel' else 'Kurumsal' end as [Alıcı Türü] ,
case when teslimatSekli=0 then 'Adrese Teslim' else 'Şubeden Teslim' end as [Teslimat Türü] ,
k.kargoDesi as [Desi],
f.faturaTutari as [Ücret],
case when odeyenTaraf=0 then 'Alıcıdan' else 'Göndericiden' end as [Ücret Tahsil] ,
case when odemeSekli=0 then 'Bireysel' else 'Kurumsal' end as [Ödeme Türü] ,
mGond.musKimlikNO as [Gönderici Kimlik No]  ,
mGond.musAdSoyad as [Gönderici Bilgisi],
cikis.subeAdi as [Çıkış Şubesi], 
gond.adresTelefon as [Gönderici Tel],
gond.adresBilgi [Gönderici Adres],
gi.IlceAdi [Gönderici İlçe],
gsh.SehirAdi as [Gönderici Şehir],  
gond.adresPK [Gönderici PK],
case when mGond.musTur=0 then 'Bireysel' else 'Kurumsal' end as [Gönderici Türü] ,
kGiris.prsKimlikNo as [Kargo Girişi Yapan],
sistemeGirisZamani as [Kargo Alım Tarihi],
tEden.prsKimlikNo as [Teslim Eden],
teslimTarihi as [Teslim Tarihi],
teslimAlan as [Teslim Alan]
 from Kargolar as k 
join Adresler as a on k.aliciAdresNo=a.adresNO 
join Adresler as gond on k.gonderenAdresNo=gond.adresNO 
join Musteriler as mAlici on mAlici.musteriNO=a.musteriNO
join Musteriler as mGond on mGond.musteriNO=gond.musteriNO
join Subeler as teslimat on k.cikisSubeNo=teslimat.subeNo 
 join Subeler as cikis on k.teslimatSubeNo=cikis.subeNo
join Ilceler as ai on a.IlceID=ai.ilceID
join Ilceler as gi on gond.IlceID=gi.ilceID
join Sehirler as ash on  ai.SehirID=ash.SehirId
join Sehirler as gsh on gi.SehirID=gsh.SehirId
 join Personel as kGiris on k.girisYapanPrsKNO=kGiris.prsKimlikNo
 join Durumlar as d on k.durumID=d.durumID
 join Faturalar as f on k.FaturaID=f.FaturaID
left outer join Personel as tEden on k.teslimEdenPrsKNO=tEden.prsKimlikNo
where d.durumAciklama not like 'Teslim Edildi' and teslimat.subeNo=@subeNo";


            cmd.Parameters.AddWithValue("@subeNo", subeNo);
            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable subeyeGoreTeslimEdilenListesi(int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select 
gonderi_takip_no as [Takip No],
durumAciklama as [Durum],
f.FaturaID as [Fatura No],
case when kargoTuru=0 then 'Dosya' else 'Paket' end as [Kargo Türü] ,
mAlici.musKimlikNO as [Alıcı Kimlik No]  ,
mAlici.musAdSoyad as [Alıcı Bilgisi],
a.adresTelefon as [Alıcı Tel],
teslimat.subeAdi as [Teslimat Şubesi], 
a.adresBilgi as [Alıcı Adres],
ai.IlceAdi [Alıcı İlçe], 
ash.SehirAdi as [Alıcı Şehir],  
a.adresPK [Alıcı PK],
case when mAlici.musTur=0 then 'Bireysel' else 'Kurumsal' end as [Alıcı Türü] ,
case when teslimatSekli=0 then 'Adrese Teslim' else 'Şubeden Teslim' end as [Teslimat Türü] ,
k.kargoDesi as [Desi],
f.faturaTutari as [Ücret],
case when odeyenTaraf=0 then 'Alıcıdan' else 'Göndericiden' end as [Ücret Tahsil] ,
case when odemeSekli=0 then 'Bireysel' else 'Kurumsal' end as [Ödeme Türü] ,
mGond.musKimlikNO as [Gönderici Kimlik No]  ,
mGond.musAdSoyad as [Gönderici Bilgisi],
cikis.subeAdi as [Çıkış Şubesi], 
gond.adresTelefon as [Gönderici Tel],
gond.adresBilgi [Gönderici Adres],
gi.IlceAdi [Gönderici İlçe],
gsh.SehirAdi as [Gönderici Şehir],  
gond.adresPK [Gönderici PK],
case when mGond.musTur=0 then 'Bireysel' else 'Kurumsal' end as [Gönderici Türü] ,
kGiris.prsKimlikNo as [Kargo Girişi Yapan],
sistemeGirisZamani as [Kargo Alım Tarihi],
tEden.prsKimlikNo as [Teslim Eden],
teslimTarihi as [Teslim Tarihi],
teslimAlan as [Teslim Alan]
 from Kargolar as k 
join Adresler as a on k.aliciAdresNo=a.adresNO 
join Adresler as gond on k.gonderenAdresNo=gond.adresNO 
join Musteriler as mAlici on mAlici.musteriNO=a.musteriNO
join Musteriler as mGond on mGond.musteriNO=gond.musteriNO
join Subeler as teslimat on k.cikisSubeNo=teslimat.subeNo 
 join Subeler as cikis on k.teslimatSubeNo=cikis.subeNo
join Ilceler as ai on a.IlceID=ai.ilceID
join Ilceler as gi on gond.IlceID=gi.ilceID
join Sehirler as ash on  ai.SehirID=ash.SehirId
join Sehirler as gsh on gi.SehirID=gsh.SehirId
 join Personel as kGiris on k.girisYapanPrsKNO=kGiris.prsKimlikNo
 join Durumlar as d on k.durumID=d.durumID
 join Faturalar as f on k.FaturaID=f.FaturaID
left outer join Personel as tEden on k.teslimEdenPrsKNO=tEden.prsKimlikNo
where d.durumAciklama like 'Teslim Edildi' and teslimat.subeNo=@subeNo";


            cmd.Parameters.AddWithValue("@subeNo", subeNo);
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable subeyeGoreGonderilenler(int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select
s.subeAdi [Şube Adı], count(k.aliciSubeNo) [Bu Şubeden Teslim Edilen Kargo Sayısı]
        from kargolar as k left join Subeler as s on k.aliciSubeNo=s.subeNo 
		join durumlar as d on d.durumID=k.durumID  where subeNo=@subeNO and  k.durumID=1 group by subeAdi";


            cmd.Parameters.AddWithValue("@subeNo", subeNo);
            return dbislem.SelectSorgusuCalistir(cmd);
        }




        public static DataTable subeyeToplamKargoSayisi(int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" 
        select
COUNT(*) [Bu Şubedeki Toplam Kargo Sayısı]
        from kargolar as k left join Subeler as s on k.teslimatSubeNo=s.subeNo
        where  k.teslimatSubeNo=@subeNo or k.cikisSubeNo=@subeNo

 ";


            cmd.Parameters.AddWithValue("@subeNo", subeNo);
            return dbislem.SelectSorgusuCalistir(cmd);
        }












    }
}
