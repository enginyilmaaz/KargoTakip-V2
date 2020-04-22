using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1.db
{
    class uyeIslemleri
    {


        public static DataTable girisKontrolu(string prsKimlikNo, string prsSifre)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select p.prsKimlikNo,p.prsAdSoyad,p.prsYetkiID,s.subeAdi,y.YetkiAciklamasi 
FROM Personel as p 
 join Subeler as s on p.prsSubeNo=s.SubeNo 
join Yetkiler as y on p.prsYetkiID=y.YetkiID 
where (p.prsKimlikNo = @prsKimlikNo and p.prsSifre = @prsSifre) and  p.isActive=1";
            cmd.Parameters.AddWithValue("@prsKimlikNo", prsKimlikNo);
            cmd.Parameters.AddWithValue("@prsSifre", prsSifre);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }


        public static DataTable sifremiUnuttum(string yetkili_Mail)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Personel where prsMail=@yetkili_Mail and isActive=1";
            cmd.Parameters.AddWithValue("@yetkili_Mail", yetkili_Mail);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }



        public static void sifreDegistir(string Yeni_Sifre, string yetkili_Mail)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Personel set prsSifre=@yetkili_Sifre where prsMail=@yetkili_Mail";
            cmd.Parameters.AddWithValue("@yetkili_Sifre", Yeni_Sifre);
            cmd.Parameters.AddWithValue("@yetkili_Mail", yetkili_Mail);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }

        public static void yetkiliEkle(string yetkili_TC_No, string yetkili_Ad_Soyad, int yetki_Turu, string yetkili_Tel_No, string yetkili_Mail, string yetkili_Sifre, string yetkili_Gizli_Soru, string yetkili_Gizli_Soru_Cevabi, bool yetkili_Cinsiyet, int yetkili_subeNo )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Personel (prsKimlikNo, prsAdSoyad, prsYetkiID, prsTelNo,
prsMail, prsSifre, prsGizliSoru, prsGizliSoruCevap, prsCinsiyet,prsSubeNo)
   VALUES (@yetkili_TC_No, @yetkili_Ad_Soyad, @yetki_Turu, @yetkili_Tel_No, 
 @yetkili_Mail, @yetkili_Sifre, @yetkili_Gizli_Soru, @yetkili_Gizli_Soru_Cevabi,  @yetkili_Cinsiyet, @yetkili_subeNo)";
            cmd.Parameters.AddWithValue("@yetkili_TC_No", yetkili_TC_No);
            cmd.Parameters.AddWithValue("@yetkili_Ad_Soyad", yetkili_Ad_Soyad);
            cmd.Parameters.AddWithValue("@yetki_Turu", Convert.ToInt16(yetki_Turu));
            cmd.Parameters.AddWithValue("@yetkili_Tel_No", yetkili_Tel_No);
            cmd.Parameters.AddWithValue("@yetkili_Mail", yetkili_Mail);
            cmd.Parameters.AddWithValue("@yetkili_Sifre", yetkili_Sifre);
            cmd.Parameters.AddWithValue("@yetkili_Gizli_Soru", yetkili_Gizli_Soru);
            cmd.Parameters.AddWithValue("@yetkili_Gizli_Soru_Cevabi", yetkili_Gizli_Soru_Cevabi);
            cmd.Parameters.AddWithValue("@yetkili_Cinsiyet", yetkili_Cinsiyet);
            cmd.Parameters.AddWithValue("@yetkili_subeNo", yetkili_subeNo);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }


        





        public static bool EmailKontrol(string eposta)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return (new Regex(strRegex)).IsMatch(eposta);
        }




        public static DataTable YetkiliVarmi(string prsKimlikNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Personel where prsKimlikNo=@prsKimlikNo";
            cmd.Parameters.AddWithValue("@prsKimlikNo", prsKimlikNo);
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable YetkilileriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select p.prsAdSoyad as [Ad Soyad],
p.prsKimlikNo as [Kimlik NO],  
case when prsCinsiyet=1 then 'Erkek'  else 'Kadın' end as [Cinsiyet], 
SubeNo [Şube No],
y.YetkiAciklamasi [Yetkisi],
subeAdi as [Şube Adı],
prsTelNo as [Telefon No],
SehirAdi as [Şube İl],
IlceAdi as [Şube İlçe],
 prsMail as [Eposta]

 from personel as p  join Subeler as s on p.prsSubeNo=s.subeNo 
  join Ilceler as i on i.ilceID=s.ILCE_ID
join Sehirler as sh on sh.SehirId=i.SehirID
join Yetkiler as y on y.YetkiID=p.prsYetkiID
where p.isActive=1
 order by p.prsAdSoyad";
            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable seciliSubeninYetkilileriGetir(int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select p.prsAdSoyad as [Ad Soyad],
p.prsKimlikNo as [Kimlik NO],  case when prsCinsiyet=1 then 'Erkek'  else 'Kadın' end as [Cinsiyet], 
SubeNo [Şube No], y.YetkiAciklamasi [Yetkisi], subeAdi as [Şube Adı], prsTelNo as [Telefon No], SehirAdi as [Şube İl], IlceAdi as [Şube İlçe],  prsMail as [Eposta]
from personel as p  join Subeler as s on p.prsSubeNo=s.subeNo 
  join Ilceler as i on i.ilceID=s.ILCE_ID
join Sehirler as sh on sh.SehirId=i.SehirID
join Yetkiler as y on y.YetkiID=p.prsYetkiID
where p.isActive=1 and subeNo=@subeNo 
 order by p.prsAdSoyad";
           
            cmd.Parameters.AddWithValue("@subeNo", subeNo);
            return dbislem.SelectSorgusuCalistir(cmd);

        }


        public static DataRow YetkiliGetir(string prsKimlikNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select p.prsAdSoyad as [Ad Soyad],
p.prsKimlikNo as [Kimlik NO],  
case when prsCinsiyet=0 then 'Erkek'  else 'Kadın' end as [Cinsiyet], 
SubeNo [Şube No],
y.YetkiAciklamasi [Yetkisi],
subeAdi as [Şube Adı],
prsTelNo as [Telefon No],
SehirAdi as [Şube İl],
IlceAdi as [Şube İlçe],
 prsMail as [Eposta],
 p.prsSifre as [Şifre],
 prsGizliSoru as [Gizli Soru],
 prsGizliSoruCevap as [Cevap]

 from personel as p  join Subeler as s on p.prsSubeNo=s.subeNo 
  join Ilceler as i on i.ilceID=s.ILCE_ID
join Sehirler as sh on sh.SehirId=i.SehirID
join Yetkiler as y on y.YetkiID=p.prsYetkiID
 where prsKimlikNo=@prsKimlikNo";
            cmd.Parameters.AddWithValue("@prsKimlikNo", prsKimlikNo);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }


        public static void yetkiliSil(string prsKimlikNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update personel set isActive=0 where prsKimlikNo=@prsKimlikNo";
            cmd.Parameters.AddWithValue("@prsKimlikNo", prsKimlikNo);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }



        public static void yetkiliGuncelle(string yetkili_Ad_Soyad, string yetkili_TC_No,int prsYetkiID,int prsSubeNo,  string yetkili_Tel_No, string yetkili_Mail, string yetkili_Sifre, string yetkili_Gizli_Soru, string yetkili_Gizli_Soru_Cevabi)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Personel set 
prsAdSoyad=@yetkili_Ad_Soyad,
                               prsTelNo = @yetkili_Tel_No, 
                               prsMail = @yetkili_Mail, 
                              prsSifre =@yetkili_Sifre, 
                               prsGizliSoru=@yetkili_Gizli_Soru, 
                               prsGizliSoruCevap=@yetkili_Gizli_Soru_Cevabi,
                               prsYetkiID=@prsYetkiID,
                                 prsSubeNo=@prsSubeNo
                                 where prsKimlikNo=@yetkili_TC_No";
            cmd.Parameters.AddWithValue("@yetkili_TC_No", yetkili_TC_No);
            cmd.Parameters.AddWithValue("@yetkili_Tel_No", yetkili_Tel_No);
            cmd.Parameters.AddWithValue("@yetkili_Mail", yetkili_Mail);
            cmd.Parameters.AddWithValue("@prsYetkiID", prsYetkiID );
            cmd.Parameters.AddWithValue("@prsSubeNo", prsSubeNo);
            cmd.Parameters.AddWithValue("@yetkili_Sifre", yetkili_Sifre);
            cmd.Parameters.AddWithValue("@yetkili_Gizli_Soru", yetkili_Gizli_Soru);
            cmd.Parameters.AddWithValue("@yetkili_Gizli_Soru_Cevabi", yetkili_Gizli_Soru_Cevabi);
            cmd.Parameters.AddWithValue("@yetkili_Ad_Soyad", yetkili_Ad_Soyad);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }



      

        public static DataTable yetkiliAra(string yetkili_ara)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select p.prsAdSoyad as [Ad Soyad],
p.prsKimlikNo as [Kimlik NO],  
case when prsCinsiyet=0 then 'Erkek'  else 'Kadın' end as [Cinsiyet], 
SubeNo [Şube No],
y.YetkiAciklamasi [Yetkisi],
subeAdi as [Şube Adı],
prsTelNo as [Telefon No],
SehirAdi as [Şube İl],
IlceAdi as [Şube İlçe],
 prsMail as [Eposta],
 prsGizliSoru as [Gizli Soru]

 from personel as p  join Subeler as s on p.prsSubeNo=s.subeNo 
  join Ilceler as i on i.ilceID=s.ILCE_ID
join Sehirler as sh on sh.SehirId=i.SehirID
join Yetkiler as y on y.YetkiID=p.prsYetkiID
where prsAdSoyad like @yetkili_Ad_Soyad 
               or prsKimlikNo like @yetkili_tc_no 
               or prsTelNo like @yetkili_tel_no 
              order by prsAdSoyad";
            cmd.Parameters.AddWithValue("@yetkili_Ad_Soyad", "%"  + yetkili_ara  +"%");
            cmd.Parameters.AddWithValue("@yetkili_tc_no", "%" + yetkili_ara + "%");
            cmd.Parameters.AddWithValue("@yetkili_tel_no", "%" + yetkili_ara + "%");
            return dbislem.SelectSorgusuCalistir(cmd);
        }




        public static DataTable personelAraMetin(string personelAra, int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select p.prsAdSoyad as [Ad Soyad],
p.prsKimlikNo as [Kimlik NO],  
case when prsCinsiyet=1 then 'Erkek'  else 'Kadın' end as [Cinsiyet], 
SubeNo [Şube No],
y.YetkiAciklamasi [Yetkisi],
subeAdi as [Şube Adı],
prsTelNo as [Telefon No],
SehirAdi as [Şube İl],
IlceAdi as [Şube İlçe],
 prsMail as [Eposta]

 from personel as p  join Subeler as s on p.prsSubeNo=s.subeNo 
  join Ilceler as i on i.ilceID=s.ILCE_ID
join Sehirler as sh on sh.SehirId=i.SehirID
join Yetkiler as y on y.YetkiID=p.prsYetkiID
where p.isActive=1
 order by p.prsAdSoyad
where ( subeNo=@subeNo and prsAdSoyad like @yetkili_Ad_Soyad )
              ";

             cmd.Parameters.AddWithValue("@subeNo", subeNo);
         
            cmd.Parameters.AddWithValue("@yetkili_Ad_Soyad", "%" + personelAra + "%");
       
            return dbislem.SelectSorgusuCalistir(cmd);
        }





        public static DataTable personelAraSayisal(double personelAra, int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select p.prsAdSoyad as [Ad Soyad],
p.prsKimlikNo as [Kimlik NO],  
case when prsCinsiyet=1 then 'Erkek'  else 'Kadın' end as [Cinsiyet], 
SubeNo [Şube No],
y.YetkiAciklamasi [Yetkisi],
subeAdi as [Şube Adı],
prsTelNo as [Telefon No],
SehirAdi as [Şube İl],
IlceAdi as [Şube İlçe],
 prsMail as [Eposta]

 from personel as p  join Subeler as s on p.prsSubeNo=s.subeNo 
  join Ilceler as i on i.ilceID=s.ILCE_ID
join Sehirler as sh on sh.SehirId=i.SehirID
join Yetkiler as y on y.YetkiID=p.prsYetkiID
where p.isActive=1
 order by p.prsAdSoyad
where  ( subeNo=@subeNo and  prsKimlikNo like @yetkili_tc_no )
               or  ( subeNo=@subeNo and  prsTelNo like @yetkili_tel_no ) ";

            string pAra = personelAra.ToString();
            cmd.Parameters.AddWithValue("@yetkili_tel_no", "%" + pAra + "%");
            cmd.Parameters.AddWithValue("@yetkili_tc_no", "%" + pAra + "%");
            cmd.Parameters.AddWithValue("@subeNO", subeNo);
        
            return dbislem.SelectSorgusuCalistir(cmd);
        }





      


  public static DataTable subelereGoreYetkililer()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select
subeAdi as [Şube Adı], count(*) [Personel Sayısı]
        from Personel as p left join Subeler as s on p.prsSubeNo=s.subeNo 
where p.isActive=1 group by subeAdi";
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable toplamPersonelSayisi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select count(*) [Toplam Personel Sayısı]
        from Personel where isActive=1";
            return dbislem.SelectSorgusuCalistir(cmd);
        }






        public static void yetkiEkle(string Aciklama)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Yetkiler (YetkiAciklamasi)
                                            VALUES (@Aciklama)";
            cmd.Parameters.AddWithValue("@Aciklama", Aciklama);


            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }



        public static void yetkiGuncelle(string Aciklama, int yetkiID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update  Durumlar set yetkiAciklamasi=@Aciklama where yetkiID=@yetkiID";
            cmd.Parameters.AddWithValue("@Aciklama",Aciklama);
            cmd.Parameters.AddWithValue("@yetkiID", yetkiID);


            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }

        public static DataTable yetkiAra(string yetki)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select  yetkiID as [Yetki No],
yetkiAciklamasi as [Yetki Açıklaması] from yetkiler where isActive=1 and yetkiAciklamasi like @yetki";
            cmd.Parameters.AddWithValue("@yetki", "%" + yetki+ "%");
            return dbislem.SelectSorgusuCalistir(cmd);
        }




        public static DataRow yetkiyiGetir(int yetkiID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select 
yetkiID as [Yetki No],
yetkiAciklamasi as [Yetki Açıklaması] from yetkiler  
where yetkiID=@yetkiID";
            cmd.Parameters.AddWithValue("@yetkiID", yetkiID);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }


        public static DataTable yetkileriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select 
yetkiID as [Yetki No],
YetkiAciklamasi as [Yetki Açıklaması] from yetkiler where isActive=1    ";
            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static void yetkiSil(int yetkiID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update yetkiler  set isActive=0 WHERE yetkiID=@yetkiID";
            cmd.Parameters.AddWithValue("@yetkiID", yetkiID);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }

















    }
}
