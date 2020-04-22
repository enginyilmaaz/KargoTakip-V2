using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication1.db
{
    class subeIslem
    {


        public static DataTable subeleriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select distinct SubeNo as [Şube No], 
subeAdi as [Şube Adı],  ss.SehirAdi as [Şehir],  i.IlceAdi as [İlçe], 
subeAdres as [Adres],  subeTelefon as [Tel No] from subeler as s
 join Ilceler as i on i.ilceID=s.ILCE_ID 
  join Sehirler as ss on ss.SehirId=i.SehirID
 join Personel as p on p.prsSubeNo=s.subeNo 
where  s.isActive=1";

            return dbislem.SelectSorgusuCalistir(cmd);
        }




       


      


        public static DataTable teslimSubeleriGetir(int ilceID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from subeler where ILCE_ID=@ilceID";
            cmd.Parameters.AddWithValue("@ilceID", ilceID);

            return dbislem.SelectSorgusuCalistir(cmd);

        }

   




        public static void subeEkle( string subeAdi, int ilceID, string subeAdres, string subeTelefon)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Subeler 
            ( subeAdi, ILCE_ID, subeAdres, subeTelefon) VALUES 
            (@subeAdi, @ilceID,  @subeAdres, @subeTelefon)";
      
            cmd.Parameters.AddWithValue("@subeAdi", subeAdi);
            cmd.Parameters.AddWithValue("@ilceID", Convert.ToInt16(ilceID));
            cmd.Parameters.AddWithValue("@subeAdres", subeAdres);
            cmd.Parameters.AddWithValue("@subeTelefon", subeTelefon);


            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }





        public static void subeSil(int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Subeler set isActive=0 WHERE subeNo=@subeNo";
            cmd.Parameters.AddWithValue("@subeNo", subeNo);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }





        public static DataRow subeGetir(int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select SubeNo as [Şube No], 
subeAdi as [Şube Adı], 
ss.SehirAdi as [Şehir], 
i.IlceAdi as [İlçe], 
subeAdres as [Adres], 
 subeTelefon as [Tel No] ,
CASE p.prsYetkiID WHEN 1 THEN prsAdSoyad else '-' END as [Şube Yöneticisi]
from subeler as s
 join Ilceler as i on i.ilceID=s.ILCE_ID 
 join Sehirler as ss on ss.SehirId=i.SehirID
left join Personel as p on p.prsSubeNo=s.subeNo 
where subeNo=@subeNo";
         
            cmd.Parameters.AddWithValue("@subeNo", subeNo);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }



        public static DataTable subeyiListele(int subeNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select SubeNo as [Şube No], 
subeAdi as [Şube Adı], 
ss.SehirAdi as [Şehir], 
i.IlceAdi as [İlçe], 
subeAdres as [Adres], 
 subeTelefon as [Tel No] ,
CASE p.prsYetkiID WHEN 1 THEN prsAdSoyad else '-' END as [Şube Yöneticisi]
from subeler as s
 join Ilceler as i on i.ilceID=s.ILCE_ID 
 join Sehirler as ss on ss.SehirId=i.SehirID
left join Personel as p on p.prsSubeNo=s.subeNo 
where s.subeNO=@subeNo ";

            cmd.Parameters.AddWithValue("@subeNo", subeNo);
           return dbislem.SelectSorgusuCalistir(cmd);
           
        }






        public static void subeGuncelle(int subeNo, string subeAdi, int ILCE_ID, string subeAdres, string subeTelefon)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Subeler set subeAdi=@subeAdi, ILCE_ID=@ILCE_ID, subeAdres=@subeAdres, 
                  subeTelefon=@subeTelefon where subeNo=@subeNo";

            cmd.Parameters.AddWithValue("@subeNo", Convert.ToInt16(subeNo));
            cmd.Parameters.AddWithValue("@subeAdi", subeAdi);
            cmd.Parameters.AddWithValue("@ILCE_ID", Convert.ToInt16(ILCE_ID));
            cmd.Parameters.AddWithValue("@subeAdres", subeAdres);
            cmd.Parameters.AddWithValue("@subeTelefon", subeTelefon);


            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }











       

        public static DataTable subeAraNo(string subeAraNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select SubeNo as [Şube No], 
subeAdi as [Şube Adı], 
ss.SehirAdi as [Şehir], 
i.IlceAdi as [İlçe], 
subeAdres as [Adres], 
 subeTelefon as [Tel No] ,
CASE p.prsYetkiID WHEN 1 THEN prsAdSoyad else '-' END as [Şube Yöneticisi]
from subeler as s
 join Ilceler as i on i.ilceID=s.ILCE_ID 
 join Sehirler as ss on ss.SehirId=i.SehirID
left join Personel as p on p.prsSubeNo=s.subeNo 
where (p.prsYetkiID=1 or p.prsSubeNo is null) and subeNO=@subeNo";
            cmd.Parameters.AddWithValue("@subeNo", Convert.ToInt16(subeAraNo) );
       
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable sehirGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT distinct SehirAdi, SehirId from Sehirler order by SehirAdi ";

            return dbislem.SelectSorgusuCalistir(cmd);
        }




        public static DataTable ilceGetir(int SehirId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * from Ilceler where SehirId=@sehirId";

            cmd.Parameters.AddWithValue("@sehirId", Convert.ToInt16(SehirId));


            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable toplamSubeSayisi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT Count(*) as [Toplam Aktif Şube Sayısı] from subeler where isActive=1";
                       return dbislem.SelectSorgusuCalistir(cmd);
        }





    }
}
