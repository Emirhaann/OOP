using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizim2
{
    internal class cember:Hesapla
    {
        public int YariCap { get; set; }
        public double Cevre()
        {
            return 2 * YariCap * Math.PI;
        }
        public override double Alan()
        {
            return Math.PI * Math.Pow(YariCap, 2);
        }
    }
}
