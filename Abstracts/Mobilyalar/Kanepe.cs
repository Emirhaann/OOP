using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts.Mobilyalar
{
   internal class Kanepe:Mobilya
    {
        public string  Kumasturu { get; set; }
        public bool Bazalimi { get; set; }

        public override void OzellikleriYaz()
        {
            Console.WriteLine("kanepenin Ozellikleri");
            Console.WriteLine("Kumas turu:" + Kumasturu);
            Console.WriteLine("Bazalimi:" + Bazalimi);
        }
    }
   
}
