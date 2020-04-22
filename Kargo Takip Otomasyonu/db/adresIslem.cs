using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.db
{
    class adresIslem
    {





        public static void adresEkle(string musteriNO, string adresBilgi, int ilceID, string adresPostaKodu, string adresTelefon)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Adresler (musteriNO, adresBilgi,  IlceID, adresPK, adresTelefon)
               VALUES (@musteriNO, @adresBilgi, @IlceID, @adresPostaKodu, @adresTelefon)";

            cmd.Parameters.AddWithValue("@musteriNO", Convert.ToInt16(musteriNO));
            cmd.Parameters.AddWithValue("@adresBilgi", adresBilgi);
                   cmd.Parameters.AddWithValue("@IlceID", ilceID);
            cmd.Parameters.AddWithValue("@adresPostaKodu", adresPostaKodu);
            cmd.Parameters.AddWithValue("@adresTelefon", adresTelefon);

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }


        public static DataTable TUMadresleriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select a.AdresNO as[Adres No],

m.musKimlikNO as [Müşteri Kimlik], m.musAdSoyad as [Müşteri Bilgi], adresBilgi as Adres, IlceAdi as [İlçe]
, SehirAdi as [Şehir], adresPK as PK , adresTelefon as Telefon
from adresler as a join musteriler as m on a.musteriNO=m.musteriNO 
join Ilceler as i on i.ilceID=a.IlceID
join Sehirler as s on s.SehirId=i.SehirID where a.isActive=1";
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }





        public static DataTable adresleriGetir(string musteriKimlikNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from adresler as a join musteriler as m on a.musteriNO=m.musteriNO 
join Ilceler as i on i.ilceID=a.IlceID
join Sehirler as s on s.SehirId=i.SehirID
where musKimlikNO=@musteriKimlikNO";
            cmd.Parameters.AddWithValue("@musteriKimlikNO", musteriKimlikNO);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }



        public static DataRow adresiGetir(int adresNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from adresler as a join musteriler as m on a.musteriNO=m.musteriNO 
join Ilceler as i on i.ilceID=a.IlceID
join Sehirler as s on s.SehirId=i.SehirID
where a.adresNO=@adresNO";
            cmd.Parameters.AddWithValue("@adresNO", Convert.ToInt16(adresNO));
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
         return tbl.Rows[0]; ;
        }

        public static DataRow adresiGetiradresBilgisineGore(string adresBilgi,int ilceID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select a.adresNo as aadresNo from adresler as a join musteriler as m on a.musteriNO=m.musteriNO 
join Ilceler as i on i.ilceID=a.IlceID
join Sehirler as s on s.SehirId=i.SehirID
where adresBilgi=@adresBilgi and a.IlceID=@ilceID";
            cmd.Parameters.AddWithValue("@adresBilgi", adresBilgi);
            cmd.Parameters.AddWithValue("@ilceID", ilceID);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
                        return tbl.Rows[0]; ;
        }



        public static void adresiSil(int adresNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Adresler set isActive=0 WHERE adresNO=@adresNO";
            cmd.Parameters.AddWithValue("@adresNO", adresNO);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }












        public static DataTable adresAra(string muskimlikNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select a.AdresNO as[Adres No],

m.musKimlikNO as [Müşteri Kimlik], m.musAdSoyad as [Müşteri Bilgi], adresBilgi as Adres, IlceAdi as [İlçe]
, SehirAdi as [Şehir], adresPK as PK , adresTelefon as Telefon
from adresler as a join musteriler as m on a.musteriNO=m.musteriNO 
join Ilceler as i on i.ilceID=a.IlceID
join Sehirler as s on s.SehirId=i.SehirID where musKimlikNO like @musKimlikNO";
            cmd.Parameters.AddWithValue("@musKimlikNO", "%" + muskimlikNo + "%");
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }




    }
}
