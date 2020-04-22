using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.db
{
    class ucretIslem
    {


        public static void ucretEkle(bool gonderiTuru, int birimUcret, int musteriNo)
        { 
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Fiyatlar (gonderiTuru, birimUcret,musteriNo)
                                            VALUES (@gonderiTuru, @birimUcret,@musteriNo )";
            cmd.Parameters.AddWithValue("@gonderiTuru", gonderiTuru);
            cmd.Parameters.AddWithValue("@birimUcret", birimUcret);
            cmd.Parameters.AddWithValue("@musteriNo", musteriNo);
        
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }


        public static DataTable ucretleriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select f.musteriNo as [Müşteri No],m.musKimlikNO as[Kimlik NO], musAdSoyad as [Müşteri Bilgileri], 
case musTur when 0 then 'Bireysel' else 'Kurumsal' end as [Müşteri Türü]  ,
case gonderiTuru when 0 then 'Dosya' else 'Paket' end as [Gönderi Türü]  ,
birimUcret as [Birim Ücreti]

from Fiyatlar as f
left join Musteriler as m on m.musteriNO=f.musteriNo";

            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static DataTable ucretAra(string musteriKimlikNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select f.musteriNo as [Müşteri No],m.musKimlikNO as[Kimlik NO], musAdSoyad as [Müşteri Bilgileri], 
case musTur when 0 then 'Bireysel' else 'Kurumsal' end as [Müşteri Türü]  ,
case gonderiTuru when 0 then 'Dosya' else 'Paket' end as [Gönderi Türü]  ,
birimUcret as [Birim Ücreti] from Fiyatlar as f
join Musteriler as m on m.musteriNO=f.musteriNo where musKimlikNO like @musKimlikNO";
            cmd.Parameters.AddWithValue("@musKimlikNO", musteriKimlikNO + "%");
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static void ucretGuncelle(int gonderiTuru, string birimUcret, int musteriNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Fiyatlar set  birimUcret=@birimUcret
                                    where  gonderiTuru=@gonderiTuru and musteriNO=@musteriNO";
            cmd.Parameters.AddWithValue("@gonderiTuru", gonderiTuru);
            cmd.Parameters.AddWithValue("@birimUcret", Convert.ToInt16(birimUcret));
            cmd.Parameters.AddWithValue("@musteriNO", musteriNO);

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }



        public static void ucretSil(int gonderiTuru, int musteriNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Fiyatlar where gonderiTuru=@gonderiTuru and musteriNO=@musteriNO";
            cmd.Parameters.AddWithValue("@gonderiTuru", gonderiTuru);
    
            cmd.Parameters.AddWithValue("@musteriNO", musteriNO);

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }




        public static DataRow ucretGetir(int gonderiTuru, int musteriNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Fiyatlar as f 
join Musteriler as m on m.musteriNO=f.musteriNo
where gonderiTuru=@gonderiTuru and  m.musteriNo=@musteriNO";

            cmd.Parameters.AddWithValue("@gonderiTuru", gonderiTuru);
            cmd.Parameters.AddWithValue("@musteriNO", musteriNO);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }



        public static DataTable ucretGetirKimlikNosunaGore(int gonderiTuru, string musKimlikNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Fiyatlar as f 
join Musteriler as m on m.musteriNO=f.musteriNo
where gonderiTuru=@gonderiTuru and  musKimlikNO=@musKimlikNO";

            cmd.Parameters.AddWithValue("@gonderiTuru", gonderiTuru);
            cmd.Parameters.AddWithValue("@musKimlikNO", musKimlikNO);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }





        public static void faturaOlustur(bool odeyenTaraf, bool odemeSekli, decimal faturaTutari,  bool odemeDurumu, string duzenleyenPRSID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Faturalar (odeyenTaraf,odemeSekli,faturaTutari,odemeDurumu, duzenleyenPRSID)
                                            VALUES (@odeyenTaraf, @odemeSekli,@faturaTutari,@odemeDurumu, @duzenleyenPRSID )";
            cmd.Parameters.AddWithValue("@odeyenTaraf", odeyenTaraf);
            cmd.Parameters.AddWithValue("@odemeSekli", odemeSekli);
            cmd.Parameters.AddWithValue("@faturaTutari", faturaTutari);
            cmd.Parameters.AddWithValue("@odemeDurumu", odemeDurumu);
            cmd.Parameters.AddWithValue("@duzenleyenPRSID", duzenleyenPRSID);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }

        public static void faturaOdendiGuncelle(int takipNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Faturalar 
SET odemeDurumu = 1  
FROM Faturalar f  
INNER JOIN Kargolar k ON f.FaturaID=k.FaturaID
WHERE gonderi_takip_no=@takipNO";
            cmd.Parameters.AddWithValue("@takipNO", takipNO);

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }





        public static DataTable faturalariGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select f.FaturaID as [Fatura No],
k.gonderi_takip_no as [Gönderi No], 
case when odeyenTaraf=0 then 'Alıcı' else 'Gönderici' end as [Ödeyen Taraf] ,
m.musAdSoyad as [Alıcı],mm.musAdSoyad as Gönderici,
case when odemeSekli=0 then 'Kredi Kartı' else 'Nakit' end as [Ödeme Şekli] , faturaTutari as Tutar, 
k.sistemeGirisZamani as [Tarih], f.duzenleyenPRSID as [Düzenleyen],
case when odemeDurumu=1 then 'Ödendi' else 'Ödenmedi' end as [Ödeme Durumu] from Faturalar as f
join Kargolar as k on f.FaturaID=k.FaturaID
join Adresler as a on a.adresNo=k.aliciAdresNo
join Adresler as aa  on aa.adresNo=k.gonderenAdresNo
join Musteriler as m on m.musteriNo=a.musteriNO
join Musteriler as mm on mm.musteriNo=aa.musteriNO";

            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable faturaAra(int ara)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select f.FaturaID as [Fatura No],
k.gonderi_takip_no as [Gönderi No], 
case when odeyenTaraf=0 then 'Alıcı' else 'Gönderici' end as [Ödeyen Taraf] ,
m.musAdSoyad as [Alıcı],mm.musAdSoyad as Gönderici,
case when odemeSekli=0 then 'Kredi Kartı' else 'Nakit' end as [Ödeme Şekli] , faturaTutari as Tutar, 
k.sistemeGirisZamani as [Tarih], f.duzenleyenPRSID as [Düzenleyen],
case when odemeDurumu=1 then 'Ödendi' else 'Ödenmedi' end as [Ödeme Durumu] from Faturalar as f
join Kargolar as k on f.FaturaID=k.FaturaID
join Adresler as a on a.adresNo=k.aliciAdresNo
join Adresler as aa  on aa.adresNo=k.gonderenAdresNo
join Musteriler as m on m.musteriNo=a.musteriNO
join Musteriler as mm on mm.musteriNo=aa.musteriNO
            where f.FaturaID like @ara or gonderi_takip_no like @ara";
            cmd.Parameters.AddWithValue("@ara", ara + "%");
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable faturalariGetirSube(int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select f.FaturaID as [Fatura No],
k.gonderi_takip_no as [Gönderi No], 
case when odeyenTaraf=0 then 'Alıcı' else 'Gönderici' end as [Ödeyen Taraf] ,

m.musAdSoyad as [Alıcı],mm.musAdSoyad as Gönderici,

case when odemeSekli=0 then 'Kredi Kartı' else 'Nakit' end as [Ödeme Şekli] , faturaTutari as Tutar, 
k.sistemeGirisZamani as [Tarih],
f.duzenleyenPRSID as [Düzenleyen],
case when odemeDurumu=1 then 'Ödendi' else 'Ödenmedi' end as [Ödeme Durumu] 

from Faturalar as f
join Kargolar as k on f.FaturaID=k.FaturaID
join Adresler as a on a.adresNo=k.aliciAdresNo
join Adresler as aa  on aa.adresNo=k.gonderenAdresNo
join Musteriler as m on m.musteriNo=a.musteriNO
join Musteriler as mm on mm.musteriNo=aa.musteriNO
where k.cikisSubeNo=@subeNo
";
            cmd.Parameters.AddWithValue("@subeNo", subeNo);
            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static DataRow sonEklenenFaturaID(string girisYapanPrsKNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" SELECT FaturaID FROM Faturalar 
WHERE FaturaID=(SELECT max(FaturaID) FROM Faturalar) and duzenleyenPRSID=@girisYapanPrsKNO";
            cmd.Parameters.AddWithValue("@girisYapanPrsKNO", girisYapanPrsKNO);

            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }
       

    }
}
