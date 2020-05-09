using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_4
{
    class Ogrenci
    {
        public string ad { get; set; }

        public string soyad { get; set; }

        public char cinsiyet { get; set; }

        private int yas { get; set; }

        public int Yas
        {
            get
            {
                return yas;  
            }
            set
            {
                if (value < 18)
                {
                    yas = 18;
                }
                else
                {
                    yas = value;
                }
            }
        }
    }
}