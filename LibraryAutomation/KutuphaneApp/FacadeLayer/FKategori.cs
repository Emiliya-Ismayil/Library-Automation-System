using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace FacadeLayer
{
   public  class FKategori
    {
        public static int Insert(EntityLayer.EKategori item)
        {
            int etkilenen = 0;
            try {
                SqlCommand com = new SqlCommand("Kategori_İnsert ", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
               
                    if (com.Connection.State != ConnectionState.Open)
                    {
                        com.Connection.Open();
                    }
                    com.Parameters.AddWithValue("Adi", item.Adi);
                    etkilenen = com.ExecuteNonQuery();
                }
                catch
            {
                etkilenen = -1;

            }
            return etkilenen;
        }

        public static bool Update(EntityLayer.EKategori item)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("Kategori_Update ", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ID", item.ID);
                com.Parameters.AddWithValue("Adi", item.Adi);
                sonuc = com.ExecuteNonQuery() > 0 ;
            }
            catch
            {
                sonuc = false;

            }
            return sonuc;
        }

        public static EKategori Select(string _Adi)
        {
            throw new NotImplementedException();
        }

        public static bool Delete(int _ID)
        { 
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("Kategori_Delete ", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ID", _ID);
               
                sonuc = com.ExecuteNonQuery() > 0;
            }
            catch
            {
                sonuc = false;

            }
            return sonuc;
        }
        public static EKategori Select(int _ID)
        {
            EKategori item = null;
            try
            {
                SqlCommand com = new SqlCommand("Kategori_Select ", Baglanti.Con);
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
                        item = new EKategori();
                        item.ID = Convert.ToInt32(rdr["Id"]);
                        item.Adi = rdr["Adı"].ToString();
                        
                    }
                }
            }
            catch
            {
                item = null ;

            }
            return item;
        }
        public static List<EntityLayer.EKategori> SelectList()
        {
            List<EntityLayer.EKategori> itemlist = null;
            try
            {
                SqlCommand com = new SqlCommand("Kategori_SelectList ", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
               

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemlist = new List<EntityLayer.EKategori>();
                    while (rdr.Read())
                    {
                        EntityLayer.EKategori item = new EntityLayer.EKategori();
                        item = new EntityLayer.EKategori();
                        item.ID = Convert.ToInt32(rdr["Id"]);
                        item.Adi = rdr["Adı"].ToString();
                        itemlist.Add(item);


                    }
                }
                rdr.Close();
            }
            catch
            {
                itemlist = null;

            }
            return itemlist;
        }



    }

}
    

