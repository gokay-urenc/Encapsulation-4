using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_4
{
    class Kisi
    {
        public string adi { get; set; }

        public string soyadi { get; set; }

        private int yas;

        public int Yas
        {
            get
            {
                return yas;
            }
            set
            {
                yas = value;
                if (yas < 18)
                {
                    adi = veli;
                }
            }
        }

        public string veli { get; set; }
    }
}