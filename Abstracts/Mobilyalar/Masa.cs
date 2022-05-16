using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts.Mobilyalar
{
    internal class Masa:Mobilya
    {
        public int AyakSayisi { get; set; }
        public string Malzeme { get; set; }
        public int cekmeceSayisi { get; set; }

        public override void OzellikleriYaz()
        {
            Console.WriteLine("Masanın Ozellikleri");
            Console.WriteLine("Malzeme:"+Malzeme);
            Console.WriteLine("Ayak sayisi:" + AyakSayisi);
            Console.WriteLine("Cekmece Sayisi:" + cekmeceSayisi);
        }
    }
}
