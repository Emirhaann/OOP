using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class SatisElemani:Personel
    {

        //Sadece miras verdiği classlardan ulaşılabilir
        //dışarıya açık değildir protected.
        protected bool ArabasıVarmi { get; set; }
        public void ToplantiYap()
        {

        }
        public void MusteriZiyaretEt()
        {

        }
        public void SatisYap()
        {

        }
        public SatisElemani()
        {
            Maas = Maas + 2000;
        }
    }
}
