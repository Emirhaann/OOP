using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts.Mobilyalar
{
    public abstract class Mobilya
    {
    public string Renk { get; set; }

        public string Model { get; set; }

   
        public string Malzemesi { get; set; }
        public abstract void OzellikleriYaz();       
    }
}
