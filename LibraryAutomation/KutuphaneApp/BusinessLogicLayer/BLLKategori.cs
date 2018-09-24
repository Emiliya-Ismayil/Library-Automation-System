using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
   public  class BLLKategori
    {
        public static int İnsert(EKategori item )
        {
            if(item.ID > 0 && item.Adi!=null && item.Adi.Trim().Length > 0)
            {
                return FKategori.Insert(item);

            }

               return -1;
        }
        public static bool Update(EKategori item)
        {
            if (item.ID > 0 && item.Adi != null && item.Adi.Trim().Length > 0)
            {
                return FKategori.Update(item);

            }

            return false;

        }

        public static bool Delete(int _ID)
        {
            if (_ID > 0)
            {
                return FKategori.Delete(_ID);
            }
            return false;
        }

        public static EKategori Select(int _ID)
        {
            if (_ID > 0)
            {
                return FKategori.Select(_ID);
            }
            return null;
        }
        public static List<EKategori> SelectList()
        {
            return FKategori.SelectList();
        }
        
    }
}
