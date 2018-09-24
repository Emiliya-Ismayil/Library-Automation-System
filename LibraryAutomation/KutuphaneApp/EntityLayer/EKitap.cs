using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EKitap : IDisposable
    {
        private int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        private string _Adi;
        public string Adi
        {
            get
            {
                return _Adi;
            }

            set
            {
                _Adi = value;
            }
        }

       


        private short _SayfaSayisi;
        public short SayfaSayisi
        {
            get
            {
                return _SayfaSayisi;
            }

            set
            {
                _SayfaSayisi = value;
            }
        }

        private int _KategoriİD;
        public int Kategoriİd
        {
            get
            {
                return _KategoriİD;
            }

            set
            {
                _KategoriİD = value;
            }
        }

     

    

        private string _Yazar;
        public string Yazar
        {
            get
            {
                return _Yazar;
            }

            set
            {
                _Yazar = value;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
