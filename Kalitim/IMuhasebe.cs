using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public interface IMuhasebe
    {
        public void KdvHesapla();
        public void MaasOde();
        public void VergıOde();
    }
}
