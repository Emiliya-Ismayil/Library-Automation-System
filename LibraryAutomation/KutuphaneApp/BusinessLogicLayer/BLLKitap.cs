using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
   public  class BLLKitap
    {
        public static int İnsert(EKitap item )
        {
            if (item.Adi != null && item.Adi.Trim().Length > 0 && item.Yazar != null && item.Yazar.Trim().Length > 0 && item.SayfaSayisi > 0)
            {
                return FKitap.Insert(item);
            }

            return -1;

        }

        public static bool Update(EKitap item)
        {
            if (item.Adi != null && item.Adi.Trim().Length > 0 && item.Yazar != null && item.Yazar.Trim().Length > 0 && item.ID > 0 && item.Kategoriİd > 0 && item.SayfaSayisi > 0)
            {
                return FKitap.Update(item);
            }
           
                return false;

        }

        public static bool Delete(int _ID)
        {
            if (_ID > 0)
            {
                return FKitap.Delete(_ID);
            }
            return false;
        }
        public static EKitap Select(int _ID)
        {
            if(_ID > 0)
            {
                return FKitap.Select(_ID);
            }
            return null;
        
        }
        public static List<EKitap> SelectList()
        {
            return FKitap.SelectList();
        }
    }
}
