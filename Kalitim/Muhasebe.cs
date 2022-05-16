using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Muhasebe:Personel,IMuhasebe
    {

        public Muhasebe()
        {
            Maas = 6000;
        }
        public void KdvHesapla()
        {
            throw new NotImplementedException();
        }
        public void MaasOde()
        {
            throw new NotImplementedException();

        }
        public void VergıOde()
        {
            throw new NotImplementedException();

        }
    }
}
