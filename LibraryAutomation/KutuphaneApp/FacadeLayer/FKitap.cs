using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLayer
{
   public  class FKitap
    {
        public static int Insert( EKitap item)
        {
            int etkilenen = 0;
            try
            {
                SqlCommand com = new SqlCommand("Kitap_Insert ", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("Adi", item.Adi);
                com.Parameters.AddWithValue("Kategoriİd", item.Kategoriİd);
                com.Parameters.AddWithValue("SayfaSayisi", item.SayfaSayisi);
                com.Parameters.AddWithValue("YAZAR", item.Yazar);


                etkilenen = com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                etkilenen = -1;

            }
            return etkilenen;
        }

        public static bool Update(EKitap item)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("Kitap_Update ", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ID", item.ID);
                com.Parameters.AddWithValue("Adi", item.Adi);
                com.Parameters.AddWithValue("Kategoriİd", item.Kategoriİd);
                com.Parameters.AddWithValue("SayfaSayisi", item.SayfaSayisi);
                com.Parameters.AddWithValue("Yazar", item.Yazar);
                sonuc = com.ExecuteNonQuery() > 0;
            }
            catch (Exception ex )
            {
                sonuc = false;

            }
            return sonuc;
        }
        public static bool Delete(int _ID)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("Kitap_Delete ", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("Id", _ID);

                sonuc = com.ExecuteNonQuery() > 0;
            }
            catch
            {
                sonuc = false;

            }
            return sonuc;
        }
        public static EKitap Select(int _ID)
        {
            EKitap item = null;
            try
            {
                SqlCommand com = new SqlCommand("Kitap_Select ", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("Id", _ID);

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EKitap();
                        item.ID = Convert.ToInt32(rdr["ID"]);
                        item.Adi = rdr["ADI"].ToString();
                        item.Kategoriİd = Convert.ToInt32(rdr["Kategoriİd"]);
                        item.SayfaSayisi = Convert.ToInt16(rdr["Sayfasayisi"]);


                    }
                }
            }
            catch
            {
                item = null;

            }
            return item;
        }
        public static List<EKitap> SelectList()
        {
            List<EKitap> itemlist = null;
            try
            {
                SqlCommand com = new SqlCommand("Kitap_SelectList ", Baglanti.Con) { CommandType = CommandType.StoredProcedure };

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }


                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemlist = new List<EKitap>();
                    while (rdr.Read())
                    {
                        EKitap item = new EKitap();
                        item = new EKitap();
                        item.ID = Convert.ToInt32(rdr["ID"]);
                        item.Adi = rdr["ADI"].ToString();
                        item.Yazar = rdr["Yazar"].ToString();
                        item.Kategoriİd = Convert.ToInt32(rdr["Kategoriİd"]);
                        item.SayfaSayisi = Convert.ToInt16(rdr["Sayfasayisi"]);
                        itemlist.Add(item);
          

                    }
                }
                rdr.Close();
            }
            catch(Exception ex)
            {
                itemlist = null;

            }
            return itemlist;
        }

    }
}
