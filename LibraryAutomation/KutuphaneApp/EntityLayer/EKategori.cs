using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EKategori : IDisposable
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

        public override string ToString()
        {
        
            return this.Adi;

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
