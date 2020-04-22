using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.db
{
    class musteriIslemleri
    {


        public static void musteriEkle(string musteriKimlikNO, string musteriAdSoyad, int musteriTuru)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Musteriler (musAdSoyad, musKimlikNO, musTur)
                                            VALUES (@musteriAdSoyad, @musteriKimlikNO, @musteriTuru)";
            cmd.Parameters.AddWithValue("@musteriAdSoyad", musteriAdSoyad);
            cmd.Parameters.AddWithValue("@musteriKimlikNO", musteriKimlikNO);
            cmd.Parameters.AddWithValue("@musteriTuru", musteriTuru);

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }

        public static DataTable musteriGetir(string musKimlikNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Musteriler where musKimlikNO=@musKimlikNO";
            cmd.Parameters.AddWithValue("@musKimlikNO", musKimlikNO);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }

        public static DataTable musteriBilgiGetir(string musteriKimlikNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Musteriler as m join Adresler as a on m.musteriNO=a.musteriNO 
                                where musKimlikNO=@musteriKimlikNO";
            cmd.Parameters.AddWithValue("@musteriKimlikNO", musteriKimlikNO);
                    DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }



        public static DataTable musterileriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select musteriNo [Müşteri No], musKimlikNO [Kimlik NO],   musAdSoyad [Ad Soyad] , 
case when musTur=0 then 'Bireysel' else 'Kurumsal' end as [Müşteri Türü] from Musteriler where isActive=1";

            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }


      



        public static DataTable musteriAra(string musteriAra)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select musteriNo [Müşteri No], musKimlikNO [Kimlik NO],   musAdSoyad [Ad Soyad] , 
case when musTur=0 then 'Bireysel' else 'Kurumsal' end as [Müşteri Türü] 
from Musteriler  where  musKimlikNO like @musKimlikNO";
cmd.Parameters.AddWithValue("@musKimlikNO",  musteriAra + "%");
                      DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }

































    }
}
