using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Personel:Kisi
    {
        public int Maas { get; set; }
        public string Departman { get; set; }

        public Personel()
        {
            Maas = 4500;
        }
        public Personel(string ad, string soyad)
        {
            Adi = ad;
            Soyadi = soyad;

        }
    }
}
