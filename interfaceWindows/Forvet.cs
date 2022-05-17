using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceWindows
{
    internal class Forvet : IFutbolcu
    {

        public string AdSoyad { get; set; }
        public string FormaNumarasi { get; set; }

        public int Sutgucu { get; set; }
        public int Refleks { get; set; }
        public bool HangiAyak { get; set; }
        public int Agresiflik { get; set; }

        public bool Millimi { get; set; }

        public void MarkajYap()
        {
            throw new NotImplementedException();
        }


        public void OfSaytPozisyonuAl()
        {

        }
        public void SutCek()
        {
            throw new NotImplementedException();
        }

        public void CalimAt()
        {
            throw new NotImplementedException();
        }

        public void PresYap()
        {
            throw new NotImplementedException();
        }  
        public void PenaltiKullan()
        {

        }
        public void GolAt()
        {

        }
    }
}
